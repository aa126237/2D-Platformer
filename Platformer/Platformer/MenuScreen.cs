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

        private void btn_loadGame_Click(object sender, EventArgs e)
        {
            Form1 level1 = new Form1();
            level1.Show();
            this.Visible = false;
        }
    }
}
