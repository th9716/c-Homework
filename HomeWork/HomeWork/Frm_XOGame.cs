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

        private bool turn = true;
        private int turnCount = 0;

        private Game play1 = new Game()
        {
            playerNumber = "Player1 (X)",
            playerScore = 0
        };

        private Game play2 = new Game()
        {
            playerNumber = "Player2 (O)",
            playerScore = 0
        };


        public Frm_XOGame()
        {
            InitializeComponent();
        }

        

    private void Frm_XOGame_Load(object sender, EventArgs e)
        {
            Btn_Result.Enabled = false;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (turn)
            {
                button.Text = "X";
                turn = false;
            }
            else
            {
                button.Text = "O";
                turn = true;
            }
            button.Enabled = false;
            turnCount++;
            WinnerSetting();

        }

        private void WinnerSetting()
        {
            bool winnerConfirm = false;

            if(Btn_1.Text == Btn_2.Text && Btn_2.Text == Btn_3.Text && Btn_2.Text !="")
                winnerConfirm = true;
            else if(Btn_4.Text == Btn_5.Text && Btn_5.Text == Btn_6.Text && Btn_5.Text != "")
                winnerConfirm = true;
            else if (Btn_7.Text == Btn_8.Text && Btn_8.Text == Btn_9.Text && Btn_8.Text != "")
                winnerConfirm = true;
            else if (Btn_1.Text == Btn_4.Text && Btn_4.Text == Btn_7.Text && Btn_4.Text != "")
                winnerConfirm = true;
            else if (Btn_2.Text == Btn_5.Text && Btn_5.Text == Btn_8.Text && Btn_5.Text != "")
                winnerConfirm = true;
            else if (Btn_3.Text == Btn_6.Text && Btn_6.Text == Btn_9.Text && Btn_6.Text != "")
                winnerConfirm = true;
            else if (Btn_1.Text == Btn_5.Text && Btn_5.Text == Btn_9.Text && Btn_5.Text != "")
                winnerConfirm = true;
            else if (Btn_3.Text == Btn_5.Text && Btn_5.Text == Btn_7.Text && Btn_5.Text != "")
                winnerConfirm = true;
            else
            {

            }

            if (winnerConfirm)
            {
                DisableButton();
                string winner = "";
                if (turn)
                {
                    winner = play2.playerNumber;
                    play2.playerScore++;
                    Player2Box.Text = play2.playerScore.ToString();
                }
                else
                {
                    winner = play1.playerNumber;
                    play1.playerScore++;
                    Player1Box.Text = play1.playerScore.ToString();
                }
                MessageBox.Show(winner + "獲勝", "訊息");
                Btn_Result.Enabled = true;

            }
            else if(turnCount == 9)
            {
                MessageBox.Show("平手", "訊息");
                Btn_Result.Enabled = true;
            }
            else
            {
                Btn_Result.Enabled = false;
            }


        }

        private void DisableButton()
        {
            Btn_2.Enabled = false;
            Btn_3.Enabled = false;
            Btn_4.Enabled = false;
            Btn_5.Enabled = false;
            Btn_6.Enabled = false;
            Btn_7.Enabled = false;
            Btn_8.Enabled = false;
            Btn_9.Enabled = false;
        }

        private void Btn_Result_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;

            Btn_1.Enabled = true;
            Btn_2.Enabled = true;
            Btn_3.Enabled = true;
            Btn_4.Enabled = true;
            Btn_5.Enabled = true;
            Btn_6.Enabled = true;
            Btn_7.Enabled = true;
            Btn_8.Enabled = true;
            Btn_9.Enabled = true;


            Btn_1.Text = "";
            Btn_2.Text = "";
            Btn_3.Text = "";
            Btn_4.Text = "";
            Btn_5.Text = "";
            Btn_6.Text = "";
            Btn_7.Text = "";
            Btn_8.Text = "";
            Btn_9.Text = "";

        }

        private void newGameToolStripMenuItemClick(object sender, EventArgs e)
        {
            Btn_Result.Enabled = false;
            turn = true;
            turnCount = 0;
            play1.playerScore = 0;
            play2.playerScore = 0;
            Player1Box.Text = "";
            Player2Box.Text = "";

            Btn_1.Enabled = true;
            Btn_2.Enabled = true;
            Btn_3.Enabled = true;
            Btn_4.Enabled = true;
            Btn_5.Enabled = true;
            Btn_6.Enabled = true;
            Btn_7.Enabled = true;
            Btn_8.Enabled = true;
            Btn_9.Enabled = true;

            Btn_1.Text = "";
            Btn_2.Text = "";
            Btn_3.Text = "";
            Btn_4.Text = "";
            Btn_5.Text = "";
            Btn_6.Text = "";
            Btn_7.Text = "";
            Btn_8.Text = "";
            Btn_9.Text = "";

        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            if(keyData == (Keys.Escape))
            {
                Close();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }



    }
}
