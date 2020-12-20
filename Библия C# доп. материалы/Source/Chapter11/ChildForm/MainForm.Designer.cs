namespace ChildForm
{
    partial class MainForm
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
            this.addPersonButton = new System.Windows.Forms.Button();
            this.personsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(13, 229);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(107, 23);
            this.addPersonButton.TabIndex = 0;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // personsListView
            // 
            this.personsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.personsListView.FullRowSelect = true;
            this.personsListView.Location = new System.Drawing.Point(12, 12);
            this.personsListView.Name = "personsListView";
            this.personsListView.Size = new System.Drawing.Size(420, 205);
            this.personsListView.TabIndex = 1;
            this.personsListView.UseCompatibleStateImageBehavior = false;
            this.personsListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя";
            this.columnHeader1.Width = 162;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Фамилия";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Возраст";
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(311, 229);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(121, 23);
            this.editPersonButton.TabIndex = 2;
            this.editPersonButton.Text = "Редактировать";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 264);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.personsListView);
            this.Controls.Add(this.addPersonButton);
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.ListView personsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button editPersonButton;
    }
}

