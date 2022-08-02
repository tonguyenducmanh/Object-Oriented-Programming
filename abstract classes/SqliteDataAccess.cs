using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public class SqliteDataAccess : DataAccess
    {
        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading from SQLite");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
