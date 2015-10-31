using System.IO;
using System.Reflection;

namespace WPC
{
    public class WpcHelper
    {
        public static string DbConnection { get; set; }
        public static string DbPath { get; set; }


        public static void LoadConfig()
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            DbPath = Path.Combine(path, "wpc.sqlite3");

            DbConnection = "Data Source=" + DbPath + ";Version=3";


        }

    }
}
