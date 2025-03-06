namespace GridSagaPrototype
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
            this.playBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shopBtn = new System.Windows.Forms.Button();
            this.homeExitBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.achievementBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.AutoSize = true;
            this.playBtn.Location = new System.Drawing.Point(345, 98);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(111, 69);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Play Game";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grid Saga";
            // 
            // shopBtn
            // 
            this.shopBtn.AutoSize = true;
            this.shopBtn.Location = new System.Drawing.Point(345, 222);
            this.shopBtn.Name = "shopBtn";
            this.shopBtn.Size = new System.Drawing.Size(111, 69);
            this.shopBtn.TabIndex = 2;
            this.shopBtn.Text = "Open Shop";
            this.shopBtn.UseVisualStyleBackColor = true;
            this.shopBtn.Click += new System.EventHandler(this.shopBtn_Click);
            // 
            // homeExitBtn
            // 
            this.homeExitBtn.AutoSize = true;
            this.homeExitBtn.Location = new System.Drawing.Point(345, 346);
            this.homeExitBtn.Name = "homeExitBtn";
            this.homeExitBtn.Size = new System.Drawing.Size(111, 69);
            this.homeExitBtn.TabIndex = 3;
            this.homeExitBtn.Text = "Exit";
            this.homeExitBtn.UseVisualStyleBackColor = true;
            this.homeExitBtn.Click += new System.EventHandler(this.homeExitBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.AutoSize = true;
            this.settingsBtn.BackgroundImage = global::GridSagaPrototype.Properties.Resources.Settings_Button;
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.Location = new System.Drawing.Point(751, 0);
            this.settingsBtn.MaximumSize = new System.Drawing.Size(100, 100);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(50, 50);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // achievementBtn
            // 
            this.achievementBtn.AutoSize = true;
            this.achievementBtn.BackgroundImage = global::GridSagaPrototype.Properties.Resources.Achievenment_Button;
            this.achievementBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.achievementBtn.Location = new System.Drawing.Point(-1, 0);
            this.achievementBtn.Name = "achievementBtn";
            this.achievementBtn.Size = new System.Drawing.Size(50, 50);
            this.achievementBtn.TabIndex = 4;
            this.achievementBtn.UseVisualStyleBackColor = true;
            this.achievementBtn.Click += new System.EventHandler(this.achievementBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.settingsBtn);
            this.Controls.Add(this.achievementBtn);
            this.Controls.Add(this.homeExitBtn);
            this.Controls.Add(this.shopBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shopBtn;
        private System.Windows.Forms.Button homeExitBtn;
        private System.Windows.Forms.Button achievementBtn;
        private System.Windows.Forms.Button settingsBtn;
    }
}

