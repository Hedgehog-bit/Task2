using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float x = float.Parse(this.x.Text); 
            float y = float.Parse(this.y.Text);

            if ((x > 10 || x < 0) || (y > 5 || y < 0))
                this.Output1.Text = "Вне";
            else if ((x < 10 && x > 0) && (y < 5 && y > 0))
                this.Output1.Text = "Внутри";
            else
                this.Output1.Text = "На границе";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string i = this.Priz.Text;
            if (i == "а") this.Output2.Text = "Максимальная скорость автомобиля = 228 км/ч"; 
            else if (i == "в") this.Output2.Text = "Максимальная скорость велосипеда = 50 км/ч";
            else if (i == "м") this.Output2.Text = "Максимальная скорость мотоцикла = 402 км/ч";
            else if (i == "с") this.Output2.Text = "Максимальная скорость самолета = 8200,8 км/ч";
            else if (i == "п") this.Output2.Text = "Максимальная скорость поезда = 581 км/ч";
            else
                this.Output2.Text = "Такого признака нет!";
                
        }
    }
}
