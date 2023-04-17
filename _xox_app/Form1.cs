using _xox_app.game;
using _xox_app.util;
using System;
using System.Windows.Forms;
using testScript;

namespace _xox_app
{
    public partial class Form1 : Form
    {
        //fields
        String defaultTxtBoxTxt = "Student Number";
        Game game;



        public Form1()
        {
            InitializeComponent();
            startUI();
            txtbox.Text = defaultTxtBoxTxt;
        }



        private void txtbox_TextChanged(object sender, EventArgs e)
        {
            if (InputController.controll(txtbox.Text))
                StartResetButton.Enabled = true;
            else
                StartResetButton.Enabled = false;
        }

        private void StartResetButton_Click(object sender, EventArgs e)
        {
            if (StartResetButton.Text.Contains("RESET"))
            {
                StartResetButton.Text = "START GAME";
                StartResetButton.Enabled = false;
                txtbox.Enabled = true;
                txtbox.Text = defaultTxtBoxTxt;
                game = new SingleGame("hooman", txtbox.Text, Sides.X);
                resetUI();
            }
            else
            {
                StartResetButton.Text = "RESET GAME";
                txtbox.Enabled = false;
                game = new SingleGame("hooman", txtbox.Text, Sides.X);
                ScoreResult.Text = game.turn.ToString();
                
             
            }
        }

        private string makeMove(int[] indexes)
        {
            game.play(indexes);
            ScoreResult.Text = game.getWinner()!=null?game.getWinner().ToString():"non";
            return GameBoard.getGameBoard()[indexes[0], indexes[1]];
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 0, 0 };
            btn1.Text = makeMove(coordinates);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 0, 1 };
            btn2.Text = makeMove(coordinates);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 0, 2 };


            btn3.Text = makeMove(coordinates);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 1, 0 };

            btn4.Text = makeMove(coordinates);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 1, 1 };
            btn5.Text = makeMove(coordinates);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 1, 2 };
            btn6.Text = makeMove(coordinates);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 2, 0 };
            btn7.Text = makeMove(coordinates);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 2, 1 };
            btn8.Text = makeMove(coordinates);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 2, 2 };
            btn9.Text = makeMove(coordinates);
        }

        private void resetUI()
        {
            // reset texts
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            // clickable false
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;

        }

        private void startUI()
        {

            // reset texts
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            // clickable true
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;

        }


    }
}
