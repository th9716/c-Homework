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
        public static Frm_Guess g = new Frm_Guess();
        

        int guess;  //電腦亂數產生的答案
        int count;  //猜了幾次
        int min;    //猜完數字後的範圍最小值
        int max;    //猜完數字後的範圍最大值
        
        
        
        
        public Frm_Guess()
        {
            InitializeComponent();
            g = this;
            
        }

        public void Num()
        {

        }

        public void Guess()
        {
            int keyin = int.Parse(txt_keyin.Text);

            count = 0;  //初始化猜的次數
            min = 1;
            max = 100;
            //建立亂數
            Random rm = new Random();
            guess = rm.Next(1, 100);

            if(keyin >= min && keyin <= max)
            {
                if(keyin == guess)
                {
                    MessageBox.Show($"Congradulation!You got {guess} !!!");
                }
                else if(keyin > guess)
                {
                    max = keyin;
                    Frm_GuessNumber.gn.txt_between.Text = $"Too Large!!\n"; /*+ $"Between {min} and {keyin}";*/
                }
                else if(keyin < guess)
                {
                    min = keyin;
                    Frm_GuessNumber.gn.txt_between.Text = $"Too Small!!\n"; /*+ $"Between {keyin} and {max}";*/
                }
                else
                {
                    Frm_GuessNumber.gn.txt_between.Text = $" Error !!!";
                }
            }

            

        }

       public void Answer()
        {
            Random rm = new Random();
            guess = rm.Next(1, 100);
            MessageBox.Show($"Answer:{guess}", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guess();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
