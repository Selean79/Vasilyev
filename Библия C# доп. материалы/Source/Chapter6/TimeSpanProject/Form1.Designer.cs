namespace TimeSpanProject
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
            this.addSomeMinutesButton = new System.Windows.Forms.Button();
            this.getOneHourButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addSomeMinutesButton
            // 
            this.addSomeMinutesButton.Location = new System.Drawing.Point(12, 54);
            this.addSomeMinutesButton.Name = "addSomeMinutesButton";
            this.addSomeMinutesButton.Size = new System.Drawing.Size(128, 23);
            this.addSomeMinutesButton.TabIndex = 0;
            this.addSomeMinutesButton.Text = "Добавить 15 минут";
            this.addSomeMinutesButton.UseVisualStyleBackColor = true;
            this.addSomeMinutesButton.Click += new System.EventHandler(this.addSomeMinutesButton_Click);
            // 
            // getOneHourButton
            // 
            this.getOneHourButton.Location = new System.Drawing.Point(177, 54);
            this.getOneHourButton.Name = "getOneHourButton";
            this.getOneHourButton.Size = new System.Drawing.Size(128, 23);
            this.getOneHourButton.TabIndex = 1;
            this.getOneHourButton.Text = "Добавить час";
            this.getOneHourButton.UseVisualStyleBackColor = true;
            this.getOneHourButton.Click += new System.EventHandler(this.getOneHourButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текущее время:";
            // 
            // dateTimeLabel
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Location = new System.Drawing.Point(115, 9);
            this.dateTimeLabel.Name = "dateTimeLabel";
            this.dateTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.dateTimeLabel.TabIndex = 3;
            this.dateTimeLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 89);
            this.Controls.Add(this.dateTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getOneHourButton);
            this.Controls.Add(this.addSomeMinutesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "TimeSpan - работа со временем";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addSomeMinutesButton;
        private System.Windows.Forms.Button getOneHourButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateTimeLabel;
    }
}

