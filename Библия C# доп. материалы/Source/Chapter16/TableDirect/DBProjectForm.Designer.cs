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
            this.выполнениеФункцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выполнениеФункцииКакЗапросаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.surnameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.nameColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.birthdayСolumnHeader = new System.Windows.Forms.ColumnHeader();
            this.sexColumnHeader = new System.Windows.Forms.ColumnHeader();
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
            this.вставитьИОткатитьТранзакциюToolStripMenuItem,
            this.выполнениеФункцииToolStripMenuItem,
            this.выполнениеФункцииКакЗапросаToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // количествоЗаписейToolStripMenuItem
            // 
            this.количествоЗаписейToolStripMenuItem.Name = "количествоЗаписейToolStripMenuItem";
            this.количествоЗаписейToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.количествоЗаписейToolStripMenuItem.Text = "Количество записей";
            this.количествоЗаписейToolStripMenuItem.Click += new System.EventHandler(this.количествоЗаписейToolStripMenuItem_Click);
            // 
            // вставитьИОткатитьТранзакциюToolStripMenuItem
            // 
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Name = "вставитьИОткатитьТранзакциюToolStripMenuItem";
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Text = "Вставить и откатить транзакцию";
            this.вставитьИОткатитьТранзакциюToolStripMenuItem.Click += new System.EventHandler(this.вставитьИОткатитьТранзакциюToolStripMenuItem_Click);
            // 
            // выполнениеФункцииToolStripMenuItem
            // 
            this.выполнениеФункцииToolStripMenuItem.Name = "выполнениеФункцииToolStripMenuItem";
            this.выполнениеФункцииToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.выполнениеФункцииToolStripMenuItem.Text = "Выполнение функции";
            this.выполнениеФункцииToolStripMenuItem.Click += new System.EventHandler(this.выполнениеФункцииToolStripMenuItem_Click);
            // 
            // выполнениеФункцииКакЗапросаToolStripMenuItem
            // 
            this.выполнениеФункцииКакЗапросаToolStripMenuItem.Name = "выполнениеФункцииКакЗапросаToolStripMenuItem";
            this.выполнениеФункцииКакЗапросаToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.выполнениеФункцииКакЗапросаToolStripMenuItem.Text = "Выполнение функции как запроса";
            this.выполнениеФункцииКакЗапросаToolStripMenuItem.Click += new System.EventHandler(this.выполнениеФункцииКакЗапросаToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.surnameColumnHeader,
            this.nameColumnHeader,
            this.birthdayСolumnHeader,
            this.sexColumnHeader});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(458, 251);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // surnameColumnHeader
            // 
            this.surnameColumnHeader.Text = "Фамилия";
            this.surnameColumnHeader.Width = 140;
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Имя";
            this.nameColumnHeader.Width = 140;
            // 
            // birthdayСolumnHeader
            // 
            this.birthdayСolumnHeader.Text = "День рождения";
            this.birthdayСolumnHeader.Width = 100;
            // 
            // sexColumnHeader
            // 
            this.sexColumnHeader.Text = "Пол";
            // 
            // DBProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 275);
            this.Controls.Add(this.listView1);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader surnameColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader birthdayСolumnHeader;
        private System.Windows.Forms.ColumnHeader sexColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem выполнениеФункцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выполнениеФункцииКакЗапросаToolStripMenuItem;
    }
}

