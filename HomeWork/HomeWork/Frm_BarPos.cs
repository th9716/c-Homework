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
    public partial class Frm_BarPos : Form
    {



        public Frm_BarPos()
        {
            InitializeComponent();
        }

        //------------------enum
        int beer = 120;
        int tequila = 180;
        int whisky = 350;
        int wine = 320;

        //---------------------
        decimal TBeer = 0;
        decimal BAmount =0;
        decimal TTequila =0;
        decimal TAmount =0;
        decimal TWhisky = 0;
        decimal WhAmount = 0;
        decimal TWine = 0;
        decimal WiAmount = 0;
        string result;
        decimal total = 0;


        //listBox.Items.Add("尚未點餐");


        private void Btn_Beer_Click(object sender, EventArgs e)
        {
            
            BAmount += 1;
            TBeer += beer;
            total += TBeer;
            
            result = $"啤酒 Beer x {BAmount} , 共NT$ {TBeer} 元\n ";
            
            txt_TotalPrice.Text = $"NT$ {total.ToString()}";
            listBox.Items.Add(result);
        }

        private void Btn_Tequila_Click(object sender, EventArgs e)
        {
            TAmount += 1;
            TTequila += tequila;
            total += TTequila;

            result = $"龍舌蘭 Tequila x {TAmount} , 共NT$ {TTequila} 元\n "; 
            
            txt_TotalPrice.Text = $"NT$ {total.ToString()}";
            listBox.Items.Add(result);

        }

        private void Btn_Whisky_Click(object sender, EventArgs e)
        {

            WhAmount += 1;
            TWhisky += whisky;
            total += TWhisky;

            result = $"威士忌 Whisky x {WhAmount} , 共NT$ {TWhisky} 元\n ";

            txt_TotalPrice.Text = $"NT$ {total.ToString()}";
            listBox.Items.Add(result);


        }

        private void Btn_Wine_Click(object sender, EventArgs e)
        {
            
            WiAmount += 1;
            TWine += wine;
            total += TWine;

            result = $"紅酒 Wine x {WiAmount} , 共NT$ {TWine} 元\n ";

            txt_TotalPrice.Text = $"NT$ {total.ToString()}";
            listBox.Items.Add(result);
        }

        private void Btn_ClearList_Click(object sender, EventArgs e)
        {
            
            txt_TotalPrice.Clear();
            listBox.Items.Clear();
        }
       
    }
}
