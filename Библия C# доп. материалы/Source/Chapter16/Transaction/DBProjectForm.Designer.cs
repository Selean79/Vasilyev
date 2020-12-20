namespace DBConnectionProject
{
    partial class DBProjectForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.количествоЗаписейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьИОткатитьТранзакциюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.количествоЗаписейToolStripMenuItem,
            this.вставитьИОткатитьТранзакциюToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // количествоЗаписейToolStripMenuItem
            // 
            this.количествоЗаписейToolStripMenuItem.Name = "количествоЗаписейToolStripMenuItem";
            this.количествоЗаписейToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.количествоЗаписейToolStripMenuItem.Text = "Количество записей";
            this.количествоЗаписейToolStripMenuItem.Click += new System.EventHandler(this.количествоЗаписейToolStripMenuItem_Click);
            // 
            // вставитьИОткатитьТранзакциюToolStripMenuItem
            // 
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Name = "вставитьИОткатитьТранзакциюToolStripMenuItem";
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Text = "Вставить и откатить транзакцию";
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Click += new System.EventHandler(this.вставитьИОткатитьТранзакциюToolStripMenuItem_Click);
            // 
            // DBProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 275);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DBProjectForm";
            this.Text = "Пример соединения с базой данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem количествоЗаписейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьИОткатитьТранзакциюToolStripMenuItem;
    }
}

