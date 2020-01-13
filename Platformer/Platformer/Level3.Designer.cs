namespace Platformer
{
    partial class Level3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level3));
            this.pb_Ground = new System.Windows.Forms.PictureBox();
            this.pb_platform2 = new System.Windows.Forms.PictureBox();
            this.pb_platform1 = new System.Windows.Forms.PictureBox();
            this.pb_platform4 = new System.Windows.Forms.PictureBox();
            this.pb_platform3 = new System.Windows.Forms.PictureBox();
            this.pb_platform5 = new System.Windows.Forms.PictureBox();
            this.tmr_movement = new System.Windows.Forms.Timer(this.components);
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gemLabel = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Ground
            // 
            this.pb_Ground.BackColor = System.Drawing.Color.Transparent;
            this.pb_Ground.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_Ground.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_Ground.Location = new System.Drawing.Point(-8, 434);
            this.pb_Ground.Name = "pb_Ground";
            this.pb_Ground.Size = new System.Drawing.Size(1460, 30);
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
            // pb_platform1
            // 
            this.pb_platform1.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform1.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform1.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform1.Location = new System.Drawing.Point(456, 297);
            this.pb_platform1.Name = "pb_platform1";
            this.pb_platform1.Size = new System.Drawing.Size(200, 30);
            this.pb_platform1.TabIndex = 23;
            this.pb_platform1.TabStop = false;
            this.pb_platform1.Tag = "platform";
            // 
            // pb_platform4
            // 
            this.pb_platform4.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform4.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform4.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform4.Location = new System.Drawing.Point(983, 214);
            this.pb_platform4.Name = "pb_platform4";
            this.pb_platform4.Size = new System.Drawing.Size(200, 30);
            this.pb_platform4.TabIndex = 24;
            this.pb_platform4.TabStop = false;
            this.pb_platform4.Tag = "platform";
            // 
            // pb_platform3
            // 
            this.pb_platform3.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform3.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform3.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform3.Location = new System.Drawing.Point(905, 50);
            this.pb_platform3.Name = "pb_platform3";
            this.pb_platform3.Size = new System.Drawing.Size(200, 30);
            this.pb_platform3.TabIndex = 25;
            this.pb_platform3.TabStop = false;
            this.pb_platform3.Tag = "platform";
            // 
            // pb_platform5
            // 
            this.pb_platform5.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform5.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform5.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform5.Location = new System.Drawing.Point(629, 138);
            this.pb_platform5.Name = "pb_platform5";
            this.pb_platform5.Size = new System.Drawing.Size(200, 30);
            this.pb_platform5.TabIndex = 26;
            this.pb_platform5.TabStop = false;
            this.pb_platform5.Tag = "platform";
            // 
            // tmr_movement
            // 
            this.tmr_movement.Enabled = true;
            this.tmr_movement.Interval = 20;
            this.tmr_movement.Tick += new System.EventHandler(this.tmr_movement_Tick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(549, 265);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 26);
            this.pictureBox7.TabIndex = 30;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "gem";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(1013, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(18, 26);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "gem";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(721, 106);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 26);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "gem";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Location = new System.Drawing.Point(1071, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 26);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "gem";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(194, 265);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 26);
            this.pictureBox4.TabIndex = 34;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "gem";
            // 
            // gemLabel
            // 
            this.gemLabel.AutoSize = true;
            this.gemLabel.BackColor = System.Drawing.Color.Transparent;
            this.gemLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gemLabel.Location = new System.Drawing.Point(36, 9);
            this.gemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.gemLabel.Name = "gemLabel";
            this.gemLabel.Size = new System.Drawing.Size(256, 31);
            this.gemLabel.TabIndex = 35;
            this.gemLabel.Text = "Collect 5 more gems";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Platformer.Properties.Resources.gem;
            this.pictureBox5.Location = new System.Drawing.Point(9, 9);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 31);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // pb_settings
            // 
            this.pb_settings.BackColor = System.Drawing.Color.Transparent;
            this.pb_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_settings.Image = global::Platformer.Properties.Resources.cog_gear_monotone_settings_icon;
            this.pb_settings.Location = new System.Drawing.Point(1122, 12);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(50, 50);
            this.pb_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_settings.TabIndex = 37;
            this.pb_settings.TabStop = false;
            this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::Platformer.Properties.Resources.RunningRight;
            this.pb_Player.Location = new System.Drawing.Point(194, 375);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(30, 45);
            this.pb_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Player.TabIndex = 27;
            this.pb_Player.TabStop = false;
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.gemLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_platform5);
            this.Controls.Add(this.pb_platform3);
            this.Controls.Add(this.pb_platform4);
            this.Controls.Add(this.pb_platform1);
            this.Controls.Add(this.pb_platform2);
            this.Controls.Add(this.pb_Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_platform2;
        private System.Windows.Forms.PictureBox pb_platform1;
        private System.Windows.Forms.PictureBox pb_platform4;
        private System.Windows.Forms.PictureBox pb_platform3;
        private System.Windows.Forms.PictureBox pb_platform5;
        private System.Windows.Forms.Timer tmr_movement;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label gemLabel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.PictureBox pb_Player;
    }
}