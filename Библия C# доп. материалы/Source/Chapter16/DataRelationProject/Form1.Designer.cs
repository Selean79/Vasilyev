namespace DataRelationProject
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
            this.peopleDataGridView = new System.Windows.Forms.DataGridView();
            this.addressDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // peopleDataGridView
            // 
            this.peopleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleDataGridView.Location = new System.Drawing.Point(11, 11);
            this.peopleDataGridView.Name = "peopleDataGridView";
            this.peopleDataGridView.Size = new System.Drawing.Size(552, 144);
            this.peopleDataGridView.TabIndex = 0;
            // 
            // addressDataGridView
            // 
            this.addressDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addressDataGridView.Location = new System.Drawing.Point(11, 167);
            this.addressDataGridView.Name = "addressDataGridView";
            this.addressDataGridView.Size = new System.Drawing.Size(551, 139);
            this.addressDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Узнать адрес";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(328, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Узнать жителя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 347);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressDataGridView);
            this.Controls.Add(this.peopleDataGridView);
            this.Name = "Form1";
            this.Text = "Связанные таблицы";
            ((System.ComponentModel.ISupportInitialize)(this.peopleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView peopleDataGridView;
        private System.Windows.Forms.DataGridView addressDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

