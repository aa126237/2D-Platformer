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
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_platform5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.pb_Ground.TabIndex = 13;
            this.pb_Ground.TabStop = false;
            this.pb_Ground.Tag = "platform";
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::Platformer.Properties.Resources.RunningRight;
            this.pb_Player.Location = new System.Drawing.Point(413, 362);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(31, 44);
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
            this.pb_platform4.Location = new System.Drawing.Point(161, 158);
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
            this.pb_platform3.Location = new System.Drawing.Point(485, 158);
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
            this.pb_platform2.Location = new System.Drawing.Point(102, 297);
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
            this.pictureBox1.Location = new System.Drawing.Point(565, 297);
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
            this.pb_platform5.Location = new System.Drawing.Point(316, 62);
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
            this.gemLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.gemLabel.Name = "gemLabel";
            this.gemLabel.Size = new System.Drawing.Size(91, 31);
            this.gemLabel.TabIndex = 23;
            this.gemLabel.Text = "Score:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Platformer.Properties.Resources.gem;
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}