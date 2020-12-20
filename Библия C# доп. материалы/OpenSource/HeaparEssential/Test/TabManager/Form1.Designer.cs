namespace TabManager
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
            this.pageManager1 = new heaparessential.Controls.PageManager();
            this.page1 = new heaparessential.Controls.Page();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.page7 = new heaparessential.Controls.Page();
            this.page6 = new heaparessential.Controls.Page();
            this.page5 = new heaparessential.Controls.Page();
            this.page4 = new heaparessential.Controls.Page();
            this.page3 = new heaparessential.Controls.Page();
            this.page2 = new heaparessential.Controls.Page();
            this.pageManager1.SuspendLayout();
            this.page1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageManager1
            // 
            this.pageManager1.Controls.Add(this.page1);
            this.pageManager1.Controls.Add(this.page7);
            this.pageManager1.Controls.Add(this.page6);
            this.pageManager1.Controls.Add(this.page5);
            this.pageManager1.Controls.Add(this.page4);
            this.pageManager1.Controls.Add(this.page3);
            this.pageManager1.Controls.Add(this.page2);
            this.pageManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageManager1.Location = new System.Drawing.Point(0, 0);
            this.pageManager1.Name = "pageManager1";
            this.pageManager1.Pages.AddRange(new heaparessential.Controls.Page[] {
            this.page1,
            this.page2,
            this.page3,
            this.page4,
            this.page5,
            this.page6,
            this.page7});
            this.pageManager1.SelectedPage = 0;
            this.pageManager1.SelectedPageName = "page1";
            this.pageManager1.ShowTabs = true;
            this.pageManager1.Size = new System.Drawing.Size(660, 366);
            this.pageManager1.TabIndex = 0;
            this.pageManager1.TabPosition = heaparessential.Controls.TabPositionKind.Top;
            this.pageManager1.TabsPanelSize = new System.Drawing.Size(660, 18);
            this.pageManager1.Load += new System.EventHandler(this.pageManager1_Load);
            // 
            // page1
            // 
            this.page1.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page1.Controls.Add(this.radioButton4);
            this.page1.Controls.Add(this.radioButton3);
            this.page1.Controls.Add(this.radioButton2);
            this.page1.Controls.Add(this.label1);
            this.page1.Controls.Add(this.radioButton1);
            this.page1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page1.DrawBorder = false;
            this.page1.Location = new System.Drawing.Point(0, 18);
            this.page1.Name = "page1";
            this.page1.Padding = new System.Windows.Forms.Padding(2);
            this.page1.Size = new System.Drawing.Size(660, 348);
            this.page1.TabIndex = 1;
            this.page1.Title = "Properties page";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(33, 119);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(77, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Text = "Right edge";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(33, 96);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Text = "Left edge";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(33, 73);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Bottom edge";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show tabs on the:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(33, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Top edge";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // page7
            // 
            this.page7.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page7.DrawBorder = false;
            this.page7.Location = new System.Drawing.Point(0, 18);
            this.page7.Name = "page7";
            this.page7.Padding = new System.Windows.Forms.Padding(2);
            this.page7.Size = new System.Drawing.Size(660, 348);
            this.page7.TabIndex = 7;
            this.page7.Title = "It is a page 7";
            // 
            // page6
            // 
            this.page6.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page6.DrawBorder = false;
            this.page6.Location = new System.Drawing.Point(0, 18);
            this.page6.Name = "page6";
            this.page6.Padding = new System.Windows.Forms.Padding(2);
            this.page6.Size = new System.Drawing.Size(660, 348);
            this.page6.TabIndex = 6;
            this.page6.Title = "The page 6";
            // 
            // page5
            // 
            this.page5.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page5.DrawBorder = false;
            this.page5.Location = new System.Drawing.Point(0, 18);
            this.page5.Name = "page5";
            this.page5.Padding = new System.Windows.Forms.Padding(2);
            this.page5.Size = new System.Drawing.Size(660, 348);
            this.page5.TabIndex = 5;
            this.page5.Title = "The page contains some components";
            // 
            // page4
            // 
            this.page4.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page4.DrawBorder = false;
            this.page4.Location = new System.Drawing.Point(0, 18);
            this.page4.Name = "page4";
            this.page4.Padding = new System.Windows.Forms.Padding(2);
            this.page4.Size = new System.Drawing.Size(660, 348);
            this.page4.TabIndex = 4;
            this.page4.Title = "It is a page for properties";
            // 
            // page3
            // 
            this.page3.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page3.DrawBorder = false;
            this.page3.Location = new System.Drawing.Point(0, 18);
            this.page3.Name = "page3";
            this.page3.Padding = new System.Windows.Forms.Padding(2);
            this.page3.Size = new System.Drawing.Size(660, 348);
            this.page3.TabIndex = 3;
            this.page3.Title = "It is a page 3";
            // 
            // page2
            // 
            this.page2.ActiveColor = System.Drawing.SystemColors.ActiveCaption;
            this.page2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.page2.DrawBorder = false;
            this.page2.Location = new System.Drawing.Point(0, 18);
            this.page2.Name = "page2";
            this.page2.Padding = new System.Windows.Forms.Padding(2);
            this.page2.Size = new System.Drawing.Size(660, 348);
            this.page2.TabIndex = 2;
            this.page2.Title = "The Page 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 366);
            this.Controls.Add(this.pageManager1);
            this.Name = "Form1";
            this.Text = "Page Manager";
            this.pageManager1.ResumeLayout(false);
            this.page1.ResumeLayout(false);
            this.page1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private heaparessential.Controls.PageManager pageManager1;
        private heaparessential.Controls.Page page1;
        private heaparessential.Controls.Page page3;
        private heaparessential.Controls.Page page2;
        private heaparessential.Controls.Page page7;
        private heaparessential.Controls.Page page6;
        private heaparessential.Controls.Page page5;
        private heaparessential.Controls.Page page4;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;


    }
}

