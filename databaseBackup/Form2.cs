using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;


namespace databaseBackup
{
    public partial class Form2 : Form
    {
        JobSchedule jbs;
        DataBase dtb = DataBase.getInstance();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBoxDataBases.Items.Clear();
            foreach (Database item in dtb.srv.Databases)
            {
                comboBoxDataBases.Items.Add(item.Name);
            }
        }

        private void buttonCreateJob_Click(object sender, EventArgs e)
        {
            if (comboBoxDataBases.SelectedItem == null)
            {
                MessageBox.Show("Нужно выбрать базу данных");
                return;
            }

            Job job = new Job(dtb.srv.JobServer, JobName.Text);
            job.IsEnabled = true;
            job.Create();
            job.ApplyToTargetServer(dtb.serverName);
            JobStep jobStep = new JobStep(job, "auto backups");
            jobStep.SubSystem = AgentSubSystem.PowerShell;
            jobStep.DatabaseName = "dataBaseTest";
            jobStep.OnSuccessAction = StepCompletionAction.GoToNextStep;
            jobStep.OnFailAction = StepCompletionAction.QuitWithFailure;

            //директория бекапов по умолчанию
            string backupDirectory = dtb.srv.BackupDirectory;
            // Вызов диалогового окна для выбора файла
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Присваивание переменной пути до файла
                backupDirectory = folderDlg.SelectedPath;
            }
            //полный бекап
            jobStep.Command = dtb.Backups(comboBoxDataBases.Text, backupDirectory);
            jobStep.Create();
            jbs = new JobSchedule(job, JobName.Text);
            jbs.ActiveStartDate = startDateTimeJob.Value;
            if (radioButtonDaily.Checked)
            {
                jbs.FrequencyTypes = FrequencyTypes.Daily;
                jbs.FrequencySubDayTypes = FrequencySubDayTypes.Once;
                jbs.FrequencyInterval = 1;
                jbs.ActiveStartTimeOfDay = new TimeSpan(daily.Value.Hour, daily.Value.Minute, daily.Value.Second);
            }
            jbs.Create();
            job.AddSharedSchedule(jbs.ID);
        }
    }
}
