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
    public partial class Frm_GuessNumber : Form
    {
        

        public static Frm_GuessNumber gn = new Frm_GuessNumber();

        public Frm_GuessNumber()
        {
            InitializeComponent();
            
            gn = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Guess guess = new Frm_Guess();
            guess.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Guess.g.Answer();
            
        }
    }
}
