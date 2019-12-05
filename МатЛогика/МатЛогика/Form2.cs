using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
namespace МатЛогика
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AddAge();
        }
        void AddAge()
        {
            int[] age = new int[100];
            int num = 1;
            for (int i = 0; i < age.Length; i++)
            {
                age[i] = num;
                comboBox1.Items.Add(age[i]);
                num++;
            }
        }
        List<Symptoms> symp = new List<Symptoms>();
        List<AgeH> ah = new List<AgeH>();
        int number = 2;
        int top = 0;
        HashSet<string> illSet = new HashSet<string>(); // множество для того, чтобы проверять, какие заболевания могут быть. 
        // Это нужно, чтобы выводить корректно симптомы (если есть такие, которые у нскольких заболеваний)
        void SelecteSymptom(object sender, EventArgs e)
        {
            foreach (Control x in sympPanel.Controls) // заполнение множества с заболеваниями. проход по всем комбобоксам, чтобы выявить, какие симптомы могут быть
                if (x is ComboBox)
                    for (int elem = 1; elem < symp.Count; elem++)
                        if (((ComboBox)sender).SelectedValue.Equals(symp[elem].Num))
                            if (!illSet.Any())
                                illSet = symp[elem].ill;
                            else
                                illSet.IntersectWith(symp[elem].ill); // самая главная штука из-за которой я использую HashSet (т.к LINQ, как бы сказал З.М, некорректно) 
            List<Symptoms> newSympList = new List<Symptoms>();
            Symptoms nullObj = new Symptoms(); //костыль, чтобы показывался пустой 1й элемент
            newSympList.Add(nullObj);
            for (int elem = 1; elem < symp.Count; elem++) //добавление симптомов
            {
                if (((ComboBox)sender).SelectedValue.Equals(symp[elem].Num))
                    /*ищем элемент с данным номером в листе.
                    Вся реализация программы заключается в том, что к comboBox привязываются данные из листа.
                    Это позволяет использовать в качестве индексов элемента Бокса номера, которые записаны в файле.
                    Этот подход облегчает поиск. Т.к по тексту искать не получается (тупо пустая строка) 
                    */
                    foreach (string newSymp in symp[elem].connect)
                    {
                        if (male.Checked && symp[elem].Gender != "Ж")
                            addNewList(newSympList, newSymp);
                        else if (fem.Checked && symp[elem].Gender != "М")
                            addNewList(newSympList, newSymp);
                    }
            }

            if (newSympList.Count > 1 && illSet.Count()>1) //проверка на то, нужно ли добавлять ComboBox
            { //Добавление ComboBox
                top += comboBox2.Top;
                ComboBox comboBox = new ComboBox();
                number++;
                comboBox.Name = "comboBox" + number;
                comboBox.ForeColor = comboBox2.ForeColor;
                comboBox.Size = comboBox2.Size;
                comboBox.Location = comboBox2.Location;
                comboBox.Top += top;
                comboBox.DataSource = newSympList;
                comboBox.DisplayMember = "Text";
                comboBox.ValueMember = "Num";
                sympPanel.Controls.Add(comboBox);
                comboBox.SelectedValueChanged += comboBox2_SelectedValueChanged; // вещаем делегатик
            }
            else if (illSet.Count==1) //если уже есть только 1 возможное заболевание, то он его выводит сразу и закрывает форму
            {
                MessageBox.Show($"На основании Ваших симптомов и данных у Вас: {illSet.First()}. Необходима консультация специалиста!",
                    "Диагноз",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                Dispose();
            }
            else //случай, возникающий если не выбраны никакие симптомы (Ничего из перечисленного)
                MessageBox.Show ("Скорее всего, Вы здоровы. Необходима консультация специалиста!",
                    "Диагноз",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            Dispose();
        }

        private void addNewList(List<Symptoms> NewSympList, string NewSymp) //функция, проверяющая номер из файла (а не индекс) сопряженного и состояние флага
        {

            foreach (Symptoms obj in symp)
            {
                obj.ill.IntersectWith(illSet);
                if (obj.Num == NewSymp && obj.Flag && obj.ill.Any())
                    NewSympList.Add(obj);
            }
        }
        private void addNewList(Symptoms Obj)
        {
            if ((Obj.ill.Contains("гигантизм") || Obj.ill.Contains("АКР")) && Obj.ill.Count == 1)
            {
                foreach (AgeH ahObj in ah)
                    if (int.Parse(comboBox1.Text) == ahObj.Age || ahObj.Age == 20 && int.Parse(comboBox1.Text) > 20)
                        if (double.Parse(maskedTextBox1.Text) >= ahObj.Height)
                            symp.Add(Obj);
            }
            else
                symp.Add(Obj);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            genPanel.Visible = true;
        }
        private void CheckedChanged(object sender, EventArgs e)
        {
            heightPanel.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e) //первичное заполнение списка симптомами
        {
            try
            {
                if (maskedTextBox1.Text == "")
                    throw new Exception(message: "Введите рост");
                string filename = null;
                if (male.Checked)
                    filename = "РостМ.txt";
                else
                    filename = "РостЖ.txt";
                string[] text1 = File.ReadAllLines(@filename);
                var words1 = text1.Select(line => line.Split(';')); //читаем файл, заполняем лист
                foreach (string[] elem in words1) //Заполнение списка параметрами возраста и роста
                {
                    AgeH obj = new AgeH();
                    obj.Age = int.Parse(elem[0]);
                    obj.Height = double.Parse(elem[1]);
                    ah.Add(obj);
                }
                string[] text2 = File.ReadAllLines(@"Логика — копия.txt");
                var words2 = text2.Select(line => line.Split(';')); //читаем файл, заполняем лист
                Symptoms nullObj = new Symptoms();
                symp.Add(nullObj); // опять костыль
                int resultofParse;
                bool success = false;
                foreach (string[] elem in words2) //заполнение списка симптомов
                {
                    Symptoms obj = new Symptoms();
                    obj.Num = elem[0];
                    obj.Text = elem[1];
                    obj.Gender = elem[2];
                    for (int i = 3; i < elem.Length; i++)
                    {
                        success = int.TryParse(elem[i], out resultofParse);
                        if (success)
                            obj.connect.Add(elem[i]);
                        else
                            obj.ill.Add(elem[i]);
                    }
                    if (male.Checked && obj.Gender != "Ж")
                        addNewList(obj);

                    else if (fem.Checked && obj.Gender != "М")
                        addNewList(obj);
                } 
                foreach (Control x in this.Controls)
                {
                    if (x is Panel && x.Name != "sympPanel")
                        x.Enabled = false;
                }
                sympPanel.Visible = true;
                comboBox2.DataSource = symp;
                comboBox2.DisplayMember = "Text";
                comboBox2.ValueMember = "Num";
            }
            catch (Exception exc) 
            {
                MessageBox.Show(exc.Message,
                    "Исключение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedIndex != 0)
            {
                foreach (Symptoms obj in symp)
                {
                    if (obj.Num.Equals(((ComboBox)sender).SelectedValue))
                        obj.Flag = false;
                }
                SelecteSymptom(sender, e);
                ((ComboBox)sender).Enabled = false;
            }
        }
    }
}
