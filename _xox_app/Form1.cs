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
            }
            else
            {
                StartResetButton.Text = "RESET GAME";
                txtbox.Enabled = false;
                game = new Game("hooman", txtbox.Text, Sides.X);

            }
        }

        private void makeMove(int[] indexes)
        {
            game.play(indexes);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[]{0,0};
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
            btn1.Text = "-";
          
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 0, 1 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 0, 2 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 1, 0 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 1, 1 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }









        private void btn6_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 1, 2 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 2, 0 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 2, 1 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int[] coordinates = new int[] { 2, 2 };
            makeMove(coordinates);
            char c = GameBoard.getGameBoard()[coordinates[0], coordinates[1]];
            if (c == ((char)Sides.X))
                btn1.Text = "X";
            else if (c == ((char)Sides.O))
                btn1.Text = "O";
            else
                btn1.Text = "-";
        }



    }
}
