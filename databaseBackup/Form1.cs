﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;
using Microsoft.SqlServer.Management.Common;
using System.Data.Sql;
using System.Globalization;

namespace databaseBackup
{
    public partial class Form1 : Form
    {
        ServerConnection srvConn;
        public Server srv;

        //Создание объекта класса
        //BD bD = BD.getInstance();
        //File file = new File();
        public Form1()
        {
            InitializeComponent();
            comboBoxNameServer.SelectedItem = comboBoxNameServer.Items[0];
            //string[] Parameters = file.ReadFileParametersBD();
            //textBoxNameServer.Text = Parameters[0];
            //textBoxNameUser.Text = Parameters[1];
            //textBoxPass.Text = Parameters[2];
            //textBoxNameBase.Text = Parameters[3];
            ////Вызов метода подключения к базе данных, который находится в классе BD
            //bD.Connection(Parameters[0], Parameters[1], Parameters[2]);
            //timer1.Interval = 3600000;
            //timer1.Start();
        }
        //добавить во все списки существующие базы данных
        void addAllDatabasesToLists()
        {
            comboBoxdataBasesforBackup.Items.Clear();
            comboBoxdataBasesforRestore.Items.Clear();
            foreach (Database item in srv.Databases)
            {
                comboBoxdataBasesforBackup.Items.Add(item.Name);
                comboBoxdataBasesforRestore.Items.Add(item.Name);
            }
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            //Считывание значений с textBoxs
            string Server = comboBoxNameServer.Text;
            string NameUser = textBoxNameUser.Text;
            string Pass = textBoxPass.Text;
            srvConn = new ServerConnection(Server, NameUser, Pass);
            srv = new Server(srvConn);
            addAllDatabasesToLists();
            ////Вызов метода подключения к базе данных, который находится в классе BD
            //bD.Connection(Server, NameUser, Pass);
        }
        // Обработчик нажатия на кнопку Резервное копирование
        public void checkCommand(int state)
        {
            switch (state)
            {
                case 0:
                    MessageBox.Show("Резервное копирование завершено");
                    break;
                case 1:
                    MessageBox.Show("Ошибка резервного копирования");
                    break;
                case 2:
                    MessageBox.Show("Вы не подключены к Sql Server");
                    break;
            }
        }
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            var bk = new Backup();
            bk.Action = BackupActionType.Database;
            bk.BackupSetDescription = "Full backup testdb";
            bk.BackupSetName = "full backup";
            if (comboBoxdataBasesforBackup.SelectedItem != null)
                bk.Database = comboBoxdataBasesforBackup.SelectedItem.ToString();
            bk.Incremental = false;
            if (checkBoxLife.Checked)
            {
                bk.ExpirationDate = monthCalendar1.SelectionStart;
                //я не знаю почему здесь путается день и месяц

                //bk.ExpirationDate = new DateTime(
                //    monthCalendar1.SelectionStart.Year,
                //     monthCalendar1.SelectionStart.Month,
                //     monthCalendar1.SelectionStart.Day);
            }
            BackupDeviceItem bdi = null;
            DateTime dt = DateTime.Now;
            string path = "";
            path = string.Format($"{textBoxNameBase.Text}_" +
                $"{DateTime.Now.ToString("dd.MM.yyyy_HH-mm-ss")}" +
                $".bak");
            bdi = new BackupDeviceItem(path, DeviceType.File);
            bk.Devices.Add(bdi);
            bk.SqlBackup(srv);
            bk.Devices.Remove(bdi);
            //    // Считывание значения из textBox
            //    string NameBase = textBoxNameBase.Text;
            //    // Вызов диалогового окна для выбора файла
            //    FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            //    folderDlg.ShowNewFolderButton = true;
            //    DialogResult result = folderDlg.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        // Присваивание переменной пути до файла
            //        string Directory = folderDlg.SelectedPath;
            //        // Обработчик исходов резервного копирования
            //        checkCommand(bD.Backups(NameBase, Directory));
            //    }
        }
        // Обработчик нажатия на кнопку Выбрать файл
        private void buttonRecovery_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Restore restore = new Restore();
                restore.Action = RestoreActionType.Database;
                restore.NoRecovery = false;
                string path = openFileDialog1.FileName;
                BackupDeviceItem bdi = new BackupDeviceItem(path, DeviceType.File);
                Database currentDb = null;
                restore.ReplaceDatabase = true;
                if (radioButtonToOldDatabase.Checked)
                {
                    if (comboBoxdataBasesforRestore.Text != null)
                    {
                        string db = comboBoxdataBasesforRestore.Text;
                        currentDb = srv.Databases[db];
                        if (currentDb != null)
                        {
                            srv.KillAllProcesses(currentDb.Name);
                        }
                        restore.Database = db;
                        restore.Devices.Add(bdi);
                        restore.SqlRestore(srv);
                        addAllDatabasesToLists();
                    }
                }
                else
                {
                    Database newDb = new Database(srv, textBoxNewDatabase.Text);
                    restore.Database = newDb.Name;
                    restore.Devices.Add(bdi);
                    restore.SqlRestoreAsync(srv);
                    addAllDatabasesToLists();
                }
            }
        }
        //// Открытие диалогового окна
        //OpenFileDialog OPF = new OpenFileDialog();
        //if (OPF.ShowDialog() == DialogResult.OK)
        //{
        //    // Контроль выбора файла формата .bak
        //    if (OPF.FileName.Substring(OPF.FileName.Length - 3, 3) != "bak")
        //    {
        //        MessageBox.Show("Вы не выбрали .bak файл");
        //    }
        //    else
        //    {
        //        // Отработка метода восстановления базы данных и возвращения исхода
        //        checkCommand(bD.Recovery(OPF.FileName,textBoxNameBase.Text));
        //    }
        //}
        private void buttonSaveInterval_Click(object sender, EventArgs e)
        {
            //string[] Parameters = file.ReadFileParametersBD();
            //bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //file.WriteFileIntervalSave(comboBox1.SelectedIndex, DateTime.Now);
        }
        public void PlanCopy()
        {
            //string[] ParametersInterval = file.ReadFileIntervalSave();
            //string[] Parameters = file.ReadFileParametersBD();
            //TimeSpan interval = DateTime.Now.Subtract(DateTime.Parse(ParametersInterval[1]));
            //switch (int.Parse(ParametersInterval[0]))
            //{
            //    case 0:
            //        if (interval >= TimeSpan.FromHours(1))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //    case 1:
            //        if (interval >= TimeSpan.FromHours(3))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //    case 2:
            //        if (interval >= TimeSpan.FromHours(6))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //    case 3:
            //        if (interval >= TimeSpan.FromHours(12))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //    case 4:
            //        if (interval >= TimeSpan.FromDays(1))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //    case 5:
            //        if (interval >= TimeSpan.FromDays(7))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //    case 6:
            //        if (interval >= TimeSpan.FromDays(30))
            //        {
            //            bD.Backups(Parameters[3], Application.StartupPath.ToString());
            //            file.WriteFileIntervalSave(0, DateTime.Now);
            //        }
            //        break;
            //}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            PlanCopy();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxLife_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxdataBasesforBackup_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNameBase.Text = comboBoxdataBasesforBackup.SelectedItem.ToString();
        }

        private void comboBoxNameServer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonToOldDatabase_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonToNewDatabase.Checked = !radioButtonToOldDatabase.Checked;
        }

        private void radioButtonToNewDatabase_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonToOldDatabase.Checked = !radioButtonToNewDatabase.Checked;
        }
    }
}
