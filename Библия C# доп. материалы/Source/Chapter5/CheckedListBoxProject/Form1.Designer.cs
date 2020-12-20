namespace CheckedListBoxProject
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.getSelectedButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Items.AddRange(new object[] {
            "Хлеб",
            "Молоко",
            "Мясо",
            "Печенюшки",
            "Корм детям",
            "Рыба",
            "Картошка",
            "Книжку почитать",
            "Горошек",
            "Сок",
            "Колбаса",
            "Сыр",
            "Актимель",
            "Кефир",
            "Сметана",
            "Варенье",
            "Мёд",
            "Вода",
            "Зелень",
            "Сахар",
            "Мука",
            "Соль",
            "Булочки",
            "Торт",
            "Кукуруза"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 25);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(416, 169);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список покупок";
            // 
            // getSelectedButton
            // 
            this.getSelectedButton.Location = new System.Drawing.Point(329, 233);
            this.getSelectedButton.Name = "getSelectedButton";
            this.getSelectedButton.Size = new System.Drawing.Size(99, 23);
            this.getSelectedButton.TabIndex = 2;
            this.getSelectedButton.Text = "Выделенные";
            this.getSelectedButton.UseVisualStyleBackColor = true;
            this.getSelectedButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(12, 233);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(135, 23);
            this.deleteSelectedButton.TabIndex = 3;
            this.deleteSelectedButton.Text = "Удалить отмеченные";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            this.deleteSelectedButton.Click += new System.EventHandler(this.deleteSelectedButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(153, 233);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(279, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(149, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.hackishcode.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Сейчас выделен:";
            // 
            // selectedLabel
            // 
            this.selectedLabel.AutoSize = true;
            this.selectedLabel.Location = new System.Drawing.Point(114, 203);
            this.selectedLabel.Name = "selectedLabel";
            this.selectedLabel.Size = new System.Drawing.Size(43, 13);
            this.selectedLabel.TabIndex = 7;
            this.selectedLabel.Text = "Ничего";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 268);
            this.Controls.Add(this.selectedLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.getSelectedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "CheckedListBox ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getSelectedButton;
        private System.Windows.Forms.Button deleteSelectedButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label selectedLabel;
    }
}

