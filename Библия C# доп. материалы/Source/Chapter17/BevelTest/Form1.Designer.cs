namespace BevelTest
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
            this.bevel1 = new MyComponentClassLibrary.Bevel();
            this.SuspendLayout();
            // 
            // bevel1
            // 
            this.bevel1.Location = new System.Drawing.Point(12, 12);
            this.bevel1.Name = "bevel1";
            this.bevel1.Size = new System.Drawing.Size(90, 69);
            this.bevel1.TabIndex = 0;
            this.bevel1.Load += new System.EventHandler(this.bevel1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.bevel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyComponentClassLibrary.Bevel bevel1;
    }
}

