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
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
        }

        private void btn_level1_Click(object sender, EventArgs e)
        {
            Level1 level1 = new Level1();
            level1.Show();
            this.Visible = false;
        }

        private void btn_level2_Click(object sender, EventArgs e)
        {
            Level2 level2 = new Level2();
            level2.Show();
            this.Visible = false;
        }

        private void btn_level3_Click(object sender, EventArgs e)
        {
            Level3 level3 = new Level3();
            level3.Show();
            this.Visible = false;
        }

        private void btn_level4_Click(object sender, EventArgs e)
        {
            Level4 level4 = new Level4();
            level4.Show();
            this.Visible = false;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
