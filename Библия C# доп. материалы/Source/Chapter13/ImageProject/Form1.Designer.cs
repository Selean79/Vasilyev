﻿namespace ImageProject
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
            this.loadImgeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // loadImgeButton
            // 
            this.loadImgeButton.Location = new System.Drawing.Point(12, 12);
            this.loadImgeButton.Name = "loadImgeButton";
            this.loadImgeButton.Size = new System.Drawing.Size(142, 23);
            this.loadImgeButton.TabIndex = 0;
            this.loadImgeButton.Text = "Загрузить картинку";
            this.loadImgeButton.UseVisualStyleBackColor = true;
            this.loadImgeButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 251);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loadImgeButton);
            this.Name = "Form1";
            this.Text = "Работа с картинкой";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button loadImgeButton;
        private System.Windows.Forms.Panel panel1;
    }
}

