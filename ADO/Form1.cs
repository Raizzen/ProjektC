using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ADO
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbCommand cmd = null;
        OleDbDataReader reader = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCO_Click(object sender, EventArgs e)
        {
            /*OleDbConnectionStringBuilder bldr = new OleDbConnectionStringBuilder();
            bldr.Provider = "Microsoft.ACE.OLEDB.12.0";
            bldr.DataSource= "Bestellung.acdb.accdb";*/
            con = new OleDbConnection(Properties.Settings.Default.DBcon);
            try
            {
                con.Open();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message,"Exception",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void buttonSQL_Click(object sender, EventArgs e)
        {
            cmd = con.CreateCommand();

            cmd.Parameters.Add("AGR", OleDbType.Integer);
            String artgr = textBoxArtikelGruppe.Text;
            cmd.CommandText = "Select * from tArtikel where ArtikelGruppe = AGR";
            cmd.CommandType = CommandType.Text;
            try
            {
                cmd.Parameters["AGR"].Value = textBoxArtikelGruppe.Text;
                reader = cmd.ExecuteReader();
                buttonRead.Enabled = true;
            }
            catch (OleDbException ex1)
            {
                MessageBox.Show(ex1.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        
        private void buttonRead_Click(object sender, EventArgs e)
        {
            listBoxAnzeige.Items.Clear();
            while (reader.Read())
            {
                Artikel a = mkArtikelObject(reader);
                listBoxAnzeige.Items.Add(a);
            }

        }

        private Artikel mkArtikelObject(OleDbDataReader reader)
        {
            Artikel a = new Artikel();
            int i = 0;
            a.ArtikelOid = Convert.ToInt32(reader[i++]); // erst zuweisen dann hochzählen wenn sofort in klammer
            a.ArtikelNr = Convert.ToInt32(reader[i++]);
            a.ArtikelGruppe = Convert.ToInt32(reader[i++]);
            a.Bezeichnung = Convert.ToString(reader[i++]);
            a.Bestand = Convert.ToInt16(reader[i++]);
            a.Meldebestand = Convert.ToInt16(reader[i++]);
            a.Verpackung = Convert.ToInt16(reader[i++]);
            a.VkPreis = Convert.ToDecimal(reader[i++]);
            a.letzteEntnahme = Convert.ToDateTime(reader[i++]);

            return a;
        }
    }
}
