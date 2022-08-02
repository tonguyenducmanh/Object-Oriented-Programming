using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_classes
{
    public abstract class DataAccess
    {
        public string LoadConnectionString(string name)
        {
            Console.WriteLine("Load connection string");
            return "test connection string";
        }
        public abstract void LoadData(string sql);
        public abstract void SaveData(string sql);
    }
}
