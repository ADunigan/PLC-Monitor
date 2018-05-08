using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SQLClient
{
    public class SQLClient
    {
        static string dbFilePath;

        public static void DBCreate(string dbName)
        {
            string dbPath = Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments) + "\\PLC Monitor\\DB";
            if(!String.IsNullOrEmpty(dbPath) && !Directory.Exists(dbPath))
            {
                Directory.CreateDirectory(dbPath);                
            }
            
            dbFilePath = dbPath + "\\" + dbName + ".db";

            if(!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }
        }

        public static SQLiteConnection GetDBConnection()
        {
            SQLiteConnection conn;
            string strCon = string.Format("Data Source={0}", dbFilePath);
            conn = new SQLiteConnection(strCon);
            return conn;
        }

        //public static bool ConnectToSQL()
        //{
        //    SQLiteConnection conn = new SQLiteConnection();

        //    conn.ConnectionString = "integrated security=SSPI;data source=LTATL137501;" + "persist security info=False;initial catalog=TESTENV_PLCMonitor";
        //    try
        //    {
        //        conn.Open();
        //        return true;
        //    }
        //    catch(Exception ex)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}        
    }
}
