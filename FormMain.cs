using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookDatabase
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cookbookDataSet.Ingridient' table. You can move, or remove it, as needed.
            this.ingridientTableAdapter.Fill(this.cookbookDataSet.Ingridient);

        }

        private void ingridientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ingridientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cookbookDataSet);

        }
    }
}
