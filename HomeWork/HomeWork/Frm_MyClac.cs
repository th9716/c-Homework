using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm_MyClac : Form
    {
        public Frm_MyClac()
        {
            InitializeComponent();
        }

        

        private void Btn_Plus_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num1.Text);
            double num2 = double.Parse(txt_Num2.Text);

            double total = num1 + num2;
            string Ans = total.ToString();

            txt_Answer.Text = Ans;


        }

        private void Btn_Minus_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num1.Text);
            double num2 = double.Parse(txt_Num2.Text);

            double total = num1 - num2;
            string Ans = total.ToString();

            txt_Answer.Text = Ans;
        }

        private void Btn_Times_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num1.Text);
            double num2 = double.Parse(txt_Num2.Text);

            double total = num1 * num2;
            string Ans = total.ToString();

            txt_Answer.Text = Ans;
        }

        private void Btn_DividedBy_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt_Num1.Text);
            double num2 = double.Parse(txt_Num2.Text);

            double total = num1 / num2;
            string Ans = total.ToString();

            txt_Answer.Text = Ans;
        }
    }
}
