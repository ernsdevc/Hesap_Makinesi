using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9_Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value = 0; // hesaplanan değer
        string operation = ""; // işlem
        bool operation_pressed = false; // rakam mı işlem mi
        bool esitmi = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (esitmi == true)
            {
                value = 0;
                txt_sonuc.Clear();
                esitmi = false;
            }

            if (txt_sonuc.Text == "0" || operation_pressed == true)
            {
                txt_sonuc.Clear();
            }

            operation_pressed = false;
            Button b = (Button)sender;
            txt_sonuc.Text = txt_sonuc.Text + b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation_pressed = true;
            operation = b.Text;
            value = Double.Parse(txt_sonuc.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_sonuc.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txt_sonuc.Clear();
            value = 0;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+": txt_sonuc.Text = (value + double.Parse(txt_sonuc.Text)).ToString();
                    break;

                case "-": txt_sonuc.Text = (value - double.Parse(txt_sonuc.Text)).ToString();
                    break;

                case "*": txt_sonuc.Text = (value * double.Parse(txt_sonuc.Text)).ToString();
                    break;

                case "/": txt_sonuc.Text = (value / double.Parse(txt_sonuc.Text)).ToString();
                    break;
            }

            esitmi = true;
        }
    }
}
