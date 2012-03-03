using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Sql;

namespace Backoffice.DB
{
    abstract class DBProvider<T>
    {
        private static T Instance;

        protected DBProvider()
        {

        }
        public static T GetInstance()
        {
            if (Instance == null)
                Instance = Activator.CreateInstance<T>();
            return Instance;
        }

        public abstract void Insert(DBObject dbobject);
        public abstract void Delete(DBObject dbobject);
        public abstract DBObject Get(DBObject dbobject);
        public abstract void Update(DBObject dbobject);
        public abstract void Connect();

        public abstract void Close();
    }
}
