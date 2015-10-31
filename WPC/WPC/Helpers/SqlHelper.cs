using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace WPC.Helpers
{
    public class SqliteHelper
    {
        private static SQLiteConnection _mem;

        public static DataTable ExecuteReader(string sqlitefn, string command, List<SqliteParam> parameters, out string errorMessage)
        {
            DataTable dt = null;
            try
            {
                errorMessage = "";
                using (var conn = new SQLiteConnection(sqlitefn))
                {
                    conn.Open();
                    var commandSql = new SQLiteCommand(command, conn);
                    if (parameters != null && parameters.Count > 0)
                    {
                        foreach (SqliteParam param in parameters)
                        {
                            commandSql.Parameters.Add(param.Name, param.Type).Value = param.Value;
                        }

                    }
                    dt = new DataTable();
                    var sqlDa = new SQLiteDataAdapter(commandSql);
                    sqlDa.Fill(dt);
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
                dt = null;
            }
            return dt;
        }

        static DataTable ExecuteReaderMem(string command, List<SqliteParam> parameters)
        {
            DataTable dt = null;
            try
            {
                var commandSql = new SQLiteCommand(command, _mem);
                if (parameters != null && parameters.Count > 0)
                {
                    foreach (SqliteParam param in parameters)
                    {
                        commandSql.Parameters.Add(param.Name, param.Type).Value = param.Value;
                    }

                }
                dt = new DataTable();
                var sqlDa = new SQLiteDataAdapter(commandSql);
                sqlDa.Fill(dt);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                dt = null;
            }
            return dt;
        }

        public static string CreateDb(string dbpath)
        {
            var connString = "";
            try
            {
                if (!File.Exists(dbpath))
                {
                    SQLiteConnection.CreateFile(dbpath);
                }

                if (File.Exists(dbpath))
                    connString = "Data Source=" + dbpath + ";Version=3;Compress=True;";
            }
            catch (Exception)
            {
            }

            return connString;
        }

        public static bool ExecuteNonQuery(string sqlitefn, string command, List<SqliteParam> parameters, out string errorMessage)
        {
            var result = false;
            errorMessage = "";
            try
            {
                using (var conn = new SQLiteConnection(sqlitefn))
                {
                    conn.Open();
                    var commandSql = new SQLiteCommand(command, conn);
                    if (parameters != null && parameters.Count > 0)
                    {
                        foreach (SqliteParam param in parameters)
                            commandSql.Parameters.Add(param.Name, param.Type).Value = param.Value;
                    }
                    int affected = commandSql.ExecuteNonQuery();
                    conn.Close();
                    result = affected > 0 ? true : false;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.ToString();
            }
            return result;
        }
    }

    public class SqliteParam
    {
        public SqliteParam(string name, object value, DbType type)
        {
            Name = name;
            Value = value;
            Type = type;
        }
        public string Name { get; private set; }
        public object Value { get; private set; }
        public DbType Type { get; private set; }
    }
}
