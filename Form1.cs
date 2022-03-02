using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double x, y, z, w;
        string s_x, s_y, s_z;
        public Form1()
        {
            InitializeComponent();
        }

        private double func(double x, double y, double z)
        {
            return Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2 * Math.Pow(Math.Sin(y),2)) * (1 + z+z*z/2+z*z*z/3+z*z*z*z/4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (0.4 * Math.Pow(10, 4)).ToString();
            textBox2.Text = (-0.875).ToString();
            textBox3.Text = (-0.475 * Math.Pow(10, -3)).ToString();
            textBox4.Text = "Лаб.раб. №2.Ст.гр. 21ИС Звинаревского С.С.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s_x = textBox1.Text.Replace('.', ',');
            s_y = textBox2.Text.Replace('.', ',');
            s_z = textBox3.Text.Replace('.', ',');
            if (s_x == "")
                s_x = "0";
            if (s_y == "")
                s_y = "0";
            if (s_z == "")
                s_z = "0";
            try
            {
                x = Convert.ToDouble(s_x);
                y = Convert.ToDouble(s_y);
                z = Convert.ToDouble(s_z);
                w = func(x, y, z);
                textBox4.Text = "Лаб.раб. №2.Ст.гр. 21ИС Звинаревского С.С.";
                textBox4.Text += Environment.NewLine + "X = " + x.ToString();
                textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
                textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
                textBox4.Text += Environment.NewLine + "Результат W = " + w.ToString();
            }
            catch (Exception ex)
            {
                textBox4.Text = (ex.Message);
            }
        }


    }
}
