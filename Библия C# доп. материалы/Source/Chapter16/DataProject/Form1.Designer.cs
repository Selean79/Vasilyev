namespace DataTableProject
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.getFirstButton = new System.Windows.Forms.Button();
            this.addRowButton = new System.Windows.Forms.Button();
            this.addRow2Button = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // getFirstButton
            // 
            this.getFirstButton.Location = new System.Drawing.Point(12, 8);
            this.getFirstButton.Name = "getFirstButton";
            this.getFirstButton.Size = new System.Drawing.Size(75, 23);
            this.getFirstButton.TabIndex = 1;
            this.getFirstButton.Text = "Тест";
            this.getFirstButton.UseVisualStyleBackColor = true;
            this.getFirstButton.Click += new System.EventHandler(this.getFirstButton_Click);
            // 
            // addRowButton
            // 
            this.addRowButton.Location = new System.Drawing.Point(93, 8);
            this.addRowButton.Name = "addRowButton";
            this.addRowButton.Size = new System.Drawing.Size(126, 23);
            this.addRowButton.TabIndex = 2;
            this.addRowButton.Text = "Добавить строку";
            this.addRowButton.UseVisualStyleBackColor = true;
            this.addRowButton.Click += new System.EventHandler(this.addRowButton_Click);
            // 
            // addRow2Button
            // 
            this.addRow2Button.Location = new System.Drawing.Point(225, 8);
            this.addRow2Button.Name = "addRow2Button";
            this.addRow2Button.Size = new System.Drawing.Size(130, 23);
            this.addRow2Button.TabIndex = 3;
            this.addRow2Button.Text = "Добавить строку 2";
            this.addRow2Button.UseVisualStyleBackColor = true;
            this.addRow2Button.Click += new System.EventHandler(this.addRow2Button_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(480, 8);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(114, 23);
            this.FindButton.TabIndex = 4;
            this.FindButton.Text = "Поиск строки";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(362, 8);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(112, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Редактирование";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(600, 8);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Удаление";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 328);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.addRow2Button);
            this.Controls.Add(this.addRowButton);
            this.Controls.Add(this.getFirstButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Программная таблица";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button getFirstButton;
        private System.Windows.Forms.Button addRowButton;
        private System.Windows.Forms.Button addRow2Button;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

