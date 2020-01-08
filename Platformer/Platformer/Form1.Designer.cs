namespace Platformer
{
    partial class Form1
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
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Ground = new System.Windows.Forms.PictureBox();
            this.tmr_Gravity = new System.Windows.Forms.Timer(this.components);
            this.tmr_Up = new System.Windows.Forms.Timer(this.components);
            this.tmr_Right = new System.Windows.Forms.Timer(this.components);
            this.tmr_Left = new System.Windows.Forms.Timer(this.components);
            this.pb_rightWall = new System.Windows.Forms.PictureBox();
            this.pb_leftWall = new System.Windows.Forms.PictureBox();
            this.TestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftWall)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = global::Platformer.Properties.Resources.RunningRight;
            this.pb_Player.Location = new System.Drawing.Point(179, 167);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(31, 44);
            this.pb_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Player.TabIndex = 1;
            this.pb_Player.TabStop = false;
            // 
            // pb_Ground
            // 
            this.pb_Ground.BackColor = System.Drawing.Color.Transparent;
            this.pb_Ground.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.pb_Ground.Image = global::Platformer.Properties.Resources.Grass;
            this.pb_Ground.Location = new System.Drawing.Point(-6, 425);
            this.pb_Ground.Name = "pb_Ground";
            this.pb_Ground.Size = new System.Drawing.Size(813, 30);
            this.pb_Ground.TabIndex = 0;
            this.pb_Ground.TabStop = false;
            // 
            // tmr_Gravity
            // 
            this.tmr_Gravity.Enabled = true;
            this.tmr_Gravity.Interval = 10;
            this.tmr_Gravity.Tick += new System.EventHandler(this.tmr_Gravity_Tick);
            // 
            // tmr_Up
            // 
            this.tmr_Up.Interval = 10;
            this.tmr_Up.Tick += new System.EventHandler(this.tmr_Up_Tick);
            // 
            // tmr_Right
            // 
            this.tmr_Right.Interval = 10;
            this.tmr_Right.Tick += new System.EventHandler(this.tmr_Right_Tick);
            // 
            // tmr_Left
            // 
            this.tmr_Left.Interval = 10;
            this.tmr_Left.Tick += new System.EventHandler(this.tmr_Left_Tick);
            // 
            // pb_rightWall
            // 
            this.pb_rightWall.BackColor = System.Drawing.Color.Transparent;
            this.pb_rightWall.Location = new System.Drawing.Point(787, -33);
            this.pb_rightWall.Name = "pb_rightWall";
            this.pb_rightWall.Size = new System.Drawing.Size(32, 452);
            this.pb_rightWall.TabIndex = 2;
            this.pb_rightWall.TabStop = false;
            // 
            // pb_leftWall
            // 
            this.pb_leftWall.BackColor = System.Drawing.Color.Transparent;
            this.pb_leftWall.Location = new System.Drawing.Point(-6, -24);
            this.pb_leftWall.Name = "pb_leftWall";
            this.pb_leftWall.Size = new System.Drawing.Size(14, 443);
            this.pb_leftWall.TabIndex = 3;
            this.pb_leftWall.TabStop = false;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(450, 61);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 4;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.pb_leftWall);
            this.Controls.Add(this.pb_rightWall);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Ground);
            this.Name = "Form1";
            this.Text = "Level 1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rightWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_leftWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_Gravity;
        private System.Windows.Forms.Timer tmr_Up;
        private System.Windows.Forms.Timer tmr_Right;
        private System.Windows.Forms.Timer tmr_Left;
        private System.Windows.Forms.PictureBox pb_rightWall;
        private System.Windows.Forms.PictureBox pb_leftWall;
        private System.Windows.Forms.Button TestButton;
    }
}

