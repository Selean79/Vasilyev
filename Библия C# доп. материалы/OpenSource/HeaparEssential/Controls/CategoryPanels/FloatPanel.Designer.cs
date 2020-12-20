namespace heaparessential.Controls
{
    partial class FloatPanel
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
            this.controlsPanel = new heaparessential.Controls.FloatDesignPanel();
            this.controlActivePanel = new heaparessential.Controls.FloatPanelCaption();
            this.SuspendLayout();
            // 
            // controlsPanel
            // 
            this.controlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsPanel.Location = new System.Drawing.Point(0, 22);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(150, 128);
            this.controlsPanel.TabIndex = 1;
            // 
            // controlActivePanel
            // 
            this.controlActivePanel.Animation = true;
            this.controlActivePanel.AnimationSpeed = 10;
            this.controlActivePanel.BottomHighlightColor = System.Drawing.SystemColors.Window;
            this.controlActivePanel.BottomTitle = "";
            this.controlActivePanel.BottomTitleAlign = heaparessential.Controls.TextAligment.Left;
            this.controlActivePanel.BottomTitleOffset = new System.Drawing.Point(8, 8);
            this.controlActivePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlActivePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.controlActivePanel.ForeColor = System.Drawing.Color.Black;
            this.controlActivePanel.GradientHeight = 22;
            this.controlActivePanel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(90)))));
            this.controlActivePanel.ImageBox = null;
            this.controlActivePanel.Location = new System.Drawing.Point(0, 0);
            this.controlActivePanel.Name = "controlActivePanel";
            this.controlActivePanel.PassiveColor = System.Drawing.SystemColors.InactiveCaption;
            this.controlActivePanel.Size = new System.Drawing.Size(150, 22);
            this.controlActivePanel.TabIndex = 0;
            this.controlActivePanel.TopHighlightColor = System.Drawing.SystemColors.Window;
            this.controlActivePanel.TopTitle = "";
            this.controlActivePanel.TopTitleAlign = heaparessential.Controls.TextAligment.Left;
            this.controlActivePanel.TopTitleOffset = new System.Drawing.Point(20, 4);
            this.controlActivePanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.controlActivePanel_MouseDoubleClick);
            // 
            // FloatPanel
            // 
            this.Controls.Add(this.controlsPanel);
            this.Controls.Add(this.controlActivePanel);
            this.Name = "FloatPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private FloatPanelCaption controlActivePanel;
        public FloatDesignPanel controlsPanel;
    }
}
