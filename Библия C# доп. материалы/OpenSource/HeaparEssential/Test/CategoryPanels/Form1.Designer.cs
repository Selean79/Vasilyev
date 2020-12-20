namespace CategoryPanelsTest
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.categoryPanels1 = new heaparessential.Controls.CategoryPanels();
            this.floatPanel2 = new heaparessential.Controls.FloatPanel();
            this.floatPanel1 = new heaparessential.Controls.FloatPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.categoryPanels1.SuspendLayout();
            this.floatPanel2.SuspendLayout();
            this.floatPanel1.ControlsPanel.SuspendLayout();
            this.floatPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(55, 72);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // categoryPanels1
            // 
            this.categoryPanels1.AutoScroll = true;
            this.categoryPanels1.Controls.Add(this.floatPanel2);
            this.categoryPanels1.Controls.Add(this.floatPanel1);
            this.categoryPanels1.Location = new System.Drawing.Point(12, 12);
            this.categoryPanels1.Name = "categoryPanels1";
            this.categoryPanels1.Panels.AddRange(new heaparessential.Controls.FloatPanel[] {
            this.floatPanel1,
            this.floatPanel2});
            this.categoryPanels1.Size = new System.Drawing.Size(309, 258);
            this.categoryPanels1.TabIndex = 0;
            // 
            // floatPanel2
            // 
            this.floatPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // floatPanel2.FloatPanel
            // 
            this.floatPanel2.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floatPanel2.ControlsPanel.Location = new System.Drawing.Point(0, 22);
            this.floatPanel2.ControlsPanel.Name = "FloatPanel";
            this.floatPanel2.ControlsPanel.Size = new System.Drawing.Size(290, 143);
            this.floatPanel2.ControlsPanel.TabIndex = 1;
            this.floatPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.floatPanel2.Location = new System.Drawing.Point(0, 122);
            this.floatPanel2.Name = "floatPanel2";
            this.floatPanel2.Opened = true;
            this.floatPanel2.PanelHeight = 128;
            this.floatPanel2.Size = new System.Drawing.Size(292, 167);
            this.floatPanel2.TabIndex = 1;
            this.floatPanel2.Title = "Panel 2";
            // 
            // floatPanel1
            // 
            this.floatPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // floatPanel1.FloatPanel
            // 
            this.floatPanel1.ControlsPanel.Controls.Add(this.label1);
            this.floatPanel1.ControlsPanel.Controls.Add(this.textBox1);
            this.floatPanel1.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.floatPanel1.ControlsPanel.Location = new System.Drawing.Point(0, 22);
            this.floatPanel1.ControlsPanel.Name = "FloatPanel";
            this.floatPanel1.ControlsPanel.Size = new System.Drawing.Size(290, 98);
            this.floatPanel1.ControlsPanel.TabIndex = 1;
            this.floatPanel1.ControlsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.floatPanel1_ControlsPanel_Paint);
            this.floatPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.floatPanel1.Location = new System.Drawing.Point(0, 0);
            this.floatPanel1.Name = "floatPanel1";
            this.floatPanel1.Opened = true;
            this.floatPanel1.PanelHeight = 100;
            this.floatPanel1.Size = new System.Drawing.Size(292, 122);
            this.floatPanel1.TabIndex = 0;
            this.floatPanel1.Title = "Panel 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The test";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 282);
            this.Controls.Add(this.categoryPanels1);
            this.Name = "Form1";
            this.Text = "Category Panels Test";
            this.categoryPanels1.ResumeLayout(false);
            this.floatPanel2.ResumeLayout(false);
            this.floatPanel1.ControlsPanel.ResumeLayout(false);
            this.floatPanel1.ControlsPanel.PerformLayout();
            this.floatPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private heaparessential.Controls.CategoryPanels categoryPanels1;
        private heaparessential.Controls.FloatPanel floatPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private heaparessential.Controls.FloatPanel floatPanel2;
        private System.Windows.Forms.Label label1;
    }
}

