using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Backoffice;
using Backoffice.Entity;

namespace Backoffice.DB
{
    class MockDB : DBProvider<MockDB>
    {
        private int NameItx = 0;
        private String[] Names = {"Rudi", "Norbert", "Susi", "Karl"};
        private String[] Surnames = { "Rakete", "Nukular", "Semmel", "Karottenkopf" };
        private String[] Companies = { "Rasselfabrik", "Neonröhrenaushöhlerei WTF", "Sonnenschirmgeradbiege-Sanatorium Suselberg", "Koch&Ketz Klotzenmotz" };

        private int RechnungItx = 0;
        private int[] Rechnung_Values = {100, 1337, 6800, 4200};
        //private int AusgangsrechnungItx = 0;
        private int[] Ausgangsrechnung_AngebotIDs = {11, 21, 31, 41};

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
            switch (dbobject.GetType().ToString())
            { 
                case "Kontakt":
                    ((Kontakt)dbobject).Name = this.Names[NameItx];
                    ((Kontakt)dbobject).Surname = this.Surnames[NameItx];
                    ((Kontakt)dbobject).Company = this.Companies[NameItx];
                    break;

                default:
                    break;
            }

            return dbobject;
        }

        public override int Load(DBObject dbobject)
        {
            String[] parts = dbobject.GetType().ToString().Split('.');
            String type = parts[parts.Length - 1];
            int ID = -1;

            switch (type)
            {
                case "Kontakt":
                    ((Kontakt)dbobject).Name = this.Names[NameItx];
                    ((Kontakt)dbobject).Surname = this.Surnames[NameItx];
                    ((Kontakt)dbobject).Company = this.Companies[NameItx];
                    
                    NameItx++;
                    ID = NameItx;
                    NameItx = NameItx % this.Names.Length;
                    break;
                /*
                case "Rechnung":
                    ((Rechnung)dbobject).Value = this.Rechnung_Values[RechnungItx];

                    RechnungItx++;
                    ((Rechnung)dbobject).RechnungID = RechnungItx;
                    RechnungItx = RechnungItx % this.Rechnung_Values.Length;
                    break;
                */
                case "Ausgangsrechnung":
                    ((Ausgangsrechnung)dbobject).Value = this.Rechnung_Values[RechnungItx];
                    ((Ausgangsrechnung)dbobject).AngebotID = this.Ausgangsrechnung_AngebotIDs[RechnungItx];
                    RechnungItx++;
                    ((Rechnung)dbobject).RechnungID = RechnungItx;
                    ((Ausgangsrechnung)dbobject).AusgangsrechnungID = RechnungItx + 1;
                    RechnungItx = RechnungItx % this.Rechnung_Values.Length;

                    break;

                default:
                    break;
            }
            return ID;
        }
    }
}
