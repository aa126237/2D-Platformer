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
    public partial class PauseMenu : Form
    {
        public PauseMenu()
        {
            InitializeComponent();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_levelSelect_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ActiveForm.Visible = false;
            LevelSelect levelSelect = new LevelSelect();
            levelSelect.Show();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ActiveForm.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
