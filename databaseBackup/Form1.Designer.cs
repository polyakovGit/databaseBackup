
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
            this.components = new System.ComponentModel.Container();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelHelp = new System.Windows.Forms.Label();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelNameServer = new System.Windows.Forms.Label();
            this.labelNameUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNameServer = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxNameBase = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxLife = new System.Windows.Forms.CheckBox();
            this.comboBoxdataBasesforBackup = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxdataBasesforRestore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRecovery = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSaveInterval = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.radioButtonToOldDatabase = new System.Windows.Forms.RadioButton();
            this.radioButtonToNewDatabase = new System.Windows.Forms.RadioButton();
            this.textBoxNewDatabase = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.ForeColor = System.Drawing.Color.Green;
            this.buttonConnect.Location = new System.Drawing.Point(62, 91);
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
            this.buttonCopy.Location = new System.Drawing.Point(253, 125);
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
            this.textBoxNameUser.Location = new System.Drawing.Point(118, 38);
            this.textBoxNameUser.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(200, 21);
            this.textBoxNameUser.TabIndex = 5;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(118, 61);
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
            this.labelNameServer.Location = new System.Drawing.Point(33, 20);
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
            this.labelNameUser.Location = new System.Drawing.Point(4, 42);
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
            this.labelPass.Location = new System.Drawing.Point(60, 65);
            this.labelPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(48, 13);
            this.labelPass.TabIndex = 10;
            this.labelPass.Text = "Пароль:";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(2, 77);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(322, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры подключения";
            // 
            // comboBoxNameServer
            // 
            this.comboBoxNameServer.FormattingEnabled = true;
            this.comboBoxNameServer.Items.AddRange(new object[] {
            "XENO-B-STATION\\SQLEXPRESS"});
            this.comboBoxNameServer.Location = new System.Drawing.Point(118, 12);
            this.comboBoxNameServer.Name = "comboBoxNameServer";
            this.comboBoxNameServer.Size = new System.Drawing.Size(199, 21);
            this.comboBoxNameServer.TabIndex = 17;
            this.comboBoxNameServer.SelectedIndexChanged += new System.EventHandler(this.comboBoxNameServer_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.textBoxNameBase);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonCopy);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBoxLife);
            this.groupBox2.Controls.Add(this.comboBoxdataBasesforBackup);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.Green;
            this.groupBox2.Location = new System.Drawing.Point(342, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(456, 247);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Резервное копирование";
            // 
            // textBoxNameBase
            // 
            this.textBoxNameBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameBase.Location = new System.Drawing.Point(232, 96);
            this.textBoxNameBase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNameBase.Name = "textBoxNameBase";
            this.textBoxNameBase.Size = new System.Drawing.Size(198, 21);
            this.textBoxNameBase.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(217, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "имя базы данных, с которой\r\nнужно произвести резервное копирования";
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
            // checkBoxLife
            // 
            this.checkBoxLife.AutoSize = true;
            this.checkBoxLife.Location = new System.Drawing.Point(8, 46);
            this.checkBoxLife.Name = "checkBoxLife";
            this.checkBoxLife.Size = new System.Drawing.Size(100, 17);
            this.checkBoxLife.TabIndex = 19;
            this.checkBoxLife.Text = "срок хранения";
            this.checkBoxLife.UseVisualStyleBackColor = true;
            this.checkBoxLife.CheckedChanged += new System.EventHandler(this.checkBoxLife_CheckedChanged);
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
            this.groupBox3.Controls.Add(this.textBoxNewDatabase);
            this.groupBox3.Controls.Add(this.buttonRecovery);
            this.groupBox3.Controls.Add(this.radioButtonToNewDatabase);
            this.groupBox3.Controls.Add(this.radioButtonToOldDatabase);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBoxdataBasesforRestore);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.Green;
            this.groupBox3.Location = new System.Drawing.Point(802, 77);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(298, 208);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Восстановление базы данных";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSaveInterval);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(2, 427);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(318, 83);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Расписание копирования";
            // 
            // buttonSaveInterval
            // 
            this.buttonSaveInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveInterval.ForeColor = System.Drawing.Color.Green;
            this.buttonSaveInterval.Location = new System.Drawing.Point(78, 55);
            this.buttonSaveInterval.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSaveInterval.Name = "buttonSaveInterval";
            this.buttonSaveInterval.Size = new System.Drawing.Size(156, 24);
            this.buttonSaveInterval.TabIndex = 17;
            this.buttonSaveInterval.Text = "Сохранить";
            this.buttonSaveInterval.UseVisualStyleBackColor = true;
            this.buttonSaveInterval.Click += new System.EventHandler(this.buttonSaveInterval_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Каждый час",
            "Каждые 3 часа",
            "Каждые 6 часов",
            "Каждые 12 часов",
            "Каждый день",
            "Каждую неделю",
            "Каждый месяц"});
            this.comboBox1.Location = new System.Drawing.Point(78, 17);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Выберите интервал";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(11, 65);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 17;
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
            // textBoxNewDatabase
            // 
            this.textBoxNewDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewDatabase.Location = new System.Drawing.Point(156, 65);
            this.textBoxNewDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNewDatabase.Name = "textBoxNewDatabase";
            this.textBoxNewDatabase.Size = new System.Drawing.Size(129, 21);
            this.textBoxNewDatabase.TabIndex = 26;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonRecovery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonSaveInterval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboBoxNameServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxdataBasesforBackup;
        private System.Windows.Forms.CheckBox checkBoxLife;
        private System.Windows.Forms.ComboBox comboBoxdataBasesforRestore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.RadioButton radioButtonToOldDatabase;
        private System.Windows.Forms.RadioButton radioButtonToNewDatabase;
        private System.Windows.Forms.TextBox textBoxNewDatabase;
    }
}

