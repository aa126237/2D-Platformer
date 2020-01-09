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
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void MenuScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_startGame_Click(object sender, EventArgs e) // Start Button
        {
            Form1 level1 = new Form1();
            level1.Show();
            this.Visible = false;
        }

        private void btn_exitGame_Click(object sender, EventArgs e) // Exit Button
        {

        }

        private void btn_Options_Click(object sender, EventArgs e)
        {

        }
    }
}
