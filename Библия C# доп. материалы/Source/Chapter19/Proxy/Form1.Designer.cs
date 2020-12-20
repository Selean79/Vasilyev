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
            this.label1 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.useProxyCheckBox = new System.Windows.Forms.CheckBox();
            this.proxyPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.proxyAddressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.proxyPortTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.proxyUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.proxyPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.pageRichTextBox = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            this.proxyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.loadButton);
            this.topPanel.Controls.Add(this.proxyPanel);
            this.topPanel.Controls.Add(this.useProxyCheckBox);
            this.topPanel.Controls.Add(this.urlTextBox);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(623, 78);
            this.topPanel.TabIndex = 0;
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
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(49, 12);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(473, 20);
            this.urlTextBox.TabIndex = 2;
            // 
            // useProxyCheckBox
            // 
            this.useProxyCheckBox.AutoSize = true;
            this.useProxyCheckBox.Location = new System.Drawing.Point(17, 38);
            this.useProxyCheckBox.Name = "useProxyCheckBox";
            this.useProxyCheckBox.Size = new System.Drawing.Size(73, 17);
            this.useProxyCheckBox.TabIndex = 3;
            this.useProxyCheckBox.Text = "Use proxy";
            this.useProxyCheckBox.UseVisualStyleBackColor = true;
            this.useProxyCheckBox.CheckedChanged += new System.EventHandler(this.useProxyCheckBox_CheckedChanged);
            // 
            // proxyPanel
            // 
            this.proxyPanel.Controls.Add(this.proxyPasswordTextBox);
            this.proxyPanel.Controls.Add(this.label5);
            this.proxyPanel.Controls.Add(this.proxyUsernameTextBox);
            this.proxyPanel.Controls.Add(this.label4);
            this.proxyPanel.Controls.Add(this.proxyPortTextBox);
            this.proxyPanel.Controls.Add(this.label3);
            this.proxyPanel.Controls.Add(this.proxyAddressTextBox);
            this.proxyPanel.Controls.Add(this.label2);
            this.proxyPanel.Enabled = false;
            this.proxyPanel.Location = new System.Drawing.Point(96, 38);
            this.proxyPanel.Name = "proxyPanel";
            this.proxyPanel.Size = new System.Drawing.Size(526, 39);
            this.proxyPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address";
            // 
            // proxyAddressTextBox
            // 
            this.proxyAddressTextBox.Location = new System.Drawing.Point(54, 10);
            this.proxyAddressTextBox.Name = "proxyAddressTextBox";
            this.proxyAddressTextBox.Size = new System.Drawing.Size(78, 20);
            this.proxyAddressTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port";
            // 
            // proxyPortTextBox
            // 
            this.proxyPortTextBox.Location = new System.Drawing.Point(170, 10);
            this.proxyPortTextBox.Name = "proxyPortTextBox";
            this.proxyPortTextBox.Size = new System.Drawing.Size(43, 20);
            this.proxyPortTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Username";
            // 
            // proxyUsernameTextBox
            // 
            this.proxyUsernameTextBox.Location = new System.Drawing.Point(282, 10);
            this.proxyUsernameTextBox.Name = "proxyUsernameTextBox";
            this.proxyUsernameTextBox.Size = new System.Drawing.Size(77, 20);
            this.proxyUsernameTextBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Password";
            // 
            // proxyPasswordTextBox
            // 
            this.proxyPasswordTextBox.Location = new System.Drawing.Point(426, 10);
            this.proxyPasswordTextBox.Name = "proxyPasswordTextBox";
            this.proxyPasswordTextBox.Size = new System.Drawing.Size(89, 20);
            this.proxyPasswordTextBox.TabIndex = 7;
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
            // pageRichTextBox
            // 
            this.pageRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageRichTextBox.Location = new System.Drawing.Point(0, 78);
            this.pageRichTextBox.Name = "pageRichTextBox";
            this.pageRichTextBox.Size = new System.Drawing.Size(623, 290);
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
            this.proxyPanel.ResumeLayout(false);
            this.proxyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.CheckBox useProxyCheckBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel proxyPanel;
        private System.Windows.Forms.TextBox proxyPortTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proxyAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox proxyUsernameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox proxyPasswordTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.RichTextBox pageRichTextBox;
    }
}

