namespace HttpClient
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.loadButton);
            this.topPanel.Controls.Add(this.urlTextBox);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(623, 70);
            this.topPanel.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(522, 10);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(49, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(473, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "URL";
            // 
            // pageRichTextBox
            // 
            this.pageRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageRichTextBox.Location = new System.Drawing.Point(0, 70);
            this.pageRichTextBox.Name = "pageRichTextBox";
            this.pageRichTextBox.Size = new System.Drawing.Size(623, 298);
            this.pageRichTextBox.TabIndex = 1;
            this.pageRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 368);
            this.Controls.Add(this.pageRichTextBox);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Web Client";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.RichTextBox pageRichTextBox;
    }
}

