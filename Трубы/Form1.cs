using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Трубы
{

    public partial class Form1 : Form
    {

        double r;
        double R;
        double l;
        double p;
        double V;
        double m;
        double s;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // if (textBox1.Text == )

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {

                MessageBox.Show("Заполните все поля!");


            }
            else
            {


                l = 0;
                r = 0;
                l = Convert.ToInt32(textBox1.Text);
                r = Convert.ToInt32(textBox2.Text);
                double d = r + r;
                V = 3.14 * (d * d) / 4 * l / 1000000;


                if (V < 0)
                {
                    MessageBox.Show("Введены некорректные значения");
                }
                if (r > 0 && l > 0)
                {
                    string res1 = Convert.ToString(V);
                    MessageBox.Show("Объем равен: " + res1);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так");
                }

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля!");

            }
            else
            {
                l = 0;
                r = 0;
                R = 0;
                p = 0;
                l = Convert.ToInt32(textBox1.Text);
                p = Convert.ToInt32(textBox4.Text);
                R = Convert.ToInt32(textBox3.Text);
                r = Convert.ToInt32(textBox2.Text);

                double t = R - r;
                double D = R * 2;

                double res2 = p * t * 3.14 * (D - t);



                if (res2 < 0)
                {
                    MessageBox.Show("Введены некорректные значения");
                }

                if (r > 0 && p > 0 && R > 0 && l > 0)
                {
                    string res3 = Convert.ToString(V);
                    MessageBox.Show("Объем равен: " + res2);
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
        }
    }
}
