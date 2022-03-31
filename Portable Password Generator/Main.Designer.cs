namespace Portable_Password_Generator
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordLengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.characterPoolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersNumbersSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWithWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lettersToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowerUpperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Portable Password Generator";
            this.trayIcon.Visible = true;
            // 
            // trayMenuStrip
            // 
            this.trayMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.trayMenuStrip.Name = "trayMenuStrip";
            this.trayMenuStrip.Size = new System.Drawing.Size(181, 92);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            this.generateToolStripMenuItem.Click += new System.EventHandler(this.generateToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordLengthToolStripMenuItem,
            this.characterPoolToolStripMenuItem,
            this.lettersToolStripMenuItem1,
            this.startWithWindowsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // passwordLengthToolStripMenuItem
            // 
            this.passwordLengthToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.passwordLengthToolStripMenuItem.Name = "passwordLengthToolStripMenuItem";
            this.passwordLengthToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.passwordLengthToolStripMenuItem.Text = "Password Length";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Checked = true;
            this.toolStripMenuItem7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem7.Text = "6";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem8.Text = "7";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem9.Text = "8";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem10.Text = "9";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem11.Text = "10";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem12.Text = "11";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem13.Text = "12";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem14.Text = "13";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem15.Text = "14";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem16.Text = "15";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItem17.Text = "16";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.changePasswordLength);
            // 
            // characterPoolToolStripMenuItem
            // 
            this.characterPoolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lettersToolStripMenuItem,
            this.lettersNumbersToolStripMenuItem,
            this.lettersSpecialToolStripMenuItem,
            this.lettersNumbersSpecialToolStripMenuItem});
            this.characterPoolToolStripMenuItem.Name = "characterPoolToolStripMenuItem";
            this.characterPoolToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.characterPoolToolStripMenuItem.Text = "Character Pool";
            // 
            // lettersToolStripMenuItem
            // 
            this.lettersToolStripMenuItem.Name = "lettersToolStripMenuItem";
            this.lettersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.lettersToolStripMenuItem.Text = "Letters";
            this.lettersToolStripMenuItem.Click += new System.EventHandler(this.changeCharacterPool);
            // 
            // lettersNumbersToolStripMenuItem
            // 
            this.lettersNumbersToolStripMenuItem.Name = "lettersNumbersToolStripMenuItem";
            this.lettersNumbersToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.lettersNumbersToolStripMenuItem.Text = "Letters, Numbers";
            this.lettersNumbersToolStripMenuItem.Click += new System.EventHandler(this.changeCharacterPool);
            // 
            // lettersSpecialToolStripMenuItem
            // 
            this.lettersSpecialToolStripMenuItem.Name = "lettersSpecialToolStripMenuItem";
            this.lettersSpecialToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.lettersSpecialToolStripMenuItem.Text = "Letters, Special";
            this.lettersSpecialToolStripMenuItem.Click += new System.EventHandler(this.changeCharacterPool);
            // 
            // lettersNumbersSpecialToolStripMenuItem
            // 
            this.lettersNumbersSpecialToolStripMenuItem.Checked = true;
            this.lettersNumbersSpecialToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lettersNumbersSpecialToolStripMenuItem.Name = "lettersNumbersSpecialToolStripMenuItem";
            this.lettersNumbersSpecialToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.lettersNumbersSpecialToolStripMenuItem.Text = "Letters, Numbers, Special";
            this.lettersNumbersSpecialToolStripMenuItem.Click += new System.EventHandler(this.changeCharacterPool);
            // 
            // startWithWindowsToolStripMenuItem
            // 
            this.startWithWindowsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yesToolStripMenuItem,
            this.noToolStripMenuItem});
            this.startWithWindowsToolStripMenuItem.Name = "startWithWindowsToolStripMenuItem";
            this.startWithWindowsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startWithWindowsToolStripMenuItem.Text = "Start With Windows";
            // 
            // yesToolStripMenuItem
            // 
            this.yesToolStripMenuItem.Name = "yesToolStripMenuItem";
            this.yesToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.yesToolStripMenuItem.Text = "Yes";
            this.yesToolStripMenuItem.Click += new System.EventHandler(this.changeStartWithWindows);
            // 
            // noToolStripMenuItem
            // 
            this.noToolStripMenuItem.Checked = true;
            this.noToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noToolStripMenuItem.Name = "noToolStripMenuItem";
            this.noToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.noToolStripMenuItem.Text = "No";
            this.noToolStripMenuItem.Click += new System.EventHandler(this.changeStartWithWindows);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lettersToolStripMenuItem1
            // 
            this.lettersToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowerToolStripMenuItem,
            this.upperToolStripMenuItem,
            this.lowerUpperToolStripMenuItem});
            this.lettersToolStripMenuItem1.Name = "lettersToolStripMenuItem1";
            this.lettersToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lettersToolStripMenuItem1.Text = "Letters";
            // 
            // lowerToolStripMenuItem
            // 
            this.lowerToolStripMenuItem.Name = "lowerToolStripMenuItem";
            this.lowerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lowerToolStripMenuItem.Text = "Lower";
            this.lowerToolStripMenuItem.Click += new System.EventHandler(this.changeLetters);
            // 
            // upperToolStripMenuItem
            // 
            this.upperToolStripMenuItem.Name = "upperToolStripMenuItem";
            this.upperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upperToolStripMenuItem.Text = "Upper";
            this.upperToolStripMenuItem.Click += new System.EventHandler(this.changeLetters);
            // 
            // lowerUpperToolStripMenuItem
            // 
            this.lowerUpperToolStripMenuItem.Checked = true;
            this.lowerUpperToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerUpperToolStripMenuItem.Name = "lowerUpperToolStripMenuItem";
            this.lowerUpperToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lowerUpperToolStripMenuItem.Text = "Lower, Upper";
            this.lowerUpperToolStripMenuItem.Click += new System.EventHandler(this.changeLetters);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(301, 42);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Portable Password Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.trayMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordLengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem characterPoolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettersNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettersSpecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettersNumbersSpecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startWithWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lettersToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowerUpperToolStripMenuItem;
    }
}

