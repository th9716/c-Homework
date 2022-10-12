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
    public partial class Frm_Guess : Form
    {
        private Frm_GuessNumber frm;


        int guess;  //電腦亂數產生的答案
        int count;  //猜了幾次
        int min;    //猜完數字後的範圍最小值
        int max;    //猜完數字後的範圍最大值
        
        
        
        
        public Frm_Guess(Frm_GuessNumber form1)
        {
            InitializeComponent();
            frm = form1; //操作父視窗
            
        }

        ClassGuess gu = new ClassGuess();

        

       

       public void Answer()
        {
            Random rm = new Random();
            guess = rm.Next(1, 100);
            MessageBox.Show($"Answer:{guess}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gu.GuessPlay(txt_keyin.Text);

            frm.lab_GuessInfo.Text = $"{ClassGuess.GuessInfo}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Guess_Load(object sender, EventArgs e)
        {
            int x = (System.Windows.Forms.SystemInformation.WorkingArea.Width - this.Size.Width) / 2;  //螢幕寬1/2位置
            int y = (System.Windows.Forms.SystemInformation.WorkingArea.Height - this.Size.Height) / 2; //螢幕高 1/2位置
            this.Location = (Point)new Size(x, y); //窗體的起始位置為x,y
        }
    }
}
