using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_startGame_Click(object sender, EventArgs e)
        {
            MenuScreen level1 = new MenuScreen();
            level1.Show();
            this.Visible = false;
        }

        private void btn_Options_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hi");
        }

        private void btn_exitGame_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Hi");
        }
    }
}
