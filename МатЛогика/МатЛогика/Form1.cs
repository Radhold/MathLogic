using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace МатЛогика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчики: Фоменко Ярослав,\n Федорова Анастасия,\n Смолин Александр,\n Кузнецов Владимир", 
                "Инфо о разрабах",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult= MessageBox.Show("Нажимая \"Да\", Вы соглашаетесь, что мы не несем ответственность за поставленный диагноз. Необходима консультация специалиста!",
                "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (DialogResult.Yes == DialogResult)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
        }
    }
}
