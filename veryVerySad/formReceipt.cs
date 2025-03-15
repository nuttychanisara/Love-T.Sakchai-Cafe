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
    public partial class formReceipt : Form
    {
        public formReceipt()
        {
            InitializeComponent();
        }

        private void receipt_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.receipt_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }

        private void formReceipt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Receipt_' table. You can move, or remove it, as needed.
            this.receipt_TableAdapter.Fill(this.mycafeDBDataSet._Receipt_);

        }
    }
}
