using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace veryVerySad
{
    public partial class formOrderTest : Form
    {
        
        SqlConnection cafeConnection;
        SqlCommand orderCommand;
        SqlDataAdapter orderAdapter;
        DataTable orderTable;
        CurrencyManager orderManager;
        string myState;
        int myBookmark;
        public formOrderTest()
        {
            InitializeComponent();
        }

        private void formOrderTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mycafeDBDataSet._Menu_' table. You can move, or remove it, as needed.
            this.menu_TableAdapter.Fill(this.mycafeDBDataSet._Menu_);

            try
            {
                cafeConnection = new SqlConnection(
                 "Data Source = NUTTY;" +
                 "Initial Catalog = myCafeDB;" +
                 "User ID = user1; Password = mypass1");
               
                // Open the connection   
                cafeConnection.Open();
                // Establish command object
                orderCommand = new SqlCommand("Select * from Order$ ORDER BY OrderId",
                                       cafeConnection);
                // Establish data adapter/data table
                orderAdapter = new SqlDataAdapter();
                orderAdapter.SelectCommand = orderCommand;
                orderTable = new DataTable();
                orderAdapter.Fill(orderTable);
                // Bind controls to data table
                orderId_TextBox.DataBindings.Add("Text", orderTable, "OrderId");
                menuId_TextBox.DataBindings.Add("Text", orderTable, "MenuId");
                orderUnit_TextBox.DataBindings.Add("Text", orderTable, "OrderUnit");
                orderDateDateTimePicker.DataBindings.Add("DateTime", orderTable, "OrderDate");
                orderTime_TextBox.DataBindings.Add("Text", orderTable, "OrderTime");

                // Establish currency manager
                orderManager = (CurrencyManager)
                this.BindingContext[orderTable];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "เกิดข้อผิดพลาดในการสั่งอาหาร",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.Show();
            SetState("View");


        }
        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":
                    orderId_TextBox.BackColor = Color.White;
                    orderId_TextBox.ForeColor = Color.Black;
                    menuId_TextBox.ReadOnly = true;
                    orderUnit_TextBox.ReadOnly = true;
                    orderTime_TextBox.ReadOnly = true;
                    buttonAddNew.Enabled = true;
                    buttonSave.Enabled = false;
                    buttonCancel.Enabled = false;
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                    menuId_TextBox.Focus();
                    break;
                default: // Add or Edit if not View
                    orderId_TextBox.BackColor = Color.White;
                    orderId_TextBox.ForeColor = Color.Black;
                    menuId_TextBox.ReadOnly = false;
                    orderUnit_TextBox.ReadOnly = false;
                    orderTime_TextBox.ReadOnly = false;
                    buttonAddNew.Enabled = false;
                    buttonSave.Enabled = true;
                    buttonCancel.Enabled = true;
                    buttonEdit.Enabled = false;
                    buttonDelete.Enabled = false;
                    menuId_TextBox.Focus();
                    break;
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string savedName = menuId_TextBox.Text;
            int savedRow;
            try
            {
                orderManager.EndCurrentEdit();
                orderTable.DefaultView.Sort = "MebuId";
                savedRow = orderTable.DefaultView.Find(savedName);
                orderManager.Position = savedRow;
                MessageBox.Show("ข้อมูลถูกบันทึกแล้ว", "บันทึก",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Information);
                SetState("View");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกข้อมูล", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            orderManager.CancelCurrentEdit();
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                myBookmark = orderManager.Position;
                orderManager.AddNew();
                SetState("Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการเพิ่มข้อมูล", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SetState("Edit");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                orderManager.RemoveAt(orderManager.Position);
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล", "ข้อผิดพลาด",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formOrderTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myState.Equals("Edit") || myState.Equals("Add"))
            {
                MessageBox.Show("คุณต้องแก้ไขข้อมูลปัจจุบันให้เสร็จก่อนที่จะหยุดโปรแกรม", "",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    SqlCommandBuilder authorsAdapterCommands = new SqlCommandBuilder(orderAdapter);
                    orderAdapter.Update(orderTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกฐานข้อมูล: \r\n" + ex.Message,
                        "ข้อผิดพลาดในการบันทึก",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                if (myState.Equals("Edit") || myState.Equals("Add"))
                {
                    MessageBox.Show("คุณต้องแก้ไขข้อมูลปัจจุบันให้เสร็จก่อนที่จะหยุดโปรแกรม", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    e.Cancel = true;
                }
                else
                {
                    // Close the connection
                    cafeConnection.Close();
                    // Dispose of the objects
                    cafeConnection.Dispose();
                    orderCommand.Dispose();
                    orderAdapter.Dispose();
                    orderTable.Dispose();
                }
            }
        }
    }
}

