using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryVerySad
{
    public partial class formOrder1 : Form
    {
        public formOrder1()
        {
            InitializeComponent();
        }

        private void order_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }

        private void formOrder1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Menu_' table. You can move, or remove it, as needed.
            this.menu_TableAdapter.Fill(this.mycafeDBDataSet._Menu_);
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Order_' table. You can move, or remove it, as needed.
            this.order_TableAdapter.Fill(this.mycafeDBDataSet._Order_);

        }
    }
}
