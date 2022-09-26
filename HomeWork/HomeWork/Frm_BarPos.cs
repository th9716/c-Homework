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

   
        decimal TBeer = 0;
        decimal BAmount =0;
        decimal TTequila =0;
        decimal TAmount =0;
        string result;
        decimal total = 0;


        private void Btn_Beer_Click(object sender, EventArgs e)
        {
            BAmount += 1;
            TBeer += beer;
            total += TBeer;
            
            result = $"啤酒 Beer x {BAmount} , 共NT$ {TBeer} 元\n ";
            txt_List.Text = result;
            txt_TotalPrice.Text =$"NT$ {total.ToString()}" ;
        }

        private void Btn_Tequila_Click(object sender, EventArgs e)
        {
            TAmount += 1;
            TTequila += tequila;
            total += TTequila;

            result = $"龍舌蘭 Tequila x {TAmount} , 共NT$ {TTequila} 元\n "; 
            txt_List.Text = result;
            txt_TotalPrice.Text = $"NT$ {total.ToString()}";
        }

        private void Btn_Whisky_Click(object sender, EventArgs e)
        {



        }

        private void Btn_Wine_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ClearList_Click(object sender, EventArgs e)
        {
            txt_List.Clear();
            txt_TotalPrice.Clear();
        }
       
    }
}
