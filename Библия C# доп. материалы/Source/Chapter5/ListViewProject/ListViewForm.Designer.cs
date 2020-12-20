namespace ListViewProject
{
    partial class ListViewForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Test2");
            this.listView1 = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.groupButton = new System.Windows.Forms.Button();
            this.selectedButton = new System.Windows.Forms.Button();
            this.deleteFirstButton = new System.Windows.Forms.Button();
            this.deleteSelectedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(342, 234);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(360, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(103, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Location = new System.Drawing.Point(360, 41);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(103, 23);
            this.groupButton.TabIndex = 2;
            this.groupButton.Text = "Группа";
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // selectedButton
            // 
            this.selectedButton.Location = new System.Drawing.Point(360, 70);
            this.selectedButton.Name = "selectedButton";
            this.selectedButton.Size = new System.Drawing.Size(103, 23);
            this.selectedButton.TabIndex = 3;
            this.selectedButton.Text = "Выделенный";
            this.selectedButton.UseVisualStyleBackColor = true;
            this.selectedButton.Click += new System.EventHandler(this.selectedButton_Click);
            // 
            // deleteFirstButton
            // 
            this.deleteFirstButton.Location = new System.Drawing.Point(360, 223);
            this.deleteFirstButton.Name = "deleteFirstButton";
            this.deleteFirstButton.Size = new System.Drawing.Size(103, 23);
            this.deleteFirstButton.TabIndex = 4;
            this.deleteFirstButton.Text = "Удалить 0-й";
            this.deleteFirstButton.UseVisualStyleBackColor = true;
            this.deleteFirstButton.Click += new System.EventHandler(this.deleteFirstButton_Click);
            // 
            // deleteSelectedButton
            // 
            this.deleteSelectedButton.Location = new System.Drawing.Point(360, 194);
            this.deleteSelectedButton.Name = "deleteSelectedButton";
            this.deleteSelectedButton.Size = new System.Drawing.Size(103, 23);
            this.deleteSelectedButton.TabIndex = 5;
            this.deleteSelectedButton.Text = "Удалить выд";
            this.deleteSelectedButton.UseVisualStyleBackColor = true;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 258);
            this.Controls.Add(this.deleteSelectedButton);
            this.Controls.Add(this.deleteFirstButton);
            this.Controls.Add(this.selectedButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ListViewForm";
            this.Text = "List View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button selectedButton;
        private System.Windows.Forms.Button deleteFirstButton;
        private System.Windows.Forms.Button deleteSelectedButton;
    }
}

