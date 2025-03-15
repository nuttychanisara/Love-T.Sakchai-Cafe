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
    public partial class formQuotation : Form
    {
        public formQuotation()
        {
            InitializeComponent();
        }

        private void quotation_BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.quotation_BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mycafeDBDataSet);

        }

        private void formQuotation_Load(object sender, EventArgs e)
        {

        }
    }
}
