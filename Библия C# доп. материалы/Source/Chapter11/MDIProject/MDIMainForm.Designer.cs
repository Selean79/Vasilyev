namespace MDIProject
{
    partial class MDIMainForm
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
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьГоризонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьВертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выровнятьИконкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пометитьАктивноеОкноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переименоватьЗаголовкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.окнаToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // окнаToolStripMenuItem
            // 
            this.окнаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.выровнятьГоризонтальноToolStripMenuItem,
            this.выровнятьВертикальноToolStripMenuItem,
            this.выровнятьИконкиToolStripMenuItem});
            this.окнаToolStripMenuItem.Name = "окнаToolStripMenuItem";
            this.окнаToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.окнаToolStripMenuItem.Text = "Окна";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // выровнятьГоризонтальноToolStripMenuItem
            // 
            this.выровнятьГоризонтальноToolStripMenuItem.Name = "выровнятьГоризонтальноToolStripMenuItem";
            this.выровнятьГоризонтальноToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.выровнятьГоризонтальноToolStripMenuItem.Text = "Выровнять горизонтально";
            this.выровнятьГоризонтальноToolStripMenuItem.Click += new System.EventHandler(this.выровнятьГоризонтальноToolStripMenuItem_Click);
            // 
            // выровнятьВертикальноToolStripMenuItem
            // 
            this.выровнятьВертикальноToolStripMenuItem.Name = "выровнятьВертикальноToolStripMenuItem";
            this.выровнятьВертикальноToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.выровнятьВертикальноToolStripMenuItem.Text = "Выровнять вертикально";
            this.выровнятьВертикальноToolStripMenuItem.Click += new System.EventHandler(this.выровнятьВертикальноToolStripMenuItem_Click);
            // 
            // выровнятьИконкиToolStripMenuItem
            // 
            this.выровнятьИконкиToolStripMenuItem.Name = "выровнятьИконкиToolStripMenuItem";
            this.выровнятьИконкиToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.выровнятьИконкиToolStripMenuItem.Text = "Выровнять иконки";
            this.выровнятьИконкиToolStripMenuItem.Click += new System.EventHandler(this.выровнятьИконкиToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пометитьАктивноеОкноToolStripMenuItem,
            this.переименоватьЗаголовкиToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // пометитьАктивноеОкноToolStripMenuItem
            // 
            this.пометитьАктивноеОкноToolStripMenuItem.Name = "пометитьАктивноеОкноToolStripMenuItem";
            this.пометитьАктивноеОкноToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.пометитьАктивноеОкноToolStripMenuItem.Text = "Пометить активное окно";
            this.пометитьАктивноеОкноToolStripMenuItem.Click += new System.EventHandler(this.пометитьАктивноеОкноToolStripMenuItem_Click);
            // 
            // переименоватьЗаголовкиToolStripMenuItem
            // 
            this.переименоватьЗаголовкиToolStripMenuItem.Name = "переименоватьЗаголовкиToolStripMenuItem";
            this.переименоватьЗаголовкиToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.переименоватьЗаголовкиToolStripMenuItem.Text = "Переименовать заголовки";
            this.переименоватьЗаголовкиToolStripMenuItem.Click += new System.EventHandler(this.переименоватьЗаголовкиToolStripMenuItem_Click);
            // 
            // MDIMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 326);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIMainForm";
            this.Text = "Многодокументное приложение";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьГоризонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьВертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выровнятьИконкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пометитьАктивноеОкноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переименоватьЗаголовкиToolStripMenuItem;
    }
}

