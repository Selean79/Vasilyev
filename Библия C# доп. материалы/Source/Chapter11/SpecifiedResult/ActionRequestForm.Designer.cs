namespace SpecifiedResult
{
    partial class ActionRequestForm
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
            this.overwriteButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.skipButton = new System.Windows.Forms.Button();
            this.overwriteOlderButton = new System.Windows.Forms.Button();
            this.overwriteAllButton = new System.Windows.Forms.Button();
            this.skipAllButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // overwriteButton
            // 
            this.overwriteButton.Location = new System.Drawing.Point(12, 88);
            this.overwriteButton.Name = "overwrideButton";
            this.overwriteButton.Size = new System.Drawing.Size(116, 23);
            this.overwriteButton.TabIndex = 0;
            this.overwriteButton.Text = "Перезаписать";
            this.overwriteButton.UseVisualStyleBackColor = true;
            this.overwriteButton.Click += new System.EventHandler(this.overwriteButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Location = new System.Drawing.Point(13, 118);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(115, 23);
            this.renameButton.TabIndex = 1;
            this.renameButton.Text = "Переименовать";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // skipButton
            // 
            this.skipButton.Location = new System.Drawing.Point(134, 90);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(116, 23);
            this.skipButton.TabIndex = 2;
            this.skipButton.Text = "Пропустить";
            this.skipButton.UseVisualStyleBackColor = true;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // overwriteOlderButton
            // 
            this.overwriteOlderButton.Location = new System.Drawing.Point(134, 119);
            this.overwriteOlderButton.Name = "overwriteOlderButton";
            this.overwriteOlderButton.Size = new System.Drawing.Size(116, 23);
            this.overwriteOlderButton.TabIndex = 3;
            this.overwriteOlderButton.Text = "Перезап. старый";
            this.overwriteOlderButton.UseVisualStyleBackColor = true;
            // 
            // overwriteAllButton
            // 
            this.overwriteAllButton.Location = new System.Drawing.Point(256, 90);
            this.overwriteAllButton.Name = "overwriteAllButton";
            this.overwriteAllButton.Size = new System.Drawing.Size(116, 23);
            this.overwriteAllButton.TabIndex = 4;
            this.overwriteAllButton.Text = "Перезаписать все";
            this.overwriteAllButton.UseVisualStyleBackColor = true;
            this.overwriteAllButton.Click += new System.EventHandler(this.overwriteAllButton_Click);
            // 
            // skipAllButton
            // 
            this.skipAllButton.Location = new System.Drawing.Point(256, 119);
            this.skipAllButton.Name = "skipAllButton";
            this.skipAllButton.Size = new System.Drawing.Size(116, 23);
            this.skipAllButton.TabIndex = 5;
            this.skipAllButton.Text = "Пропустить все";
            this.skipAllButton.UseVisualStyleBackColor = true;
            this.skipAllButton.Click += new System.EventHandler(this.skipAllButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(379, 119);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(114, 23);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Файл уже существует. Что вы предпочитаете сделать с ним?";
            // 
            // ActionRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(505, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.skipAllButton);
            this.Controls.Add(this.overwriteAllButton);
            this.Controls.Add(this.overwriteOlderButton);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.overwriteButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ActionRequestForm";
            this.ShowInTaskbar = false;
            this.Text = "ActionRequestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button overwriteOlderButton;
        private System.Windows.Forms.Button overwriteAllButton;
        private System.Windows.Forms.Button skipAllButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
    }
}