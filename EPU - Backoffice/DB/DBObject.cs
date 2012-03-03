using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.DB
{
    public abstract class DBObject
    {
        private int id;
        public int ID { get { return this.id; } private set { this.id = value; } }

        protected DBObject()
        {
            
        }

        public void Save()
        {
            MockDB mdb = MockDB.GetInstance();
            mdb.Save(this);
        }

        public void Load()
        {
            MockDB mdb = MockDB.GetInstance();
            this.id = mdb.Load(this);
        }
    }
}

