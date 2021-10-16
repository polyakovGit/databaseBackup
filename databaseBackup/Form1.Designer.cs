
namespace databaseBackup
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelNameServer = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxAuthentication = new System.Windows.Forms.ComboBox();
            this.comboBoxNameServer = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxNameBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxExpirationDate = new System.Windows.Forms.CheckBox();
            this.comboBoxdataBasesforBackup = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxNewDatabase = new System.Windows.Forms.TextBox();
            this.buttonRecovery = new System.Windows.Forms.Button();
            this.radioButtonToNewDatabase = new System.Windows.Forms.RadioButton();
            this.radioButtonToOldDatabase = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxdataBasesforRestore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonNewTask = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.ForeColor = System.Drawing.Color.Green;
            this.buttonConnect.Location = new System.Drawing.Point(63, 148);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(156, 24);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Подключиться";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.ForeColor = System.Drawing.Color.Green;
            this.buttonCopy.Location = new System.Drawing.Point(46, 150);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(156, 24);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.Text = "Резервное копирование";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelHelp
            // 
            this.labelHelp.AutoSize = true;
            this.labelHelp.ForeColor = System.Drawing.Color.Maroon;
            this.labelHelp.Location = new System.Drawing.Point(44, 7);
            this.labelHelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Size = new System.Drawing.Size(208, 39);
            this.labelHelp.TabIndex = 2;
            this.labelHelp.Text = "Для работы с данной программой вам \r\n     необходимо ввести данные для\r\n         " +
    "  подключения к Sql Server";
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameUser.Location = new System.Drawing.Point(117, 84);
            this.textBoxNameUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(200, 21);
            this.textBoxNameUser.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(117, 115);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(200, 21);
            this.textBoxPass.TabIndex = 6;
            // 
            // labelNameServer
            // 
            this.labelNameServer.AutoSize = true;
            this.labelNameServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameServer.ForeColor = System.Drawing.Color.Maroon;
            this.labelNameServer.Location = new System.Drawing.Point(3, 63);
            this.labelNameServer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameServer.Name = "labelNameServer";
            this.labelNameServer.Size = new System.Drawing.Size(77, 13);
            this.labelNameServer.TabIndex = 7;
            this.labelNameServer.Text = "Имя сервера:";
            // 
            // labelNameUser
            // 
            this.labelNameUser.AutoSize = true;
            this.labelNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameUser.ForeColor = System.Drawing.Color.Maroon;
            this.labelNameUser.Location = new System.Drawing.Point(3, 89);
            this.labelNameUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameUser.Name = "labelNameUser";
            this.labelNameUser.Size = new System.Drawing.Size(106, 13);
            this.labelNameUser.TabIndex = 9;
            this.labelNameUser.Text = "Имя пользователя:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPass.ForeColor = System.Drawing.Color.Maroon;
            this.labelPass.Location = new System.Drawing.Point(3, 120);
            this.labelPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(48, 13);
            this.labelPass.TabIndex = 10;
            this.labelPass.Text = "Пароль:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxAuthentication);
            this.groupBox1.Controls.Add(this.comboBoxNameServer);
            this.groupBox1.Controls.Add(this.textBoxNameUser);
            this.groupBox1.Controls.Add(this.labelPass);
            this.groupBox1.Controls.Add(this.labelNameUser);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.labelNameServer);
            this.groupBox1.Controls.Add(this.buttonConnect);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Green;
            this.groupBox1.Location = new System.Drawing.Point(11, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 186);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(3, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Аутентификация:";
            // 
            // comboBoxAuthentication
            // 
            this.comboBoxAuthentication.FormattingEnabled = true;
            this.comboBoxAuthentication.Items.AddRange(new object[] {
            "Проверка Windows",
            "Проверка SQL Server"});
            this.comboBoxAuthentication.Location = new System.Drawing.Point(117, 27);
            this.comboBoxAuthentication.Name = "comboBoxAuthentication";
            this.comboBoxAuthentication.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAuthentication.TabIndex = 18;
            this.comboBoxAuthentication.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthentication_SelectedIndexChanged);
            // 
            // comboBoxNameServer
            // 
            this.comboBoxNameServer.FormattingEnabled = true;
            this.comboBoxNameServer.Items.AddRange(new object[] {
            "XENO-B-STATION"});
            this.comboBoxNameServer.Location = new System.Drawing.Point(117, 58);
            this.comboBoxNameServer.Name = "comboBoxNameServer";
            this.comboBoxNameServer.Size = new System.Drawing.Size(199, 21);
            this.comboBoxNameServer.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.textBoxNameBase);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.checkBoxExpirationDate);
            this.groupBox2.Controls.Add(this.buttonCopy);
            this.groupBox2.Controls.Add(this.comboBoxdataBasesforBackup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(342, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(456, 212);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Резервное копирование";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(247, 38);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
            // 
            // textBoxNameBase
            // 
            this.textBoxNameBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameBase.Location = new System.Drawing.Point(25, 115);
            this.textBoxNameBase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameBase.Name = "textBoxNameBase";
            this.textBoxNameBase.Size = new System.Drawing.Size(198, 21);
            this.textBoxNameBase.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Базы данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(43, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "имя базы данных\r\nдля  резервного копирования";
            // 
            // checkBoxExpirationDate
            // 
            this.checkBoxExpirationDate.AutoSize = true;
            this.checkBoxExpirationDate.Location = new System.Drawing.Point(247, 16);
            this.checkBoxExpirationDate.Name = "checkBoxExpirationDate";
            this.checkBoxExpirationDate.Size = new System.Drawing.Size(100, 17);
            this.checkBoxExpirationDate.TabIndex = 19;
            this.checkBoxExpirationDate.Text = "срок хранения";
            this.checkBoxExpirationDate.UseVisualStyleBackColor = true;
            // 
            // comboBoxdataBasesforBackup
            // 
            this.comboBoxdataBasesforBackup.FormattingEnabled = true;
            this.comboBoxdataBasesforBackup.Location = new System.Drawing.Point(85, 17);
            this.comboBoxdataBasesforBackup.Name = "comboBoxdataBasesforBackup";
            this.comboBoxdataBasesforBackup.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdataBasesforBackup.TabIndex = 18;
            this.comboBoxdataBasesforBackup.SelectedIndexChanged += new System.EventHandler(this.comboBoxdataBasesforBackup_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.progressBar1);
            this.groupBox3.Controls.Add(this.textBoxNewDatabase);
            this.groupBox3.Controls.Add(this.buttonRecovery);
            this.groupBox3.Controls.Add(this.radioButtonToNewDatabase);
            this.groupBox3.Controls.Add(this.radioButtonToOldDatabase);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxdataBasesforRestore);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(814, 28);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(298, 208);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Восстановление базы данных";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(44, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(211, 23);
            this.progressBar1.TabIndex = 27;
            // 
            // textBoxNewDatabase
            // 
            this.textBoxNewDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewDatabase.Location = new System.Drawing.Point(156, 65);
            this.textBoxNewDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewDatabase.Name = "textBoxNewDatabase";
            this.textBoxNewDatabase.Size = new System.Drawing.Size(129, 21);
            this.textBoxNewDatabase.TabIndex = 26;
            // 
            // buttonRecovery
            // 
            this.buttonRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecovery.ForeColor = System.Drawing.Color.Green;
            this.buttonRecovery.Location = new System.Drawing.Point(67, 170);
            this.buttonRecovery.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRecovery.Name = "buttonRecovery";
            this.buttonRecovery.Size = new System.Drawing.Size(156, 24);
            this.buttonRecovery.TabIndex = 16;
            this.buttonRecovery.Text = "Выбрать файл";
            this.buttonRecovery.UseVisualStyleBackColor = true;
            this.buttonRecovery.Click += new System.EventHandler(this.buttonRecovery_Click);
            // 
            // radioButtonToNewDatabase
            // 
            this.radioButtonToNewDatabase.AutoSize = true;
            this.radioButtonToNewDatabase.Location = new System.Drawing.Point(156, 20);
            this.radioButtonToNewDatabase.Name = "radioButtonToNewDatabase";
            this.radioButtonToNewDatabase.Size = new System.Drawing.Size(85, 17);
            this.radioButtonToNewDatabase.TabIndex = 25;
            this.radioButtonToNewDatabase.TabStop = true;
            this.radioButtonToNewDatabase.Text = "В новую БД";
            this.radioButtonToNewDatabase.UseVisualStyleBackColor = true;
            this.radioButtonToNewDatabase.CheckedChanged += new System.EventHandler(this.radioButtonToNewDatabase_CheckedChanged);
            // 
            // radioButtonToOldDatabase
            // 
            this.radioButtonToOldDatabase.AutoSize = true;
            this.radioButtonToOldDatabase.Checked = true;
            this.radioButtonToOldDatabase.Location = new System.Drawing.Point(8, 21);
            this.radioButtonToOldDatabase.Name = "radioButtonToOldDatabase";
            this.radioButtonToOldDatabase.Size = new System.Drawing.Size(132, 17);
            this.radioButtonToOldDatabase.TabIndex = 24;
            this.radioButtonToOldDatabase.TabStop = true;
            this.radioButtonToOldDatabase.Text = "В существующую БД";
            this.radioButtonToOldDatabase.UseVisualStyleBackColor = true;
            this.radioButtonToOldDatabase.CheckedChanged += new System.EventHandler(this.radioButtonToOldDatabase_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(48, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Выберите файл для восстановления";
            // 
            // comboBoxdataBasesforRestore
            // 
            this.comboBoxdataBasesforRestore.FormattingEnabled = true;
            this.comboBoxdataBasesforRestore.Location = new System.Drawing.Point(8, 65);
            this.comboBoxdataBasesforRestore.Name = "comboBoxdataBasesforRestore";
            this.comboBoxdataBasesforRestore.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdataBasesforRestore.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Базы данных";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonNewTask);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(18, 258);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(685, 219);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расписание копирования";
            // 
            // buttonNewTask
            // 
            this.buttonNewTask.Enabled = false;
            this.buttonNewTask.Location = new System.Drawing.Point(504, 32);
            this.buttonNewTask.Name = "buttonNewTask";
            this.buttonNewTask.Size = new System.Drawing.Size(137, 34);
            this.buttonNewTask.TabIndex = 1;
            this.buttonNewTask.Text = "Создать задание";
            this.buttonNewTask.UseVisualStyleBackColor = true;
            this.buttonNewTask.Click += new System.EventHandler(this.buttonNewJob_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(5, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(453, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "IsEnabled";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "DateCreated";
            this.Column4.Name = "Column4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 520);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelHelp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Копирование/восстановление";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.TextBox textBoxNameUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelNameServer;
        private System.Windows.Forms.Label labelNameUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNameBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRecovery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxNameServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxdataBasesforBackup;
        private System.Windows.Forms.CheckBox checkBoxExpirationDate;
        private System.Windows.Forms.ComboBox comboBoxdataBasesforRestore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton radioButtonToOldDatabase;
        private System.Windows.Forms.RadioButton radioButtonToNewDatabase;
        private System.Windows.Forms.TextBox textBoxNewDatabase;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAuthentication;
        private System.Windows.Forms.Button buttonNewTask;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label6;
    }
}

