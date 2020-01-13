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
    public partial class Level4 : Form
    {

        bool movingLeft = false;
        bool movingRight = false;
        bool playerJumping = false;

        int playerJumpSpeed = 10;
        int force = 8;
        int gemsCollected = 0;
        int gemsLeft = 8;

        public Level4()
        {
            InitializeComponent();
        }

        private void Level4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                movingLeft = true;
                pb_Player.Image = Properties.Resources.RunningLeft;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                movingRight = true;
                pb_Player.Image = Properties.Resources.RunningRight;
            }

            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.W || e.KeyCode == Keys.Up) && !playerJumping)
            {
                playerJumping = true;
            }
        }

        private void Level4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                movingLeft = false;
                pb_Player.Image = Properties.Resources.StandingLeft;
            }

            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                movingRight = false;
                pb_Player.Image = Properties.Resources.StandingRight;
            }

            if (playerJumping)
            {
                playerJumping = false;
            }
        }

        private void tmr_movement_Tick(object sender, EventArgs e)
        {
            pb_Player.Top += playerJumpSpeed;

            if (playerJumping && force < 0)
            {
                playerJumping = false;
            }

            if (movingLeft)
            {
                pb_Player.Left -= 5;
            }

            if (movingRight)
            {
                pb_Player.Left += 5;
            }

            if (playerJumping)
            {
                playerJumpSpeed = -12;
                force -= 1;
            }

            else
            {
                playerJumpSpeed = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (pb_Player.Bounds.IntersectsWith(x.Bounds) && !playerJumping)
                    {
                        force = 8;
                        pb_Player.Top = x.Top - pb_Player.Height;
                    }
                }

                if (x is PictureBox && x.Tag == "gem")
                {
                    if (pb_Player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        gemsCollected++;
                        gemsLeft--;
                    }
                }
            }

            gemLabel.Text = "Collect " + gemsLeft + " more gems";

            if (gemsCollected == 8)
            {
                tmr_movement.Stop();
                MessageBox.Show("Congratulations you beat the game!");
                Menu menu = new Menu();
                menu.Show();
                this.Visible = false;
            }
        }

        private void pb_settings_Click(object sender, EventArgs e)
        {
            PauseMenu pauseMenu = new PauseMenu();
            pauseMenu.Show();
        }
    }
}
