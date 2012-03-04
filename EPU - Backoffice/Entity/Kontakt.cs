using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backoffice.Entity
{
    class Kontakt : DB.DBObject
    {
        private String name, surname, company;

        public String Name { get { return this.name; } set { this.name = value; } }
        public String Surname { get { return this.surname; } set { this.surname = value; } }
        public String Company { get { return this.company; } set { this.company = value; } }
        
    }
}
