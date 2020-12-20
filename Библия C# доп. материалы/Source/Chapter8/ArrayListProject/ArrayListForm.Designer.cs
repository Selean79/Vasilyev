namespace ArrayListProject
{
    partial class ArrayListForm
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
            this.addChildButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.childFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.childLastNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.childrenListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteChildButton = new System.Windows.Forms.Button();
            this.currentChildButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addChildButton
            // 
            this.addChildButton.Location = new System.Drawing.Point(13, 13);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(148, 23);
            this.addChildButton.TabIndex = 0;
            this.addChildButton.Text = "Добавить ребенка";
            this.addChildButton.UseVisualStyleBackColor = true;
            this.addChildButton.Click += new System.EventHandler(this.addChildButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // childFirstNameTextBox
            // 
            this.childFirstNameTextBox.Location = new System.Drawing.Point(74, 43);
            this.childFirstNameTextBox.Name = "childFirstNameTextBox";
            this.childFirstNameTextBox.Size = new System.Drawing.Size(87, 20);
            this.childFirstNameTextBox.TabIndex = 2;
            // 
            // childLastNameTextBox
            // 
            this.childLastNameTextBox.Location = new System.Drawing.Point(74, 69);
            this.childLastNameTextBox.Name = "childLastNameTextBox";
            this.childLastNameTextBox.Size = new System.Drawing.Size(87, 20);
            this.childLastNameTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // childrenListBox
            // 
            this.childrenListBox.FormattingEnabled = true;
            this.childrenListBox.Location = new System.Drawing.Point(218, 31);
            this.childrenListBox.Name = "childrenListBox";
            this.childrenListBox.Size = new System.Drawing.Size(179, 147);
            this.childrenListBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дети";
            // 
            // deleteChildButton
            // 
            this.deleteChildButton.Location = new System.Drawing.Point(312, 186);
            this.deleteChildButton.Name = "deleteChildButton";
            this.deleteChildButton.Size = new System.Drawing.Size(85, 23);
            this.deleteChildButton.TabIndex = 7;
            this.deleteChildButton.Text = "Удалить";
            this.deleteChildButton.UseVisualStyleBackColor = true;
            this.deleteChildButton.Click += new System.EventHandler(this.deleteChildButton_Click);
            // 
            // currentChildButton
            // 
            this.currentChildButton.Location = new System.Drawing.Point(218, 186);
            this.currentChildButton.Name = "currentChildButton";
            this.currentChildButton.Size = new System.Drawing.Size(75, 23);
            this.currentChildButton.TabIndex = 8;
            this.currentChildButton.Text = "Выделен";
            this.currentChildButton.UseVisualStyleBackColor = true;
            this.currentChildButton.Click += new System.EventHandler(this.currentChildButton_Click);
            // 
            // ArrayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 221);
            this.Controls.Add(this.currentChildButton);
            this.Controls.Add(this.deleteChildButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.childrenListBox);
            this.Controls.Add(this.childLastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.childFirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addChildButton);
            this.Name = "ArrayListForm";
            this.Text = "Динамический массив";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addChildButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox childFirstNameTextBox;
        private System.Windows.Forms.TextBox childLastNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox childrenListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button deleteChildButton;
        private System.Windows.Forms.Button currentChildButton;
    }
}

