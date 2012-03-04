using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Backoffice
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();   
        }

        #region Sandboxing
        public void label1_Click(object sender, EventArgs e)
        {
            Backoffice.Entity.Kontakt myKontakt = new Backoffice.Entity.Kontakt();
            myKontakt.Name = "Rudi";
            myKontakt.Load();

            label1.Text = myKontakt.ID.ToString();
            label5.Text = myKontakt.Name;
            label2.Text = myKontakt.Surname;
            label3.Text = myKontakt.Company;
        }

        public void label8_Click(object sender, EventArgs e)
        {
            Backoffice.Entity.Rechnung obj = new Backoffice.Entity.Rechnung();
            obj.Load();
            label8.Text = obj.RechnungID.ToString();
            label6.Text = obj.Value.ToString();
        }

        public void label9_Click(object sender, EventArgs e)
        {
            Backoffice.Entity.Ausgangsrechnung obj = new Backoffice.Entity.Ausgangsrechnung();
            obj.Load();
            label10.Text = obj.AusgangsrechnungID.ToString();
            label11.Text = obj.RechnungID.ToString();
            label12.Text = obj.AngebotID.ToString();
        }
        #endregion
    }
}
