using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace CookbookDatabase
{
    public partial class FormMain : Form
    {
        string connectionString;

        public FormMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager
                .ConnectionStrings["CookbookDatabase.Properties.Settings.CookbookConnectionString"]
                .ConnectionString;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            

        }

        private void ingridientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
