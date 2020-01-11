namespace Platformer
{
    partial class Menu
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
            this.btn_startGame = new System.Windows.Forms.Button();
            this.btn_Options = new System.Windows.Forms.Button();
            this.btn_exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startGame
            // 
            this.btn_startGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_startGame.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_startGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_startGame.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startGame.Location = new System.Drawing.Point(280, 108);
            this.btn_startGame.Margin = new System.Windows.Forms.Padding(0);
            this.btn_startGame.Name = "btn_startGame";
            this.btn_startGame.Size = new System.Drawing.Size(232, 53);
            this.btn_startGame.TabIndex = 8;
            this.btn_startGame.Text = "Start";
            this.btn_startGame.UseVisualStyleBackColor = false;
            this.btn_startGame.Click += new System.EventHandler(this.btn_startGame_Click);
            // 
            // btn_Options
            // 
            this.btn_Options.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Options.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_Options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Options.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Options.Location = new System.Drawing.Point(280, 171);
            this.btn_Options.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(232, 53);
            this.btn_Options.TabIndex = 9;
            this.btn_Options.Text = "Options";
            this.btn_Options.UseVisualStyleBackColor = false;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // btn_exitGame
            // 
            this.btn_exitGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exitGame.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_exitGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exitGame.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitGame.Location = new System.Drawing.Point(280, 230);
            this.btn_exitGame.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exitGame.Name = "btn_exitGame";
            this.btn_exitGame.Size = new System.Drawing.Size(232, 53);
            this.btn_exitGame.TabIndex = 10;
            this.btn_exitGame.Text = "Exit Game";
            this.btn_exitGame.UseVisualStyleBackColor = false;
            this.btn_exitGame.Click += new System.EventHandler(this.btn_exitGame_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exitGame);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.btn_startGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_startGame;
        private System.Windows.Forms.Button btn_Options;
        private System.Windows.Forms.Button btn_exitGame;
    }
}

