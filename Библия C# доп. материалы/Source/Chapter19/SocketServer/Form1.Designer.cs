namespace SocketServer
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
            this.startServerButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.clientRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.serverAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startServerButton
            // 
            this.startServerButton.Location = new System.Drawing.Point(370, 12);
            this.startServerButton.Name = "startServerButton";
            this.startServerButton.Size = new System.Drawing.Size(158, 23);
            this.startServerButton.TabIndex = 0;
            this.startServerButton.Text = "Запустить сервер";
            this.startServerButton.UseVisualStyleBackColor = true;
            this.startServerButton.Click += new System.EventHandler(this.startServerButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(370, 41);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(158, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Соединиться с сервером";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // clientRichTextBox
            // 
            this.clientRichTextBox.Location = new System.Drawing.Point(12, 99);
            this.clientRichTextBox.Name = "clientRichTextBox";
            this.clientRichTextBox.Size = new System.Drawing.Size(516, 213);
            this.clientRichTextBox.TabIndex = 3;
            this.clientRichTextBox.Text = "";
            // 
            // commandTextBox
            // 
            this.commandTextBox.Location = new System.Drawing.Point(101, 73);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(345, 20);
            this.commandTextBox.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(452, 70);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(76, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // serverAddressTextBox
            // 
            this.serverAddressTextBox.Location = new System.Drawing.Point(101, 44);
            this.serverAddressTextBox.Name = "serverAddressTextBox";
            this.serverAddressTextBox.Size = new System.Drawing.Size(263, 20);
            this.serverAddressTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Адрес сервера";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Команда";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverAddressTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.clientRichTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.startServerButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Клиент - Сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.RichTextBox clientRichTextBox;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox serverAddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

