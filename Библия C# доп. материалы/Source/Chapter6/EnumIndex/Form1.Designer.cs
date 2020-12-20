namespace EnumIndex
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
            this.myColorsComboBox = new System.Windows.Forms.ComboBox();
            this.indexesСomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectedValuesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Мои любимые цвета";
            // 
            // myColorsComboBox
            // 
            this.myColorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.myColorsComboBox.FormattingEnabled = true;
            this.myColorsComboBox.Location = new System.Drawing.Point(141, 13);
            this.myColorsComboBox.Name = "myColorsComboBox";
            this.myColorsComboBox.Size = new System.Drawing.Size(178, 21);
            this.myColorsComboBox.TabIndex = 1;
            this.myColorsComboBox.SelectedIndexChanged += new System.EventHandler(this.myColorsComboBox_SelectedIndexChanged);
            // 
            // indexesСomboBox
            // 
            this.indexesСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indexesСomboBox.FormattingEnabled = true;
            this.indexesСomboBox.Location = new System.Drawing.Point(141, 40);
            this.indexesСomboBox.Name = "indexesСomboBox";
            this.indexesСomboBox.Size = new System.Drawing.Size(178, 21);
            this.indexesСomboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Индексы моих цветов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выбрано значение:";
            // 
            // selectedValuesLabel
            // 
            this.selectedValuesLabel.AutoSize = true;
            this.selectedValuesLabel.Location = new System.Drawing.Point(138, 72);
            this.selectedValuesLabel.Name = "selectedValuesLabel";
            this.selectedValuesLabel.Size = new System.Drawing.Size(58, 13);
            this.selectedValuesLabel.TabIndex = 5;
            this.selectedValuesLabel.Text = "Выделено";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 113);
            this.Controls.Add(this.selectedValuesLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.indexesСomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.myColorsComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Работа с перечислениями";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox myColorsComboBox;
        private System.Windows.Forms.ComboBox indexesСomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectedValuesLabel;
    }
}

