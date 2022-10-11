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
    public partial class Frm_Homepage : Form
    {
        public Frm_Homepage()
        {
            InitializeComponent();
        }

        private void btn_loan_Click(object sender, EventArgs e)
        {
            Frm_Loan loan = new Frm_Loan();
            loan.Show();
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            Frm_BarPos barPos = new Frm_BarPos();
            barPos.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Frm_MyClac myclac = new Frm_MyClac();
            myclac.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Frm_Alarm alarm = new Frm_Alarm();
            alarm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Frm_NotePad notepad = new Frm_NotePad();
            notepad.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Frm_小畫家 paint = new Frm_小畫家();
            paint.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Frm_XOGame xoGame = new Frm_XOGame();
            xoGame.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_StructForm structForm = new Frm_StructForm();
            structForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_GuessNumber guessNumber=new Frm_GuessNumber();
            guessNumber.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Hello hello = new Frm_Hello();
            hello.Show();
        }
    }
}
