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
    public partial class formEmployeeTest : Form
    {
        public formEmployeeTest()
        {
            InitializeComponent();
        }

        private void employee_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.soSadCafeDBDataSet);

        }

        private void formEmployeeTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'soSadCafeDBDataSet._Employee_' table. You can move, or remove it, as needed.
            this.employee_TableAdapter.Fill(this.soSadCafeDBDataSet._Employee_);

        }
    }
}
