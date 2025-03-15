using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace veryVerySad
{
    public partial class formA : Form
    {
        public formA()
        {
            InitializeComponent();
        }

       
        private void formA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Employee_' table. You can move, or remove it, as needed.
            this.employee_TableAdapter.Fill(this.mycafeDBDataSet._Employee_);
            // TODO: This line of code loads data into the 'mycafeDBDataSet._TypeMenu_' table. You can move, or remove it, as needed.
            this.typeMenu_TableAdapter.Fill(this.mycafeDBDataSet._TypeMenu_);
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Menu_' table. You can move, or remove it, as needed.
            this.menu_TableAdapter.Fill(this.mycafeDBDataSet._Menu_);

        }

        private void menu_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.menu_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrintPreview_Click(object sender, EventArgs e)
        {
            
        }
    }
}
