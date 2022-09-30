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
    public partial class Frm_Alarm : Form
    {
        public Frm_Alarm()
        {
            InitializeComponent();
        }



        bool b = false; //時間到了沒

        private void Frm_Alarm_Load(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString("HH:mm:ss"); //開啟視窗便顯示出當前時間 ; 24小時制HH
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lab_Time.Text = DateTime.Now.ToString("HH:mm:ss");

            if (b == false)
            {
                if (h == DateTime.Now.Hour)
                {
                    if(m == DateTime.Now.Minute)
                    {

                        b = true; //時間到
                        MessageBox.Show("時間到");

                        //-------------------------------震動視窗
                        Point now_p = this.Location; //定義現在座標(x,y)為now_p
                        Random r = new Random();
                        for(int i = 0; i < 50; i++)
                        {
                            Point new_p = new Point(now_p.X + r.Next(-10, 10), now_p.Y + r.Next(-10, 10)); //定義新位置座標 Point(原point的X座標+隨機-10到10之間的值,原point的Y座標+隨機-10到10之間的值)
                            this.Location = new_p; //到新位置
                            System.Threading.Thread.Sleep(20); //暫停20毫秒
                            this.Location = now_p; //還原初始位置
                        }
                        //-------------------------------
                    }
                }
            }
        }
        int h, m;
        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                b = false; //進判斷
                h = int.Parse(txt_H.Text); //int h =輸入的小時值
                m = int.Parse(txt_M.Text); //int m =輸入的分鐘值
                //MessageBox.Show("on");
            }
            else
            {
                //MessageBox.Show("off");
            }
        }
        /*
         Random.Next(最小值,最大值) : 傳回指定範圍內的隨機整數
        Point(x,y)座標
         */

    }
}
