namespace heaparessential.Controls
{
    partial class ButtonsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.captionPanel = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.captionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // captionPanel
            // 
            this.captionPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.captionPanel.Controls.Add(this.buttonPanel);
            this.captionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.captionPanel.Location = new System.Drawing.Point(0, 0);
            this.captionPanel.Name = "captionPanel";
            this.captionPanel.Size = new System.Drawing.Size(150, 16);
            this.captionPanel.TabIndex = 0;
            this.captionPanel.DoubleClick += new System.EventHandler(this.captionPanel_DoubleClick);
            this.captionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.captionPanel_Paint);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Location = new System.Drawing.Point(3, 3);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(9, 9);
            this.buttonPanel.TabIndex = 0;
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPanel_Paint);
            this.buttonPanel.Click += new System.EventHandler(this.buttonPanel_Click);
            // 
            // ButtonsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.captionPanel);
            this.Name = "ButtonsPanel";
            this.MouseLeave += new System.EventHandler(this.ButtonsPanel_MouseLeave);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonsPanel_Paint);
            this.Click += new System.EventHandler(this.ButtonsPanel_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ButtonsPanel_MouseMove);
            this.captionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel captionPanel;
        private System.Windows.Forms.Panel buttonPanel;
    }
}
