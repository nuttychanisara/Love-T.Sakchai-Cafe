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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void confirmOrder_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.confirmOrder_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mycafeDBDataSet._ConfirmOrder_' table. You can move, or remove it, as needed.
            this.confirmOrder_TableAdapter.Fill(this.mycafeDBDataSet._ConfirmOrder_);

        }
    }
}
