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
    public partial class Level3 : Form
    {

        bool movingLeft = false;
        bool movingRight = false;
        bool playerJumping = false;

        int playerJumpSpeed = 10;
        int force = 8;
        int score = 0;

        public Level3()
        {
            InitializeComponent();
        }

        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movingLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                movingRight = true;
            }

            if (e.KeyCode == Keys.Space && !playerJumping)
            {
                playerJumping = true;
            }
        }

        private void Level3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                movingLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                movingRight = false;
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
                        score++;
                    }
                }
            }

            gemLabel.Text = "Score: " + score;
        }
    }
}
