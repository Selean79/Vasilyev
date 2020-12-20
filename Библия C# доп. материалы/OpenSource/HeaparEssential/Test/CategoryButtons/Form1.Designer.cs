namespace CategoryButtons
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
            heaparessential.Controls.CBButton cbButton13 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton14 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton15 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton16 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton17 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton18 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton19 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton20 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton21 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton22 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton23 = new heaparessential.Controls.CBButton();
            heaparessential.Controls.CBButton cbButton24 = new heaparessential.Controls.CBButton();
            this.bevel1 = new heaparessential.Controls.Bevel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonsPanel1 = new heaparessential.Controls.ButtonsPanel();
            this.categoryBattons1 = new heaparessential.Controls.CategoryBattonsPanel();
            this.buttonsPanel2 = new heaparessential.Controls.ButtonsPanel();
            this.buttonsPanel3 = new heaparessential.Controls.ButtonsPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.categoryBattons1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bevel1
            // 
            this.bevel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bevel1.Location = new System.Drawing.Point(0, 0);
            this.bevel1.Name = "bevel1";
            this.bevel1.Shape = heaparessential.Controls.BevelShape.Frame;
            this.bevel1.Size = new System.Drawing.Size(484, 290);
            this.bevel1.Style = heaparessential.Controls.BevelStyle.Lowered;
            this.bevel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonsPanel1
            // 
            this.buttonsPanel1.AutoScroll = true;
            cbButton13.Enabled = true;
            cbButton13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton13.Image = global::CategoryButtons.Properties.Resources.AsIcon;
            cbButton13.Tag = null;
            cbButton13.Title = "As Icon";
            cbButton14.Enabled = true;
            cbButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton14.Image = global::CategoryButtons.Properties.Resources.AsList;
            cbButton14.Tag = null;
            cbButton14.Title = "As List";
            cbButton15.Enabled = true;
            cbButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton15.Image = global::CategoryButtons.Properties.Resources.AsSmallIcon;
            cbButton15.Tag = null;
            cbButton15.Title = "As Small Icon";
            cbButton16.Enabled = true;
            cbButton16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton16.Image = global::CategoryButtons.Properties.Resources.AsReport;
            cbButton16.Tag = null;
            cbButton16.Title = "As Report";
            this.buttonsPanel1.Buttons.AddRange(new heaparessential.Controls.CBButton[] {
            cbButton13,
            cbButton14,
            cbButton15,
            cbButton16});
            this.buttonsPanel1.ButtonsHeight = 24;
            this.buttonsPanel1.Location = new System.Drawing.Point(12, 33);
            this.buttonsPanel1.Name = "buttonsPanel1";
            this.buttonsPanel1.Opened = true;
            this.buttonsPanel1.SelectedButtonIndex = -1;
            this.buttonsPanel1.ShowCaptionPanel = true;
            this.buttonsPanel1.Size = new System.Drawing.Size(179, 112);
            this.buttonsPanel1.TabIndex = 2;
            this.buttonsPanel1.Title = "View Style";
            this.buttonsPanel1.Clicked += new heaparessential.Controls.ButtonsPanel.ButtonClicked(this.buttonsPanel1_Clicked);
            // 
            // categoryBattons1
            // 
            this.categoryBattons1.AutoScroll = true;
            this.categoryBattons1.Categories.AddRange(new heaparessential.Controls.ButtonsPanel[] {
            this.buttonsPanel2,
            this.buttonsPanel3});
            this.categoryBattons1.Controls.Add(this.buttonsPanel3);
            this.categoryBattons1.Controls.Add(this.buttonsPanel2);
            this.categoryBattons1.Location = new System.Drawing.Point(258, 33);
            this.categoryBattons1.Name = "categoryBattons1";
            this.categoryBattons1.SelectedPanel = null;
            this.categoryBattons1.Size = new System.Drawing.Size(214, 177);
            this.categoryBattons1.TabIndex = 3;
            // 
            // buttonsPanel2
            // 
            this.buttonsPanel2.AutoScroll = true;
            cbButton17.Enabled = true;
            cbButton17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton17.Image = global::CategoryButtons.Properties.Resources.AsIcon;
            cbButton17.Tag = null;
            cbButton17.Title = "As Icon";
            cbButton18.Enabled = true;
            cbButton18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton18.Image = global::CategoryButtons.Properties.Resources.AsList;
            cbButton18.Tag = null;
            cbButton18.Title = "As List";
            cbButton19.Enabled = true;
            cbButton19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton19.Image = global::CategoryButtons.Properties.Resources.AsSmallIcon;
            cbButton19.Tag = null;
            cbButton19.Title = "As Small Icon";
            cbButton20.Enabled = true;
            cbButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton20.Image = global::CategoryButtons.Properties.Resources.AsReport;
            cbButton20.Tag = null;
            cbButton20.Title = "As Report";
            this.buttonsPanel2.Buttons.AddRange(new heaparessential.Controls.CBButton[] {
            cbButton17,
            cbButton18,
            cbButton19,
            cbButton20});
            this.buttonsPanel2.ButtonsHeight = 24;
            this.buttonsPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel2.Location = new System.Drawing.Point(0, 0);
            this.buttonsPanel2.Name = "buttonsPanel2";
            this.buttonsPanel2.Opened = true;
            this.buttonsPanel2.SelectedButtonIndex = -1;
            this.buttonsPanel2.ShowCaptionPanel = true;
            this.buttonsPanel2.Size = new System.Drawing.Size(197, 112);
            this.buttonsPanel2.TabIndex = 0;
            this.buttonsPanel2.Title = "View Style";
            // 
            // buttonsPanel3
            // 
            this.buttonsPanel3.AutoScroll = true;
            cbButton21.Enabled = true;
            cbButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton21.Image = global::CategoryButtons.Properties.Resources.left;
            cbButton21.Tag = null;
            cbButton21.Title = "Left";
            cbButton22.Enabled = true;
            cbButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton22.Image = global::CategoryButtons.Properties.Resources.center;
            cbButton22.Tag = null;
            cbButton22.Title = "Center";
            cbButton23.Enabled = true;
            cbButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton23.Image = global::CategoryButtons.Properties.Resources.right;
            cbButton23.Tag = null;
            cbButton23.Title = "Right";
            cbButton24.Enabled = true;
            cbButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            cbButton24.Image = global::CategoryButtons.Properties.Resources.just;
            cbButton24.Tag = null;
            cbButton24.Title = "Justify";
            this.buttonsPanel3.Buttons.AddRange(new heaparessential.Controls.CBButton[] {
            cbButton21,
            cbButton22,
            cbButton23,
            cbButton24});
            this.buttonsPanel3.ButtonsHeight = 24;
            this.buttonsPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel3.Location = new System.Drawing.Point(0, 112);
            this.buttonsPanel3.Name = "buttonsPanel3";
            this.buttonsPanel3.Opened = true;
            this.buttonsPanel3.SelectedButtonIndex = -1;
            this.buttonsPanel3.ShowCaptionPanel = true;
            this.buttonsPanel3.Size = new System.Drawing.Size(197, 112);
            this.buttonsPanel3.TabIndex = 1;
            this.buttonsPanel3.Title = "Text aligment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "CategoryButtons:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ButtonsPanel:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Get selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get selected";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(18, 165);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show caption panel";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryBattons1);
            this.Controls.Add(this.buttonsPanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bevel1);
            this.Name = "Form1";
            this.Text = "Category Buttons";
            this.categoryBattons1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private heaparessential.Controls.Bevel bevel1;
        private System.Windows.Forms.Button button1;
        private heaparessential.Controls.ButtonsPanel buttonsPanel1;
        private heaparessential.Controls.CategoryBattonsPanel categoryBattons1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private heaparessential.Controls.ButtonsPanel buttonsPanel2;
        private heaparessential.Controls.ButtonsPanel buttonsPanel3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

