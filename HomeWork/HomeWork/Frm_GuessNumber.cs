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
        

        
        //建立類別實體
        ClassGuess gus = new ClassGuess();
        public Frm_GuessNumber()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Guess gu = new Frm_Guess(this);
            gu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Anser:{ClassGuess.AnswerNumber}");
            //重新產生亂數
            gus.buildAnNumber();

        }
        private void Frm_GuessNumber_Load(object sender, EventArgs e)
        {
            gus.buildAnNumber();
        }
    }
}
