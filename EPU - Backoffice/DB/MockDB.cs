using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;

namespace Backoffice.DB
{
    class MockDB : DBProvider<MockDB>
    {
        Dictionary<DBObject, DBObject> MockList = new Dictionary<DBObject, DBObject>();
        public override void Connect()
        {
            throw new NotImplementedException();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Speichern in eine Liste
        /// </summary>
        /// <param name="dbobject">Das zu speichernde Objekt</param>
        public override void Insert(DBObject dbobject)
        {
            MockList.Add(dbobject, dbobject);
        }

        public override void Delete(DBObject dbobject)
        {
            MockList.Remove(dbobject);
        }

        public override void Update(DBObject dbobject)
        {
            MockList[dbobject] = dbobject;
        }

        public void Save(DBObject dbobject)
        {
            if (MockList[dbobject] == null)
                Insert(dbobject);
            else
                Update(dbobject);
        }
        public override DBObject Get(DBObject dbobject)
        {
            throw new NotImplementedException();
        }
    }
}
