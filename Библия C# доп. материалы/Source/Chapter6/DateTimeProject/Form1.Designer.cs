namespace DateTimeProject
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dayNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dayOfWeekLabel = new System.Windows.Forms.Label();
            this.timeOfDayLabel = new System.Windows.Forms.Label();
            this.dayOfYearLabel = new System.Windows.Forms.Label();
            this.dayOfWeekNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Месяц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "День";
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(67, 7);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.yearNumericUpDown.TabIndex = 4;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2008,
            0,
            0,
            0});
            // 
            // monthNumericUpDown
            // 
            this.monthNumericUpDown.Location = new System.Drawing.Point(67, 33);
            this.monthNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.monthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthNumericUpDown.Name = "monthNumericUpDown";
            this.monthNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.monthNumericUpDown.TabIndex = 5;
            this.monthNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // dayNumericUpDown
            // 
            this.dayNumericUpDown.Location = new System.Drawing.Point(67, 59);
            this.dayNumericUpDown.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.dayNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dayNumericUpDown.Name = "dayNumericUpDown";
            this.dayNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.dayNumericUpDown.TabIndex = 6;
            this.dayNumericUpDown.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // minutesNumericUpDown
            // 
            this.minutesNumericUpDown.Location = new System.Drawing.Point(67, 111);
            this.minutesNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutesNumericUpDown.Name = "minutesNumericUpDown";
            this.minutesNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.minutesNumericUpDown.TabIndex = 10;
            this.minutesNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(67, 85);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.hourNumericUpDown.TabIndex = 9;
            this.hourNumericUpDown.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Минуты";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Часы";
            // 
            // dayOfWeekLabel
            // 
            this.dayOfWeekLabel.AutoSize = true;
            this.dayOfWeekLabel.Location = new System.Drawing.Point(172, 9);
            this.dayOfWeekLabel.Name = "dayOfWeekLabel";
            this.dayOfWeekLabel.Size = new System.Drawing.Size(73, 13);
            this.dayOfWeekLabel.TabIndex = 11;
            this.dayOfWeekLabel.Text = "День недели";
            // 
            // timeOfDayLabel
            // 
            this.timeOfDayLabel.AutoSize = true;
            this.timeOfDayLabel.Location = new System.Drawing.Point(172, 61);
            this.timeOfDayLabel.Name = "timeOfDayLabel";
            this.timeOfDayLabel.Size = new System.Drawing.Size(61, 13);
            this.timeOfDayLabel.TabIndex = 12;
            this.timeOfDayLabel.Text = "Время дня";
            // 
            // dayOfYearLabel
            // 
            this.dayOfYearLabel.AutoSize = true;
            this.dayOfYearLabel.Location = new System.Drawing.Point(172, 35);
            this.dayOfYearLabel.Name = "dayOfYearLabel";
            this.dayOfYearLabel.Size = new System.Drawing.Size(60, 13);
            this.dayOfYearLabel.TabIndex = 13;
            this.dayOfYearLabel.Text = "День года";
            // 
            // dayOfWeekNumberLabel
            // 
            this.dayOfWeekNumberLabel.AutoSize = true;
            this.dayOfWeekNumberLabel.Location = new System.Drawing.Point(251, 9);
            this.dayOfWeekNumberLabel.Name = "dayOfWeekNumberLabel";
            this.dayOfWeekNumberLabel.Size = new System.Drawing.Size(99, 13);
            this.dayOfWeekNumberLabel.TabIndex = 14;
            this.dayOfWeekNumberLabel.Text = "номер дня недели";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 203);
            this.Controls.Add(this.dayOfWeekNumberLabel);
            this.Controls.Add(this.dayOfYearLabel);
            this.Controls.Add(this.timeOfDayLabel);
            this.Controls.Add(this.dayOfWeekLabel);
            this.Controls.Add(this.minutesNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dayNumericUpDown);
            this.Controls.Add(this.monthNumericUpDown);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Дата";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dayNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.NumericUpDown monthNumericUpDown;
        private System.Windows.Forms.NumericUpDown dayNumericUpDown;
        private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dayOfWeekLabel;
        private System.Windows.Forms.Label timeOfDayLabel;
        private System.Windows.Forms.Label dayOfYearLabel;
        private System.Windows.Forms.Label dayOfWeekNumberLabel;
    }
}

