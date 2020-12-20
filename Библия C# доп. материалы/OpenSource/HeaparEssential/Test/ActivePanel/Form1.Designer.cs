namespace ActivePanel
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
            this.activePanel1 = new heaparessential.Controls.ActivePanel();
            this.SuspendLayout();
            // 
            // activePanel1
            // 
            this.activePanel1.AnimationSpeed = 8;
            this.activePanel1.BackColor = System.Drawing.Color.Yellow;
            this.activePanel1.BottomHighlightColor = System.Drawing.SystemColors.HotTrack;
            this.activePanel1.BottomTitle = "This is a bottom title";
            this.activePanel1.BottomTitleAlign = heaparessential.Controls.TextAligment.Center;
            this.activePanel1.BottomTitleOffset = new System.Drawing.Point(0, 8);
            this.activePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activePanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.activePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.activePanel1.GradientHeight = 30;
            this.activePanel1.HoverColor = System.Drawing.SystemColors.ActiveCaption;
            this.activePanel1.Location = new System.Drawing.Point(0, 0);
            this.activePanel1.Name = "activePanel1";
            this.activePanel1.PassiveColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.activePanel1.Size = new System.Drawing.Size(517, 295);
            this.activePanel1.TabIndex = 0;
            this.activePanel1.TopHighlightColor = System.Drawing.SystemColors.Window;
            this.activePanel1.TopTitle = "This is a top title";
            this.activePanel1.TopTitleAlign = heaparessential.Controls.TextAligment.Center;
            this.activePanel1.TopTitleOffset = new System.Drawing.Point(0, 8);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 295);
            this.Controls.Add(this.activePanel1);
            this.Name = "Form1";
            this.Text = "Active Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private heaparessential.Controls.ActivePanel activePanel1;
    }
}

