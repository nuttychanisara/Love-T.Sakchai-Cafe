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
    public partial class formIndex : Form
    {
        public formIndex()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formEmployee formEmployee = new formEmployee();
            this.Hide();
            formEmployee.Show();
        }
    }
}
