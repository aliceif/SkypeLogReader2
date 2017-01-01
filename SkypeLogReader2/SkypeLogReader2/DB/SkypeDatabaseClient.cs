using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace SkypeLogReader2.DB
{
    class SkypeDatabaseClient
    {
        public string ConnectionString { get; private set; }

        public SkypeDatabaseClient(string connectionString) : base()
        {
            ConnectionString = connectionString;
        }

        public bool TestConnection()
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (SQLiteException)
                {
                    return false;
                }
            }
        }
    }
}
