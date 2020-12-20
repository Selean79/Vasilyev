namespace CheckBoxProject
{
    partial class CheckBoxForm
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
            this.runAtStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteOnExitCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.byDefaultButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runAtStartupCheckBox
            // 
            this.runAtStartupCheckBox.AutoSize = true;
            this.runAtStartupCheckBox.Checked = true;
            this.runAtStartupCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.runAtStartupCheckBox.Location = new System.Drawing.Point(12, 12);
            this.runAtStartupCheckBox.Name = "runAtStartupCheckBox";
            this.runAtStartupCheckBox.Size = new System.Drawing.Size(214, 17);
            this.runAtStartupCheckBox.TabIndex = 0;
            this.runAtStartupCheckBox.Text = "Запускать программу при старте ОС";
            this.runAtStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // deleteOnExitCheckBox
            // 
            this.deleteOnExitCheckBox.AutoSize = true;
            this.deleteOnExitCheckBox.Location = new System.Drawing.Point(12, 35);
            this.deleteOnExitCheckBox.Name = "deleteOnExitCheckBox";
            this.deleteOnExitCheckBox.Size = new System.Drawing.Size(244, 17);
            this.deleteOnExitCheckBox.TabIndex = 1;
            this.deleteOnExitCheckBox.Text = "Удалять файлы при выходе из программы";
            this.deleteOnExitCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(228, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "http://www.flenov.info";
            // 
            // byDefaultButton
            // 
            this.byDefaultButton.Location = new System.Drawing.Point(12, 172);
            this.byDefaultButton.Name = "byDefaultButton";
            this.byDefaultButton.Size = new System.Drawing.Size(100, 23);
            this.byDefaultButton.TabIndex = 3;
            this.byDefaultButton.Text = "По умолчанию";
            this.byDefaultButton.UseVisualStyleBackColor = true;
            this.byDefaultButton.Click += new System.EventHandler(this.byDefaultButton_Click);
            // 
            // CheckBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 204);
            this.Controls.Add(this.byDefaultButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteOnExitCheckBox);
            this.Controls.Add(this.runAtStartupCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckBoxForm";
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox runAtStartupCheckBox;
        private System.Windows.Forms.CheckBox deleteOnExitCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button byDefaultButton;
    }
}

