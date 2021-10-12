using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace databaseBackup
{
    class BD
    {
        // Начало создания паттерна одиночки (singlton)
        private static BD instance;
        private BD()
        { }
        public static BD getInstance()
        {
            if (instance == null)
                instance = new BD();
            return instance;
        }
        //Конец создания паттерна
        //Объявление поля типа SqlConnection
        SqlConnection conn;
        //Подключение к базе данных
        public void Connection(string datasource, string nameUser, string pass)
        {
            //Создание строки
            string connString = @"Data Source=" + datasource + ";User Id = " + nameUser + "; Password = " + pass + ";";
            //Создание объекта
            conn = new SqlConnection(connString);
        }
        //Метод резевного копирования базы данных
        public int Backups(string NameBase, string Directory)
        {
            //Создание строки
            string fileName= string.Format("{0}_{1}.bak", NameBase, DateTime.Now.ToString("dd.MM.yyyy_HH-mm-ss"));
            string fullPath = Directory + "\\" + fileName;
            string sqlExpression = $"BACKUP DATABASE [{NameBase}] " +
                                   $"TO DISK = N'{fullPath}' " +
                                   $"WITH FORMAT, NAME = N'{fileName} Database Full Backup'"; //Проверка на наличие объекта
            if (conn != null)
            {
                try
                {
                    //Открытие соединения
                    conn.Open();
                    //Создание команды
                    SqlCommand command = new SqlCommand(sqlExpression, conn);
                    //Исполнение команды
                    command.ExecuteNonQuery();
                    //Закрытие соединения
                    conn.Close();
                    return 0;
                }
                catch
                {
                    conn.Close();
                    return 1;
                }
            }
            else
            {
                conn.Close();
                return 2;
            }
        }
        //Метод восстановления базы данных
        public int Recovery(string FileNamePath, string nameBase)
        {
            //Создание строки
            string sqlExpression = "USE [master] RESTORE DATABASE[" + nameBase + "] " +
                "FROM DISK = N'" + FileNamePath + 
                "' WITH FILE = 1, NOUNLOAD, STATS = 5";
            // Проверка на наличие объекта соединения
            if (conn != null)
            {
                try
                {
                    // Открываем соединение
                    conn.Open();
                    // Создание объекта команды
                    SqlCommand command = new SqlCommand(sqlExpression, conn);
                    // Исполнение команды
                    command.ExecuteNonQuery();
                    // Закрытие соединения
                    conn.Close();
                    return 0;
                }
                catch
                {
                    conn.Close();
                    return 1;
                }
            }
            else
            {
                conn.Close();
                return 2;
            }
        }

    }
}


