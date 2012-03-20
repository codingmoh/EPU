using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Backoffice.DB
{
    class MSDB:DBProvider<MSDB>
    {
        private SqlConnection con;
        private SqlDataAdapter adapt;
        public override void Insert(DBObject dbobject)
        {
            throw new NotImplementedException();
        }

        public override void Delete(DBObject dbobject)
        {
            throw new NotImplementedException();
        }

        public override DBObject Get(DBObject dbobject)
        {
            throw new NotImplementedException();
        }

        public override int Load(DBObject dbobject)
        {
            throw new NotImplementedException();
        }

        public override void Update(DBObject dbobject)
        {
            throw new NotImplementedException();
        }

        public override void Connect()
        {
            con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Backoffice;Data Source=HEWLETT-PACKARD");
            con.Open();
        }

        public override void Close()
        {
            throw new NotImplementedException();
        }
    }
}
