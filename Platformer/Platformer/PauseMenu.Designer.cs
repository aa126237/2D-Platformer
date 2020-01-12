namespace Platformer
{
    partial class PauseMenu
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
            this.btn_continue = new System.Windows.Forms.Button();
            this.btn_levelSelect = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_continue.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_continue.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_continue.Location = new System.Drawing.Point(280, 108);
            this.btn_continue.Margin = new System.Windows.Forms.Padding(0);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(270, 55);
            this.btn_continue.TabIndex = 9;
            this.btn_continue.Text = "Continue";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // btn_levelSelect
            // 
            this.btn_levelSelect.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_levelSelect.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_levelSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_levelSelect.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_levelSelect.Location = new System.Drawing.Point(280, 176);
            this.btn_levelSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btn_levelSelect.Name = "btn_levelSelect";
            this.btn_levelSelect.Size = new System.Drawing.Size(270, 55);
            this.btn_levelSelect.TabIndex = 10;
            this.btn_levelSelect.Text = "Level Select";
            this.btn_levelSelect.UseVisualStyleBackColor = false;
            this.btn_levelSelect.Click += new System.EventHandler(this.btn_levelSelect_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_menu.BackgroundImage = global::Platformer.Properties.Resources.Grass;
            this.btn_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_menu.Font = new System.Drawing.Font("Showcard Gothic", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.Location = new System.Drawing.Point(280, 243);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(270, 55);
            this.btn_menu.TabIndex = 11;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // PauseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Platformer.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.btn_menu);
            this.Controls.Add(this.btn_levelSelect);
            this.Controls.Add(this.btn_continue);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PauseMenu";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pause Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_continue;
        private System.Windows.Forms.Button btn_levelSelect;
        private System.Windows.Forms.Button btn_menu;
    }
}