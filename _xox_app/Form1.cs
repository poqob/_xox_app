using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testScript;
using _xox_app.game;

namespace _xox_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            testScript.testClass tt = new testClass();
            Game newGame = new Game("name","number",Sides.X);
            this.button1.Text = newGame.ToString();
        }
    }
}
