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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.pb_Ground = new System.Windows.Forms.PictureBox();
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.tmr_movement = new System.Windows.Forms.Timer(this.components);
            this.pb_platform2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_platform5 = new System.Windows.Forms.PictureBox();
            this.gemLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
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
            // pb_platform2
            // 
            this.pb_platform2.BackColor = System.Drawing.Color.Transparent;
            this.pb_platform2.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_platform2.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_platform2.Location = new System.Drawing.Point(269, 375);
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
            this.pictureBox1.Location = new System.Drawing.Point(718, 375);
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
            this.pb_platform5.Location = new System.Drawing.Point(501, 235);
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
            this.gemLabel.Text = "Collect 3 more gems";
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
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox6.Location = new System.Drawing.Point(358, 343);
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
            this.pictureBox7.Location = new System.Drawing.Point(592, 203);
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
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImage = global::Platformer.Properties.Resources.gem;
            this.pictureBox14.Location = new System.Drawing.Point(811, 343);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(18, 26);
            this.pictureBox14.TabIndex = 37;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "gem";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pb_settings);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gemLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_platform5);
            this.Controls.Add(this.pb_platform2);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Ground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_movement;
        private System.Windows.Forms.PictureBox pb_platform2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pb_platform5;
        private System.Windows.Forms.Label gemLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pb_settings;
        private System.Windows.Forms.PictureBox pictureBox14;
    }
}