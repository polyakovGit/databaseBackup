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
using Microsoft.SqlServer.Management.Smo.Mail;


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

            ////mailAcc example for send
            //SqlMail sm = dtb.srv.Mail;
            //MailAccount ma = default(MailAccount);
            //Random rand = new Random();

            //string mailAccountUniqueName = "UniqueName" + rand.Next() % 10000;
            //ma = new MailAccount(sm, mailAccountUniqueName, "AdventureWorks2012 Automated Mailer",
            //                    "Mail account for administrative e-mail.", "dba@Adventure-Works.com");
            //ma.Create();
            
            //string alertName,operatorName,operatorMail; //"textName"

            //if (textBoxNotificationName.Text == null)
            //    alertName = "myalertName";
            //else alertName = textBoxNotificationName.Text;

            //if (textBoxNameOperator.Text == null)
            //    operatorName = "textName";
            //else operatorName = textBoxNameOperator.Text;

            //if (textBoxEmail.Text == null)
            //    operatorMail = "polyakovmymail@gmail.com";
            //else operatorMail = textBoxEmail.Text;

            //job.OperatorToEmail = operatorMail;
            job.EmailLevel = CompletionAction.Always;

            //Alert myAlert = new Alert(dtb.srv.JobServer, alertName);
            //myAlert.Severity = 19;
            //myAlert.NotificationMessage = "test";
            //myAlert.Create();

            //Operator myOperator = new Operator(dtb.srv.JobServer, textBoxNameOperator.Text);
            //myOperator.EmailAddress = operatorMail;
            //myOperator.Enabled = true;
            //myOperator.Create();

            //myAlert.AddNotification(operatorName, NotifyMethods.NotifyEmail);
            //myOperator.AddNotification(alertName, NotifyMethods.NotifyEmail);

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
