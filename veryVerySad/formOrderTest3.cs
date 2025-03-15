using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryVerySad
{
    public partial class formOrderTest3 : Form
    {
        SqlConnection cafeConnection;
        SqlCommand orderCommand;
        SqlDataAdapter orderAdapter;
        DataTable orderTable;
        CurrencyManager orderManager;
        string myState;
        int myOrdermark;

        SqlCommand menuCommand;
        SqlDataAdapter menuAdapter;
        DataTable menuTable;

        public formOrderTest3()
        {
            InitializeComponent();
        }

        private void FormOrderTest3_Load(object sender, EventArgs e)
        {
            try
            {
                cafeConnection = new SqlConnection("Data Source = NUTTY;" + "Initial Catalog = myCafeDB;" +
                                                         "User ID = user1; Password = mypass1");
                cafeConnection.Open();
                orderCommand = new SqlCommand("Select * from Order$ ORDER BY OrderId",
                                           cafeConnection);
                // Establish data adapter/data table
                orderAdapter = new SqlDataAdapter();
                orderAdapter.SelectCommand = orderCommand;
                orderTable = new DataTable();
                orderAdapter.Fill(orderTable);
                // Bind controls to data table
                textOrderId.DataBindings.Add("Text", orderTable, "OrderId");
                textOrderUnit.DataBindings.Add("Text", orderTable, "OrderUnit");
                datePicker.DataBindings.Add("DateTime", orderTable, "OrderDate");
                textTime.DataBindings.Add("Text", orderTable, "OrderTime");

                // Establish currency manager
                orderManager = (CurrencyManager)
                this.BindingContext[orderTable];

               /* menuCommand = new SqlCommand("Select * from Menu$ ORDER BY MenuName", cafeConnection);
                menuAdapter = new SqlDataAdapter();
                menuAdapter.SelectCommand = menuCommand;
                menuTable = new DataTable();
                menuAdapter.Fill(menuTable);
                comboMenuId.DataSource = menuTable;
                comboMenuId.DisplayMember = "MenuName";
                comboMenuId.ValueMember = "MenuId";
                comboMenuId.DataBindings.Add("SelectedValue", orderTable, "MenuId");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "เกิดข้อผิดพลาดในการสร้างการสั่งอาหาร",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.Show();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            orderManager.Position = 0;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (orderManager.Position == 0)
            {
                Console.Beep();
            }
            orderManager.Position--;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (orderManager.Position == orderManager.Count - 1)
            {
                Console.Beep();
            }
            orderManager.Position++;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            orderManager.Position = orderManager.Count - 1;
        }
    }
}
