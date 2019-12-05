using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МатЛогика
{
    class Symptoms
    {
       public string Num { get; set; }
        public string Text { get; set; }
        public string Gender { get; set; }
        public List <string> connect = new List <string> (); //лист, хранящий симптомы, сопряженный с выбранным
        public HashSet<string> ill = new HashSet <string>(); //сет, хранящий возможное(ые) заболевание(я)
        public bool Flag { get; set; } //чтобы понять, был ли уже этот симптом
        public Symptoms () {
            Num = "";
            Text = "";
            Gender = "";
            connect.Clear();
            ill.Clear();
            Flag = true; }
    }
}
