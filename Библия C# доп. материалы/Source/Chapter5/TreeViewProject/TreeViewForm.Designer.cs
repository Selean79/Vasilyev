namespace TreeViewProject
{
    partial class TreeViewForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Дочерний элемент 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Дочерний элемент 2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Корневой элемент 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Дочерний элемент3");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Корневой элемент 2", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.addChildButton = new System.Windows.Forms.Button();
            this.addRootButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewTreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HotTracking = true;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Дочерний элемент 1";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Дочерний элемент 2";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Корневой элемент 1";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Дочерний элемент3";
            treeNode5.Name = "Node3";
            treeNode5.Text = "Корневой элемент 2";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(351, 258);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCollapse);
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            // 
            // addChildButton
            // 
            this.addChildButton.Location = new System.Drawing.Point(369, 41);
            this.addChildButton.Name = "addChildButton";
            this.addChildButton.Size = new System.Drawing.Size(129, 23);
            this.addChildButton.TabIndex = 1;
            this.addChildButton.Text = "Добавить дочерний";
            this.addChildButton.UseVisualStyleBackColor = true;
            this.addChildButton.Click += new System.EventHandler(this.addChildButton_Click);
            // 
            // addRootButton
            // 
            this.addRootButton.Location = new System.Drawing.Point(369, 12);
            this.addRootButton.Name = "addRootButton";
            this.addRootButton.Size = new System.Drawing.Size(129, 23);
            this.addRootButton.TabIndex = 2;
            this.addRootButton.Text = "Добавить корневой";
            this.addRootButton.UseVisualStyleBackColor = true;
            this.addRootButton.Click += new System.EventHandler(this.addRootButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(369, 70);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 23);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewTreeButton
            // 
            this.viewTreeButton.Location = new System.Drawing.Point(369, 247);
            this.viewTreeButton.Name = "viewTreeButton";
            this.viewTreeButton.Size = new System.Drawing.Size(129, 23);
            this.viewTreeButton.TabIndex = 4;
            this.viewTreeButton.Text = "Просмотр дерева";
            this.viewTreeButton.UseVisualStyleBackColor = true;
            this.viewTreeButton.Click += new System.EventHandler(this.viewTreeButton_Click);
            // 
            // TreeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 282);
            this.Controls.Add(this.viewTreeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addRootButton);
            this.Controls.Add(this.addChildButton);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TreeViewForm";
            this.Text = "Дерево";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button addChildButton;
        private System.Windows.Forms.Button addRootButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button viewTreeButton;
    }
}

