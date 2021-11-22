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
        public string FullBackup(string NameBase, string Directory)
        {
            //Создание строки
            string fileName = string.Format("{0}_{1}.bak", NameBase, DateTime.Now.ToString("dd.MM.yyyy_HH-mm-ss"));
            string fullPath = Directory + "\\" + fileName;
            string sqlExpression = $"BACKUP DATABASE [{NameBase}] " +
                                   $"TO DISK = N'{fullPath}' " +
                                   $"WITH FORMAT, NAME = N'{fileName} Database Full Backup'"; //Проверка на наличие объекта
            return sqlExpression;
        }
        public string EmailAndFreeSpace(string email, string profile)
        {
            string sqlExpression= $"USE msdb"+
                            $"GO"+
                            $"EXEC sp_send_dbmail @profile_name = '{profile}',"+
                            $"@recipients = '{email}',"+
                            $"@subject = 'Test message',"+
                            $"@body = 'someText',"+
                            $"@query = 'SELECT distinct(volume_mount_point)," +
                            $"total_bytes / 1048576 as Size_in_MB," +
                            $"available_bytes / 1048576 as Free_in_MB," +
                            $"(select((available_bytes / 1048576 * 1.0) / (total_bytes / 1048576 * 1.0) * 100)) as FreePercentage" +
                            $"FROM sys.master_files AS f CROSS APPLY" +
                            $"sys.dm_os_volume_stats(f.database_id, f.file_id)" +
                            $"group by volume_mount_point, total_bytes / 1048576," +
                            $"available_bytes / 1048576 order by 1'," +
                            $"@attach_query_result_as_file = 1";
            return sqlExpression;
            //USE msdb
            //GO
            //EXEC sp_send_dbmail @profile_name = 'finalTest',
            //@recipients = 'augustxeno@gmail.com',
            //@subject = 'Test message',
            //@body = 'xp_fixeddrives',
            //@query = 'SELECT distinct(volume_mount_point), 
            //  total_bytes / 1048576 as Size_in_MB, 
            //  available_bytes / 1048576 as Free_in_MB,
            //  (select((available_bytes / 1048576 * 1.0) / (total_bytes / 1048576 * 1.0) * 100)) as FreePercentage
            //FROM sys.master_files AS f CROSS APPLY
            //  sys.dm_os_volume_stats(f.database_id, f.file_id)
            //group by volume_mount_point, total_bytes / 1048576, 
            //  available_bytes / 1048576 order by 1',
            //@attach_query_result_as_file = 1;
        }
    }  
}
