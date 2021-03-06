﻿namespace Desktop
{
    partial class RedesignedMainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.valueLabel = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.HeadLabel = new System.Windows.Forms.Label();
            this.ShareButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NavigationLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.settingsUC2 = new Desktop.SettingsUC();
            this.settingsUC1 = new Desktop.SettingsUC();
            this.userUC1 = new Desktop.UserUC();
            this.homeUC1 = new Desktop.HomeUC();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.valueLabel);
            this.panel1.Controls.Add(this.circularProgressBar1);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.HeadLabel);
            this.panel1.Controls.Add(this.SettingsButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ShareButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.UserButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 409);
            this.panel1.TabIndex = 0;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.valueLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.valueLabel.Location = new System.Drawing.Point(49, 166);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(32, 16);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "40%";
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 28;
            this.circularProgressBar1.InnerWidth = 15;
            this.circularProgressBar1.Location = new System.Drawing.Point(28, 96);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Firebrick;
            this.circularProgressBar1.ProgressWidth = 30;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(70, 70);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 6;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 40;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Firebrick;
            this.SidePanel.Location = new System.Drawing.Point(0, 182);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(7, 40);
            this.SidePanel.TabIndex = 2;
            // 
            // HeadLabel
            // 
            this.HeadLabel.AutoSize = true;
            this.HeadLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeadLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HeadLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.HeadLabel.Location = new System.Drawing.Point(26, 70);
            this.HeadLabel.Name = "HeadLabel";
            this.HeadLabel.Size = new System.Drawing.Size(75, 23);
            this.HeadLabel.TabIndex = 3;
            this.HeadLabel.Text = "DroBox";
            // 
            // ShareButton
            // 
            this.ShareButton.FlatAppearance.BorderSize = 0;
            this.ShareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShareButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ShareButton.ForeColor = System.Drawing.Color.White;
            this.ShareButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShareButton.Location = new System.Drawing.Point(6, 320);
            this.ShareButton.Name = "ShareButton";
            this.ShareButton.Size = new System.Drawing.Size(123, 40);
            this.ShareButton.TabIndex = 6;
            this.ShareButton.Text = "   Unknown";
            this.ShareButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShareButton.UseVisualStyleBackColor = true;
            this.ShareButton.Click += new System.EventHandler(this.ShareButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.Location = new System.Drawing.Point(6, 274);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(123, 40);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "   Unknown";
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.MinimizeButton);
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.NavigationLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(128, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 27);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // NavigationLabel
            // 
            this.NavigationLabel.AutoSize = true;
            this.NavigationLabel.BackColor = System.Drawing.Color.Transparent;
            this.NavigationLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.NavigationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.NavigationLabel.Location = new System.Drawing.Point(1, 1);
            this.NavigationLabel.Name = "NavigationLabel";
            this.NavigationLabel.Size = new System.Drawing.Size(65, 23);
            this.NavigationLabel.TabIndex = 8;
            this.NavigationLabel.Text = "Home";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.settingsUC2);
            this.panel3.Controls.Add(this.settingsUC1);
            this.panel3.Controls.Add(this.userUC1);
            this.panel3.Controls.Add(this.homeUC1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(128, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 382);
            this.panel3.TabIndex = 2;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.Image = global::Desktop.Properties.Resources.sutrauk;
            this.MinimizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MinimizeButton.Location = new System.Drawing.Point(688, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(24, 21);
            this.MinimizeButton.TabIndex = 9;
            this.MinimizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Image = global::Desktop.Properties.Resources.isjungti;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(710, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 21);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.BackgroundImage = global::Desktop.Properties.Resources.ikona;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(36, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // SettingsButton
            // 
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.Image = global::Desktop.Properties.Resources.nustatymai;
            this.SettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsButton.Location = new System.Drawing.Point(6, 366);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(123, 40);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "   Settings";
            this.SettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Desktop.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(31, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // UserButton
            // 
            this.UserButton.FlatAppearance.BorderSize = 0;
            this.UserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.UserButton.ForeColor = System.Drawing.Color.White;
            this.UserButton.Image = global::Desktop.Properties.Resources.vartotojasjuodas;
            this.UserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserButton.Location = new System.Drawing.Point(6, 228);
            this.UserButton.Name = "UserButton";
            this.UserButton.Size = new System.Drawing.Size(123, 40);
            this.UserButton.TabIndex = 4;
            this.UserButton.Text = "   User";
            this.UserButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UserButton.UseVisualStyleBackColor = true;
            this.UserButton.Click += new System.EventHandler(this.UserButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::Desktop.Properties.Resources.namuksJuodas;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(6, 182);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(123, 40);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "   Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // settingsUC2
            // 
            this.settingsUC2.Location = new System.Drawing.Point(0, 0);
            this.settingsUC2.Name = "settingsUC2";
            this.settingsUC2.Size = new System.Drawing.Size(737, 382);
            this.settingsUC2.TabIndex = 5;
            // 
            // settingsUC1
            // 
            this.settingsUC1.Location = new System.Drawing.Point(157, -297);
            this.settingsUC1.Name = "settingsUC1";
            this.settingsUC1.Size = new System.Drawing.Size(737, 382);
            this.settingsUC1.TabIndex = 4;
            // 
            // userUC1
            // 
            this.userUC1.Location = new System.Drawing.Point(0, 0);
            this.userUC1.Name = "userUC1";
            this.userUC1.Size = new System.Drawing.Size(737, 382);
            this.userUC1.TabIndex = 1;
            // 
            // homeUC1
            // 
            this.homeUC1.AllowDrop = true;
            this.homeUC1.Location = new System.Drawing.Point(0, 0);
            this.homeUC1.Name = "homeUC1";
            this.homeUC1.Size = new System.Drawing.Size(737, 382);
            this.homeUC1.TabIndex = 0;
            // 
            // RedesignedMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 409);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RedesignedMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedesignedMainPage";
            this.Resize += new System.EventHandler(this.RedesignedMainPage_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label HeadLabel;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button UserButton;
        private System.Windows.Forms.Button ShareButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label NavigationLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel panel3;
        private UserUC userUC1;
        private HomeUC homeUC1;
        private SettingsUC settingsUC1;
        private SettingsUC settingsUC2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}