using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.DB
{
    public abstract class DBObject
    {
        protected int ID;

        protected DBObject()
        {

        }

        public void Save()
        {
            MockDB mdb = MockDB.GetInstance();
            mdb.Save(this);
        }
    }
}

