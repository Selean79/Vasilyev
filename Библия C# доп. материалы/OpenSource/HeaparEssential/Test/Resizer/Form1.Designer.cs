namespace Resizer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.heaparResizer2 = new heaparessential.Controls.HeaparResizer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.heaparResizer1 = new heaparessential.Controls.HeaparResizer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.heaparResizer3 = new heaparessential.Controls.HeaparResizer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.heaparResizer1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(390, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 361);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(386, 361);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // heaparResizer2
            // 
            this.heaparResizer2.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.heaparResizer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.heaparResizer2.Location = new System.Drawing.Point(386, 0);
            this.heaparResizer2.Name = "heaparResizer2";
            this.heaparResizer2.Size = new System.Drawing.Size(4, 361);
            this.heaparResizer2.Style = heaparessential.Controls.ResizerStyle.Horizontal;
            this.heaparResizer2.TabIndex = 4;
            this.heaparResizer2.Text = "heaparResizer2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 246);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(157, 115);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(157, 246);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.heaparResizer3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(149, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(107, 78);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // heaparResizer1
            // 
            this.heaparResizer1.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.heaparResizer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.heaparResizer1.Location = new System.Drawing.Point(0, 242);
            this.heaparResizer1.Name = "heaparResizer1";
            this.heaparResizer1.Size = new System.Drawing.Size(157, 4);
            this.heaparResizer1.Style = heaparessential.Controls.ResizerStyle.Vertical;
            this.heaparResizer1.TabIndex = 2;
            this.heaparResizer1.Text = "heaparResizer1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 67);
            this.panel2.TabIndex = 0;
            // 
            // heaparResizer3
            // 
            this.heaparResizer3.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.heaparResizer3.Dock = System.Windows.Forms.DockStyle.Top;
            this.heaparResizer3.Location = new System.Drawing.Point(3, 70);
            this.heaparResizer3.Name = "heaparResizer3";
            this.heaparResizer3.Size = new System.Drawing.Size(143, 4);
            this.heaparResizer3.Style = heaparessential.Controls.ResizerStyle.Vertical;
            this.heaparResizer3.TabIndex = 1;
            this.heaparResizer3.Text = "heaparResizer3";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 134);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 361);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.heaparResizer2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Resizer Test";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private heaparessential.Controls.HeaparResizer heaparResizer2;
        private System.Windows.Forms.ListView listView1;
        private heaparessential.Controls.HeaparResizer heaparResizer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
        private heaparessential.Controls.HeaparResizer heaparResizer3;
        private System.Windows.Forms.Panel panel2;
    }
}

