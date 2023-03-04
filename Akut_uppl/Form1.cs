using Akutl_uppl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Akut_uppl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datacontainer.anvandarnamn = "SA.tomha5";
            //////
            Datacontainer.losen = "Borg0045!!";
            //  Datacontainer.connectsource = @"Data Source=Klingen-su-db,62468;Persist Security Info=True;Integrated Security=true; Initial Catalog = Klingen;";
              Datacontainer.connectsource = @"Data Source=VGDB1472\i01\Klingen_su_db,62468;Persist Security Info=True;Integrated Security=SSPI; Initial Catalog = Klingen;";

            //  VGDB1472\i01\Klingen_su_db,62468
            Datacontainer.connectionString = @Datacontainer.connectsource + "User ID=" + Datacontainer.anvandarnamn + ";Password=" + Datacontainer.losen + "";
            Datacontainer.cnn = new SqlConnection(Datacontainer.connectionString);
            Datacontainer.cnn.Open();
            MessageBox.Show("Connection Open  !");
        }
    }

   
}
