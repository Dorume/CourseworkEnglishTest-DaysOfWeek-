﻿namespace Lets__study_.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpManualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ServiceToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "&Файл";
            // 
            // ServiceToolStripMenuItem
            // 
            this.ServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem";
            this.ServiceToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.ServiceToolStripMenuItem.Text = "&Сервіс";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Image = global::Lets__study_.Properties.Resources.SettingsBtn;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingsToolStripMenuItem.Text = "&Налаштування";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpManualToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.HelpToolStripMenuItem.Text = "&Довідка";
            // 
            // HelpManualToolStripMenuItem
            // 
            this.HelpManualToolStripMenuItem.Image = global::Lets__study_.Properties.Resources.HelpBtn;
            this.HelpManualToolStripMenuItem.Name = "HelpManualToolStripMenuItem";
            this.HelpManualToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpManualToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.HelpManualToolStripMenuItem.Text = "&Посібник";
            this.HelpManualToolStripMenuItem.Click += new System.EventHandler(this.HelpManualToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Image = global::Lets__study_.Properties.Resources.StartBtn;
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.StartToolStripMenuItem.Text = "Почати тестування";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::Lets__study_.Properties.Resources.ExitBtn;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ExitToolStripMenuItem.Text = "Ви&хід";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Let\'s study!";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Icon = Properties.Resources.MainFormIcon;

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpManualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

