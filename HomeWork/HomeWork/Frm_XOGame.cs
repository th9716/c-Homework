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
    public partial class Frm_XOGame : Form
    {

        Button[] buttons = new Button[9];
        bool isGameOver = false;
        bool isO = true; // to determine if X or O is current character


        public Frm_XOGame()
        {
            InitializeComponent();
        }


        void BtnControls()
        {
            buttons = new Button[9] { Btn_1, Btn_2, Btn_3, Btn_4, Btn_5, Btn_6, Btn_7, Btn_8, Btn_9};
            for(int i = 0; i < buttons.Length; i++)
            {
                
            }
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_4_Click(object sender, EventArgs e)
        {

        }

        private void Btn_5_Click(object sender, EventArgs e)
        {

        }

        private void Btn_6_Click(object sender, EventArgs e)
        {

        }

        private void Btn_7_Click(object sender, EventArgs e)
        {

        }

        private void Btn_8_Click(object sender, EventArgs e)
        {

        }

        private void Btn_9_Click(object sender, EventArgs e)
        {

        }
    }
}
