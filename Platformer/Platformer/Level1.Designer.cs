namespace Platformer
{
    partial class Level1
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
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.tmr_movement = new System.Windows.Forms.Timer(this.components);
            this.pb_platform4 = new System.Windows.Forms.PictureBox();
            this.pb_platform3 = new System.Windows.Forms.PictureBox();
            this.pb_platform2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_platform5 = new System.Windows.Forms.PictureBox();
            this.gemLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
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
            this.pb_Ground.TabIndex = 13;
            this.pb_Ground.TabStop = false;
            this.pb_Ground.Tag = "platform";
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::Platformer.Properties.Resources.RunningRight;
            this.pb_Player.Location = new System.Drawing.Point(585, 375);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(30, 45);
            this.pb_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Player.TabIndex = 16;
            this.pb_Player.TabStop = false;
            // 
            // tmr_movement
            // 
            this.tmr_movement.Enabled = true;
            this.tmr_movement.Interval = 20;
            this.tmr_movement.Tick += new System.EventHandler(this.tmr_movement_Tick);
            // 
            // pb_platform4
            // 
            this.pb_platform4.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform4.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform4.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform4.Location = new System.Drawing.Point(144, 284);
            this.pb_platform4.Name = "pb_platform4";
            this.pb_platform4.Size = new System.Drawing.Size(200, 30);
            this.pb_platform4.TabIndex = 18;
            this.pb_platform4.TabStop = false;
            this.pb_platform4.Tag = "platform";
            // 
            // pb_platform3
            // 
            this.pb_platform3.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform3.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform3.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform3.Location = new System.Drawing.Point(841, 284);
            this.pb_platform3.Name = "pb_platform3";
            this.pb_platform3.Size = new System.Drawing.Size(200, 30);
            this.pb_platform3.TabIndex = 19;
            this.pb_platform3.TabStop = false;
            this.pb_platform3.Tag = "platform";
            // 
            // pb_platform2
            // 
            this.pb_platform2.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform2.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform2.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform2.Location = new System.Drawing.Point(20, 375);
            this.pb_platform2.Name = "pb_platform2";
            this.pb_platform2.Size = new System.Drawing.Size(200, 30);
            this.pb_platform2.TabIndex = 20;
            this.pb_platform2.TabStop = false;
            this.pb_platform2.Tag = "platform";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pictureBox1.Image = global::Platformer.Properties.Resources.Grass;
            this.pictureBox1.Location = new System.Drawing.Point(972, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 30);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "platform";
            // 
            // pb_platform5
            // 
            this.pb_platform5.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform5.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform5.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform5.Location = new System.Drawing.Point(269, 190);
            this.pb_platform5.Name = "pb_platform5";
            this.pb_platform5.Size = new System.Drawing.Size(200, 30);
            this.pb_platform5.TabIndex = 21;
            this.pb_platform5.TabStop = false;
            this.pb_platform5.Tag = "platform";
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
            this.gemLabel.TabIndex = 23;
            this.gemLabel.Text = "Collect 9 more gems";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Platformer.Properties.Resources.gem;
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox3.Location = new System.Drawing.Point(803, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 26);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "gem";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox4.Location = new System.Drawing.Point(233, 252);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(18, 26);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "gem";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox5.Location = new System.Drawing.Point(585, 66);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 26);
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "gem";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox6.Location = new System.Drawing.Point(109, 343);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(18, 26);
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "gem";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(360, 158);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(18, 26);
            this.pictureBox7.TabIndex = 29;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "gem";
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
            this.pb_settings.TabIndex = 30;
            this.pb_settings.TabStop = false;
            this.pb_settings.Click += new System.EventHandler(this.pb_settings_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pictureBox8.Image = global::Platformer.Properties.Resources.Grass;
            this.pictureBox8.Location = new System.Drawing.Point(233, 56);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(200, 30);
            this.pictureBox8.TabIndex = 31;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "platform";
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pictureBox9.Image = global::Platformer.Properties.Resources.Grass;
            this.pictureBox9.Location = new System.Drawing.Point(718, 190);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(200, 30);
            this.pictureBox9.TabIndex = 32;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "platform";
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pictureBox10.Image = global::Platformer.Properties.Resources.Grass;
            this.pictureBox10.Location = new System.Drawing.Point(492, 98);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(200, 30);
            this.pictureBox10.TabIndex = 33;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "platform";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pictureBox11.Image = global::Platformer.Properties.Resources.Grass;
            this.pictureBox11.Location = new System.Drawing.Point(753, 56);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(200, 30);
            this.pictureBox11.TabIndex = 34;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "platform";
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox12.Location = new System.Drawing.Point(326, 24);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(18, 26);
            this.pictureBox12.TabIndex = 35;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "gem";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox13.Location = new System.Drawing.Point(841, 24);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(18, 26);
            this.pictureBox13.TabIndex = 36;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "gem";
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox14.Location = new System.Drawing.Point(1065, 343);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(18, 26);
            this.pictureBox14.TabIndex = 37;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "gem";
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox15.Location = new System.Drawing.Point(935, 252);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(18, 26);
            this.pictureBox15.TabIndex = 38;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "gem";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gemLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_platform5);
            this.Controls.Add(this.pb_platform2);
            this.Controls.Add(this.pb_platform3);
            this.Controls.Add(this.pb_platform4);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_movement;
        private System.Windows.Forms.PictureBox pb_platform4;
        private System.Windows.Forms.PictureBox pb_platform3;
        private System.Windows.Forms.PictureBox pb_platform2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_platform5;
        private System.Windows.Forms.Label gemLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
    }
}