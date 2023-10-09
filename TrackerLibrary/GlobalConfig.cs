using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        //public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static IDataConnection Connection { get; set; }
        public static void InitializeConnections(DatabaseType db)
        {
            if(db == DatabaseType.Sql)
            {
                // TODO - Create the SQL Connection
                // SqlConnector sql = new SqlConnector(database);
            }
            if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
