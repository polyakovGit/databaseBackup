
namespace databaseBackup
{
    partial class Form2
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
            this.comboBoxDataBases = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateJob = new System.Windows.Forms.Button();
            this.JobName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startDateTimeJob = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.daily = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonDaily = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxDataBases
            // 
            this.comboBoxDataBases.FormattingEnabled = true;
            this.comboBoxDataBases.Location = new System.Drawing.Point(111, 13);
            this.comboBoxDataBases.Name = "comboBoxDataBases";
            this.comboBoxDataBases.Size = new System.Drawing.Size(133, 21);
            this.comboBoxDataBases.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Базы данных";
            // 
            // buttonCreateJob
            // 
            this.buttonCreateJob.Location = new System.Drawing.Point(147, 379);
            this.buttonCreateJob.Name = "buttonCreateJob";
            this.buttonCreateJob.Size = new System.Drawing.Size(117, 23);
            this.buttonCreateJob.TabIndex = 2;
            this.buttonCreateJob.Text = "Создать задание";
            this.buttonCreateJob.UseVisualStyleBackColor = true;
            this.buttonCreateJob.Click += new System.EventHandler(this.buttonCreateJob_Click);
            // 
            // JobName
            // 
            this.JobName.Location = new System.Drawing.Point(114, 47);
            this.JobName.Name = "JobName";
            this.JobName.Size = new System.Drawing.Size(130, 20);
            this.JobName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название задания";
            // 
            // startDateTimeJob
            // 
            this.startDateTimeJob.CustomFormat = "";
            this.startDateTimeJob.Location = new System.Drawing.Point(111, 75);
            this.startDateTimeJob.MinDate = new System.DateTime(2021, 10, 13, 0, 0, 0, 0);
            this.startDateTimeJob.Name = "startDateTimeJob";
            this.startDateTimeJob.Size = new System.Drawing.Size(133, 20);
            this.startDateTimeJob.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата начала";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.daily);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioButtonDaily);
            this.groupBox1.Location = new System.Drawing.Point(12, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расписание бекапов";
            // 
            // daily
            // 
            this.daily.CustomFormat = "HH:mm:ss";
            this.daily.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daily.Location = new System.Drawing.Point(140, 19);
            this.daily.Name = "daily";
            this.daily.ShowUpDown = true;
            this.daily.Size = new System.Drawing.Size(127, 20);
            this.daily.TabIndex = 2;
            this.daily.Value = new System.DateTime(2021, 10, 13, 12, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Время";
            // 
            // radioButtonDaily
            // 
            this.radioButtonDaily.AutoSize = true;
            this.radioButtonDaily.Location = new System.Drawing.Point(6, 19);
            this.radioButtonDaily.Name = "radioButtonDaily";
            this.radioButtonDaily.Size = new System.Drawing.Size(82, 17);
            this.radioButtonDaily.TabIndex = 0;
            this.radioButtonDaily.TabStop = true;
            this.radioButtonDaily.Text = "Ежедневно";
            this.radioButtonDaily.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxEmail);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(12, 219);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(391, 60);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Уведомления";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(135, 19);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(188, 20);
            this.textBoxEmail.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Почта для уведомлений";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxDataBases);
            this.groupBox2.Controls.Add(this.JobName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.startDateTimeJob);
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 120);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 422);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCreateJob);
            this.Name = "Form2";
            this.Text = "Создание задачи";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDataBases;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateJob;
        private System.Windows.Forms.TextBox JobName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDateTimeJob;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker daily;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonDaily;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}