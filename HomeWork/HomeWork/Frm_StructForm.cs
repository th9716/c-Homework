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
    public partial class Frm_StructForm : Form
    {
        public Frm_StructForm()
        {
            InitializeComponent();
        }


        //M19
        string result = "";
        int max =0;
        int min = 0;
        string MaxSubject;
        string MinSubject;


        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string name = txt_Name.Text;
            int Ch = int.Parse(txt_Chinese.Text);
            int Mt = int.Parse(txt_Math.Text);
            int En = int.Parse(txt_English.Text);


            result = $"姓名: {name}  \n國文: {Ch} 分 \n數學: {Mt} 分  \n英文: {En} 分  \n";



        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            txt_ShowGrades.Text = result;
        }


        private void Btn_HLGrades_Click(object sender, EventArgs e)
        {
            int Ch = int.Parse(txt_Chinese.Text);
            int Mt = int.Parse(txt_Math.Text);
            int En = int.Parse(txt_English.Text);


            if (Ch>Mt && Ch >En)
            {
                max = Ch;
                MaxSubject = "國文";
            }
            else if (Mt > En)  //淘汰Ch比較Mt En
            {
                max=Mt;
                MaxSubject = "數學";
            }
            else  //淘汰En
            {
                max = En;
                MaxSubject = "英文";
            }


            if (Ch < Mt && Ch < En)
            {
                min = Ch;
                MinSubject = "國文";
            }
            else if (Mt < En)
            {
                min = Mt;
                MinSubject = "數學";
            }
            else
            {
                min = En;
                MinSubject = "英文";
            }



            txt_ShowHLGrades.Text = $"最高成績科目為:{MaxSubject} {max.ToString()}分 \n最低成績科目為:{MinSubject}{min.ToString()}分";


        }
    }
}
