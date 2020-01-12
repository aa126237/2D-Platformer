namespace Platformer
{
    partial class LevelSelect
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
            this.btn_level1 = new System.Windows.Forms.Button();
            this.btn_level2 = new System.Windows.Forms.Button();
            this.btn_level3 = new System.Windows.Forms.Button();
            this.btn_level4 = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_level1
            // 
            this.btn_level1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_level1.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_level1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_level1.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level1.Location = new System.Drawing.Point(280, 108);
            this.btn_level1.Margin = new System.Windows.Forms.Padding(0);
            this.btn_level1.Name = "btn_level1";
            this.btn_level1.Size = new System.Drawing.Size(232, 53);
            this.btn_level1.TabIndex = 9;
            this.btn_level1.Text = "Level 1";
            this.btn_level1.UseVisualStyleBackColor = false;
            this.btn_level1.Click += new System.EventHandler(this.btn_level1_Click);
            // 
            // btn_level2
            // 
            this.btn_level2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_level2.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_level2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_level2.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level2.Location = new System.Drawing.Point(280, 171);
            this.btn_level2.Margin = new System.Windows.Forms.Padding(0);
            this.btn_level2.Name = "btn_level2";
            this.btn_level2.Size = new System.Drawing.Size(232, 53);
            this.btn_level2.TabIndex = 10;
            this.btn_level2.Text = "Level 2";
            this.btn_level2.UseVisualStyleBackColor = false;
            this.btn_level2.Click += new System.EventHandler(this.btn_level2_Click);
            // 
            // btn_level3
            // 
            this.btn_level3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_level3.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_level3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_level3.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level3.Location = new System.Drawing.Point(280, 230);
            this.btn_level3.Margin = new System.Windows.Forms.Padding(0);
            this.btn_level3.Name = "btn_level3";
            this.btn_level3.Size = new System.Drawing.Size(232, 53);
            this.btn_level3.TabIndex = 11;
            this.btn_level3.Text = "Level 3";
            this.btn_level3.UseVisualStyleBackColor = false;
            this.btn_level3.Click += new System.EventHandler(this.btn_level3_Click);
            // 
            // btn_level4
            // 
            this.btn_level4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_level4.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_level4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_level4.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_level4.Location = new System.Drawing.Point(280, 292);
            this.btn_level4.Margin = new System.Windows.Forms.Padding(0);
            this.btn_level4.Name = "btn_level4";
            this.btn_level4.Size = new System.Drawing.Size(232, 53);
            this.btn_level4.TabIndex = 12;
            this.btn_level4.Text = "Level 4";
            this.btn_level4.UseVisualStyleBackColor = false;
            this.btn_level4.Click += new System.EventHandler(this.btn_level4_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_menu.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(261, 31);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(270, 55);
            this.btn_menu.TabIndex = 13;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // LevelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_level4);
            this.Controls.Add(this.btn_level3);
            this.Controls.Add(this.btn_level2);
            this.Controls.Add(this.btn_level1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LevelSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level Select";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_level1;
        private System.Windows.Forms.Button btn_level2;
        private System.Windows.Forms.Button btn_level3;
        private System.Windows.Forms.Button btn_level4;
        private System.Windows.Forms.Button btn_menu;
    }
}