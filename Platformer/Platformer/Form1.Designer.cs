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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmr_Right = new System.Windows.Forms.Timer(this.components);
            this.tmr_Left = new System.Windows.Forms.Timer(this.components);
            this.tmr_Up = new System.Windows.Forms.Timer(this.components);
            this.tmr_Gravity = new System.Windows.Forms.Timer(this.components);
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).BeginInit();
            this.SuspendLayout();
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
            // tmr_Up
            // 
            this.tmr_Up.Interval = 10;
            this.tmr_Up.Tick += new System.EventHandler(this.tmr_Up_Tick);
            // 
            // tmr_Gravity
            // 
            this.tmr_Gravity.Enabled = true;
            this.tmr_Gravity.Interval = 10;
            this.tmr_Gravity.Tick += new System.EventHandler(this.tmr_Gravity_Tick);
            // 
            // pb_Player
            // 
            this.pb_Player.BackColor = System.Drawing.Color.Transparent;
            this.pb_Player.Image = ((System.Drawing.Image)(resources.GetObject("pb_Player.Image")));
            this.pb_Player.Location = new System.Drawing.Point(159, 306);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(26, 23);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Ground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Ground;
        private System.Windows.Forms.PictureBox pb_Player;
        private System.Windows.Forms.Timer tmr_Right;
        private System.Windows.Forms.Timer tmr_Left;
        private System.Windows.Forms.Timer tmr_Up;
        private System.Windows.Forms.Timer tmr_Gravity;
    }
}

