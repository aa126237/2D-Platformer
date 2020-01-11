﻿namespace Platformer
{
    partial class Level2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pb_Ground = new System.Windows.Forms.PictureBox();
            this.pb_platform2 = new System.Windows.Forms.PictureBox();
            this.pb_platform4 = new System.Windows.Forms.PictureBox();
            this.pb_platform5 = new System.Windows.Forms.PictureBox();
            this.pb_platform3 = new System.Windows.Forms.PictureBox();
            this.pb_platform1 = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.tmr_movement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Ground
            // 
            this.pb_Ground.BackColor = System.Drawing.Color.Transparent;
            this.pb_Ground.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_Ground.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_Ground.Location = new System.Drawing.Point(-6, 425);
            this.pb_Ground.Name = "pb_Ground";
            this.pb_Ground.Size = new System.Drawing.Size(813, 30);
            this.pb_Ground.TabIndex = 14;
            this.pb_Ground.TabStop = false;
            this.pb_Ground.Tag = "platform";
            // 
            // pb_platform2
            // 
            this.pb_platform2.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform2.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform2.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform2.Location = new System.Drawing.Point(102, 297);
            this.pb_platform2.Name = "pb_platform2";
            this.pb_platform2.Size = new System.Drawing.Size(200, 30);
            this.pb_platform2.TabIndex = 21;
            this.pb_platform2.TabStop = false;
            this.pb_platform2.Tag = "platform";
            // 
            // pb_platform4
            // 
            this.pb_platform4.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform4.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform4.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform4.Location = new System.Drawing.Point(161, 158);
            this.pb_platform4.Name = "pb_platform4";
            this.pb_platform4.Size = new System.Drawing.Size(200, 30);
            this.pb_platform4.TabIndex = 22;
            this.pb_platform4.TabStop = false;
            this.pb_platform4.Tag = "platform";
            // 
            // pb_platform5
            // 
            this.pb_platform5.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform5.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform5.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform5.Location = new System.Drawing.Point(316, 62);
            this.pb_platform5.Name = "pb_platform5";
            this.pb_platform5.Size = new System.Drawing.Size(200, 30);
            this.pb_platform5.TabIndex = 23;
            this.pb_platform5.TabStop = false;
            this.pb_platform5.Tag = "platform";
            // 
            // pb_platform3
            // 
            this.pb_platform3.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform3.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform3.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform3.Location = new System.Drawing.Point(485, 158);
            this.pb_platform3.Name = "pb_platform3";
            this.pb_platform3.Size = new System.Drawing.Size(200, 30);
            this.pb_platform3.TabIndex = 24;
            this.pb_platform3.TabStop = false;
            this.pb_platform3.Tag = "platform";
            // 
            // pb_platform1
            // 
            this.pb_platform1.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform1.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform1.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform1.Location = new System.Drawing.Point(565, 297);
            this.pb_platform1.Name = "pb_platform1";
            this.pb_platform1.Size = new System.Drawing.Size(200, 30);
            this.pb_platform1.TabIndex = 25;
            this.pb_platform1.TabStop = false;
            this.pb_platform1.Tag = "platform";
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::Platformer.Properties.Resources.RunningRight;
            this.pb_Player.Location = new System.Drawing.Point(200, 226);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(31, 44);
            this.pb_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Player.TabIndex = 26;
            this.pb_Player.TabStop = false;
            // 
            // tmr_movement
            // 
            this.tmr_movement.Enabled = true;
            this.tmr_movement.Interval = 20;
            this.tmr_movement.Tick += new System.EventHandler(this.tmr_movement_Tick);
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_platform1);
            this.Controls.Add(this.pb_platform3);
            this.Controls.Add(this.pb_platform5);
            this.Controls.Add(this.pb_platform4);
            this.Controls.Add(this.pb_platform2);
            this.Controls.Add(this.pb_Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_platform2;
        private System.Windows.Forms.PictureBox pb_platform4;
        private System.Windows.Forms.PictureBox pb_platform5;
        private System.Windows.Forms.PictureBox pb_platform3;
        private System.Windows.Forms.PictureBox pb_platform1;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_movement;
    }
}