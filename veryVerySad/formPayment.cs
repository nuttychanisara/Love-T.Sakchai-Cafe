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
    public partial class formPayment : Form
    {
        public formPayment()
        {
            InitializeComponent();
        }

        
        private void formPayment_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'mycafeDBDataSet._ConfirmOrder_' table. You can move, or remove it, as needed.
            this.confirmOrder_TableAdapter.Fill(this.mycafeDBDataSet._ConfirmOrder_);
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Payment_' table. You can move, or remove it, as needed.
            this.payment_TableAdapter.Fill(this.mycafeDBDataSet._Payment_);
            // TODO: This line of code loads data into the 'mycafeDBDataSet._ConfirmOrder_' table. You can move, or remove it, as needed.
            this.confirmOrder_TableAdapter.Fill(this.mycafeDBDataSet._ConfirmOrder_);
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Payment_' table. You can move, or remove it, as needed.
            this.payment_TableAdapter.Fill(this.mycafeDBDataSet._Payment_);
        }

        private void buttonIndex_Click(object sender, EventArgs e)
        {
            formIndex formIndex = new formIndex();
            this.Hide();
            formIndex.Show();
        }

        private void payment_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.payment_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }

        private void payment_BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.payment_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }
    }
}
