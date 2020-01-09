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

        bool playerJumping = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmr_Gravity_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_Ground.Bounds) && playerJumping == false)
            {
                pb_Player.Top += 5;
            }
        }

        private void tmr_Up_Tick(object sender, EventArgs e)
        {
            if (pb_Player.Bounds.IntersectsWith(pb_Ground.Bounds) && playerJumping == false)
            {
                pb_Player.Top -= 50;
                playerJumping = true;
            }
        }

        private void tmr_Right_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_rightWall.Bounds))
            {
                pb_Player.Left += 5;
            }
        }

        private void tmr_Left_Tick(object sender, EventArgs e)
        {
            if (!pb_Player.Bounds.IntersectsWith(pb_leftWall.Bounds))
            {
                pb_Player.Left -= 5;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                tmr_Up.Start();
            }
            else if (e.KeyCode == Keys.Right)
            {
                tmr_Right.Start();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmr_Left.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                tmr_Up.Stop();
                playerJumping = false;
            }
            else if (e.KeyCode == Keys.Right)
            {
                tmr_Right.Stop();
            }
            else if (e.KeyCode == Keys.Left)
            {
                tmr_Left.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
