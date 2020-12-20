namespace Schema
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
            this.label1 = new System.Windows.Forms.Label();
            this.tablesListBox = new System.Windows.Forms.ListBox();
            this.columnsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблицы";
            // 
            // tablesListBox
            // 
            this.tablesListBox.FormattingEnabled = true;
            this.tablesListBox.Location = new System.Drawing.Point(12, 34);
            this.tablesListBox.Name = "tablesListBox";
            this.tablesListBox.Size = new System.Drawing.Size(179, 212);
            this.tablesListBox.TabIndex = 1;
            // 
            // columnsListBox
            // 
            this.columnsListBox.FormattingEnabled = true;
            this.columnsListBox.Location = new System.Drawing.Point(225, 36);
            this.columnsListBox.Name = "columnsListBox";
            this.columnsListBox.Size = new System.Drawing.Size(179, 212);
            this.columnsListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Столбцы в Peoples";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 260);
            this.Controls.Add(this.columnsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablesListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Информация о схеме данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox tablesListBox;
        private System.Windows.Forms.ListBox columnsListBox;
        private System.Windows.Forms.Label label2;
    }
}

