namespace InterfaceProject
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
            this.sumLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.decButton = new System.Windows.Forms.Button();
            this.addWithObjectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текущая сумма";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(106, 19);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(13, 13);
            this.sumLabel.TabIndex = 1;
            this.sumLabel.Text = "0";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(15, 79);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // decButton
            // 
            this.decButton.Location = new System.Drawing.Point(154, 79);
            this.decButton.Name = "decButton";
            this.decButton.Size = new System.Drawing.Size(75, 23);
            this.decButton.TabIndex = 5;
            this.decButton.Text = "Снять";
            this.decButton.UseVisualStyleBackColor = true;
            this.decButton.Click += new System.EventHandler(this.decButton_Click);
            // 
            // addWithObjectButton
            // 
            this.addWithObjectButton.Location = new System.Drawing.Point(15, 108);
            this.addWithObjectButton.Name = "addWithObjectButton";
            this.addWithObjectButton.Size = new System.Drawing.Size(214, 23);
            this.addWithObjectButton.TabIndex = 6;
            this.addWithObjectButton.Text = "Добавить методом объекта";
            this.addWithObjectButton.UseVisualStyleBackColor = true;
            this.addWithObjectButton.Click += new System.EventHandler(this.addWithObjectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 290);
            this.Controls.Add(this.addWithObjectButton);
            this.Controls.Add(this.decButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Интерфейсы";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button decButton;
        private System.Windows.Forms.Button addWithObjectButton;
    }
}

