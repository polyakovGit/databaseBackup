using System;
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
using Microsoft.SqlServer.Management.Smo.Mail;
using Microsoft.SqlServer.Management.Common;
using MimeKit;
using MailKit.Net.Smtp;


namespace databaseBackup
{
    public partial class Form1 : Form
    {
        Form2 form2;
        DataBase dtb = DataBase.getInstance();
        public Form1()
        {
            InitializeComponent();
            comboBoxNameServer.SelectedItem = comboBoxNameServer.Items[0];
            comboBoxAuthentication.SelectedItem = comboBoxAuthentication.Items[0];
            form2 = new Form2();
        }
        void addAllDatabasesToLists()
        {
            comboBoxdataBasesforBackup.Items.Clear();
            comboBoxdataBasesforRestore.Items.Clear();
            foreach (Database item in dtb.srv.Databases)
            {
                comboBoxdataBasesforBackup.Items.Add(item.Name);
                comboBoxdataBasesforRestore.Items.Add(item.Name);
            }
        }
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string Server = comboBoxNameServer.Text;
                dtb.serverName = Server;
                if (comboBoxAuthentication.SelectedIndex == 0)
                {
                    dtb.srv = new Server(Server);
                }
                else
                {
                    string NameUser = textBoxNameUser.Text;
                    string Pass = textBoxPass.Text;
                    dtb.srvConn = new ServerConnection(Server, NameUser, Pass);
                    dtb.srv = new Server(dtb.srvConn);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка соединения");
            }
            MessageBox.Show("Соединение установлено");
            addAllDatabasesToLists();
            buttonNewTask.Enabled = true;
            RefreshJobs();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string databaseName = textBoxNameBase.Text;
            var bk = new Backup();
            if (radioButtonFullBackup.Checked) { 
                bk.Action = BackupActionType.Database;
                bk.BackupSetDescription = "Full backup testdb";
                bk.BackupSetName = "full backup";
            }
            if (radioButtonDiffBackup.Checked)
            {
                bk.Action = BackupActionType.Database;
                bk.Incremental = true;//diff backup
                bk.BackupSetDescription = "Diff backup testdb";
                bk.BackupSetName = "diff backup";
            }
            if (radioButtonLogBackup.Checked)
            {
                bk.Action = BackupActionType.Log;//log backup
                bk.BackupSetDescription = "Log backup testdb";
                bk.BackupSetName = "log backup";
                //bk.LogTruncation = BackupTruncateLogType.Truncate;
            }
            //bk.CompressionOption = BackupCompressionOptions.On;//compression
            if (comboBoxdataBasesforBackup.SelectedItem != null)
                bk.Database = comboBoxdataBasesforBackup.SelectedItem.ToString();
            bk.Incremental = false;
            if (checkBoxExpirationDate.Checked)
                bk.ExpirationDate = monthCalendar1.SelectionStart;//ssms default language en 
            string path = string.Format($"{databaseName}_" +
                $"{DateTime.Now.ToString("dd.MM.yyyy_HH-mm-ss")}" +
                $".bak");
            BackupDeviceItem bdi = new BackupDeviceItem(path, DeviceType.File);
            DateTime dt = DateTime.Now;
            bk.Devices.Add(bdi);
            bk.SqlBackup(dtb.srv);
            bk.Devices.Remove(bdi);
        }
        private void RestorePercent_Completed(object sender, PercentCompleteEventArgs e)
        {
            progressBar1.Invoke((MethodInvoker)delegate
            {
                progressBar1.Value = e.Percent;
                progressBar1.Update();
            });
            label5.Invoke((MethodInvoker)delegate
            {
                label5.Text = $"{e.Percent}%";
            });
            progressBar1.Value = 0;
            progressBar1.Update();
            label5.Text = "0%";
        }
        void Restore_Completed(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
        }
        private void buttonRecovery_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                string filePath = OPF.FileName;
                string databaseName = textBoxNewDatabase.Text;

                Restore restore = new Restore();
                restore.Action = RestoreActionType.Database;
                restore.NoRecovery = false;

                BackupDeviceItem bdi = new BackupDeviceItem(filePath, DeviceType.File);
                Database currentDb = null;
                restore.Complete += Restore_Completed;
                restore.PercentComplete += RestorePercent_Completed;
                restore.ReplaceDatabase = true;
                if (radioButtonToOldDatabase.Checked)
                {
                    if (comboBoxdataBasesforRestore.Text != null)
                    {
                        string db = comboBoxdataBasesforRestore.Text;
                        currentDb = dtb.srv.Databases[db];
                        if (currentDb != null)
                        {
                            dtb.srv.KillAllProcesses(currentDb.Name);
                        }
                        restore.Database = db;
                        restore.Devices.Add(bdi);
                        restore.SqlRestore(dtb.srv);
                        addAllDatabasesToLists();
                    }
                }
                else
                {
                    Database newDb = new Database(dtb.srv, textBoxNewDatabase.Text);
                    restore.Database = newDb.Name;
                    restore.Devices.Add(bdi);
                    restore.SqlRestoreAsync(dtb.srv);
                    addAllDatabasesToLists();
                }
            }
        }

        private void comboBoxdataBasesforBackup_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxNameBase.Text = comboBoxdataBasesforBackup.SelectedItem.ToString();
        }

        private void radioButtonToOldDatabase_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonToNewDatabase.Checked = !radioButtonToOldDatabase.Checked;
        }

        private void radioButtonToNewDatabase_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonToOldDatabase.Checked = !radioButtonToNewDatabase.Checked;
        }

        private void comboBoxAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAuthentication.SelectedIndex == 0)
                textBoxNameUser.Enabled = textBoxPass.Enabled = false;
            else textBoxNameUser.Enabled = textBoxPass.Enabled = true;
        }

        public void RefreshJobs()
        {
            dataGridView1.Rows.Clear();
            foreach (Job item in dtb.srv.JobServer.Jobs)
                dataGridView1.Rows.Add(item.JobID, item.Name, item.IsEnabled, item.DateCreated);
        }

        private void buttonNewJob_Click(object sender, EventArgs e)
        {
            form2.ShowDialog();
            RefreshJobs();
        }

        private void buttonDeleteJob_Click(object sender, EventArgs e)
        {
            string nameJob = (string)dataGridView1.CurrentRow.Cells["Column2"].Value;
            Job job = dtb.srv.JobServer.Jobs[nameJob];
            job.Drop();
            RefreshJobs();
        }

        private void buttonStartJob_Click(object sender, EventArgs e)
        {
            string nameJob = (string)dataGridView1.CurrentRow.Cells["Column2"].Value;
            Job job = dtb.srv.JobServer.Jobs[nameJob];
            job.IsEnabled = true;
            job.Alter();
            job.Refresh();
            RefreshJobs();
        }

        private void buttonStopJob_Click(object sender, EventArgs e)
        {
            string nameJob = (string)dataGridView1.CurrentRow.Cells["Column2"].Value;
            Job job = dtb.srv.JobServer.Jobs[nameJob];
            job.IsEnabled = false;
            job.Alter();
            job.Refresh();
            RefreshJobs();
        }


        //для ручного бекапа 
        //public async Task SendMessage(string toEmail, string title, string message)
        //{
        //    MimeMessage myMessage = new MimeMessage();
        //    myMessage.From.Add(new MailboxAddress("testNameFrom","polyakovmymail@gmail.com"));
        //    myMessage.To.Add(new MailboxAddress("testNameTo",toEmail));
        //    myMessage.Subject = title;
        //    myMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
        //    {
        //        Text = message
        //    };
        //    using (SmtpClient mySmtpClient=new SmtpClient())
        //    {
        //        await mySmtpClient.ConnectAsync("smtp.gmail.com", 465, false);
        //        await mySmtpClient.AuthenticateAsync("polyakovmymail@gmail.com", "passValue");
        //        await mySmtpClient.SendAsync(myMessage);
        //        await mySmtpClient.DisconnectAsync(true);
        //    }
        //}
    }
}
