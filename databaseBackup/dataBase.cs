using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Smo.Agent;
using Microsoft.SqlServer.Management.Common;

namespace databaseBackup
{
    class DataBase
    {
        private static DataBase instance;
        private DataBase() { }

        public static DataBase getInstance()
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }
        public ServerConnection srvConn;
        public Server srv;
        public string serverName;
        public string Backups(string NameBase, string Directory)
        {
            //Создание строки
            string fileName = string.Format("{0}_{1}.bak", NameBase, DateTime.Now.ToString("dd.MM.yyyy_HH-mm-ss"));
            string fullPath = Directory + "\\" + fileName;
            string sqlExpression = $"BACKUP DATABASE [{NameBase}] " +
                                   $"TO DISK = N'{fullPath}' " +
                                   $"WITH FORMAT, NAME = N'{fileName} Database Full Backup'"; //Проверка на наличие объекта
            return sqlExpression;
        }
    }  
}
