using DBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MySQLAccess mySQLAccess = new MySQLAccess();
            mySQLAccess.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            mySQLAccess.OpenConnection();
            dataGridView1.DataSource = mySQLAccess.QuerySQL("SELECT * FROM facturacion.clientes");
            mySQLAccess.CloseConnection();
        }
        
    }
}
