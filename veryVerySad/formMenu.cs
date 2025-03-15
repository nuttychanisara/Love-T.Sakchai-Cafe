using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryVerySad
{
    public partial class formMenu : Form
    {
        const string strConnStrFileName
            = "ConnectionString.ini";
        SqlConnection cafeConnection;
        SqlCommand MenuCommand;
        SqlDataAdapter MenuAdapter;
        DataTable MenuTable;
        CurrencyManager MenuManager;
        string myState;
        int myBookmark;

        public formMenu()
        {
            InitializeComponent();
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            try
            {
                string strConnectionString = "";
                if (File.Exists(strConnStrFileName))
                    strConnectionString = File.ReadAllText(strConnStrFileName,
                                                    Encoding.GetEncoding("Windows-874"));
                // Connect to books database   
                cafeConnection = new SqlConnection(strConnectionString);
                // Open the connection   
                cafeConnection.Open();
                // Establish command object
                MenuCommand = new SqlCommand("Select * from Menu$ ",
                                       cafeConnection);
                // Establish data adapter/data table
                MenuAdapter = new SqlDataAdapter();
                MenuAdapter.SelectCommand = MenuCommand;
                MenuTable = new DataTable();
                MenuAdapter.Fill(MenuTable);



                // Bind controls to data table
                textMenuId.DataBindings.Add("Text", MenuTable, "MenuId");
                textMenuName.DataBindings.Add("Text", MenuTable, "MenuName");
                textEmpId.DataBindings.Add("Text", MenuTable, "EmpId");
                textTypeMenu.DataBindings.Add("Text", MenuTable, "TMenuId");
                textPrice.DataBindings.Add("Text", MenuTable, "MenuPrice");
               
                // Establish currency manager
                MenuManager = (CurrencyManager)
                this.BindingContext[MenuTable];

                /*positionCommand = new SqlCommand("Select * from EmpPosition$ ORDER BY EmpPoId", cafeConnection);
                positionAdapter = new SqlDataAdapter();
                positionAdapter.SelectCommand = positionCommand;
                positionTable = new DataTable();
                positionAdapter.Fill(positionTable);
                comboPosition.DataSource = positionTable;
                comboPosition.DisplayMember = "EmpPosition";
                comboPosition.ValueMember = "EmpPoId";
                comboPosition.DataBindings.Add("SelectedValue", employeeTable, "EmpPoId");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "เกิดข้อผิดพลาดในการสร้างการทำงานกับตารางข้อมูลพนักงาน",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            SetState("View");
        }

        private void formMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (myState.Equals("Edit") || myState.Equals("Add"))
            {
                MessageBox.Show("คุณต้องแก้ไขข้อมูลปัจจุบันให้เสร็จก่อนที่จะหยุดโปรแกรม", "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                e.Cancel = true;
            }
            else
            {
                try
                {
                    // Save changes to database
                    SqlCommandBuilder employeeAdapterCommands
                        = new SqlCommandBuilder(MenuAdapter);
                    MenuAdapter.Update(MenuTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการบันทึกฐานข้อมูล: \r\n" + ex.Message,
                        "ข้อผิดพลาดในการบันทึก",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // Close the connection
                cafeConnection.Close();
                // Dispose of the objects
                cafeConnection.Dispose();
                MenuCommand.Dispose();
                MenuAdapter.Dispose();
                MenuTable.Dispose();

                /*positionCommand.Dispose();
                positionAdapter.Dispose();
                positionTable.Dispose();*/
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            MenuManager.Position = 0;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (MenuManager.Position == 0)
            {
                Console.Beep();
            }
            MenuManager.Position--;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (MenuManager.Position == MenuManager.Count - 1)
            {
                Console.Beep();
            }
            MenuManager.Position++;
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            MenuManager.Position = MenuManager.Count - 1;
        }

        private void SetState(string appState)
        {
            myState = appState;
            switch (appState)
            {
                case "View":

                    textMenuId.BackColor = Color.White;
                    textMenuId.ForeColor = Color.Black;
                    textMenuName.ReadOnly = true;
                    textTypeMenu.ReadOnly = true;
                    textEmpId.ReadOnly = true;
                    textPrice.ReadOnly = true;
                    
                    
                    buttonFirst.Enabled = true;
                    buttonPrevious.Enabled = true;
                    buttonNext.Enabled = true;
                    buttonLast.Enabled = true;
                    buttonAddNew.Enabled = true;
                    buttonSave.Enabled = false;
                    buttonCancel.Enabled = false;
                    buttonEdit.Enabled = true;
                    buttonDelete.Enabled = true;
                    buttonDone.Enabled = true;
                    textMenuName.Focus();
                    break;
                default: // Add or Edit if not View

                    textMenuId.BackColor = Color.Red;
                    textMenuId.ForeColor = Color.White;
                    textMenuId.ReadOnly = false;
                    if (myState.Equals("Edit"))
                    {
                        textMenuId.BackColor = Color.Red;
                        textMenuId.ForeColor = Color.White;
                        textMenuId.ReadOnly = true;
                        textMenuId.TabStop = false;
                    }
                    else
                    {
                        textMenuId.TabStop = true;
                    }
                    textMenuName.ReadOnly = true;
                    textTypeMenu.ReadOnly = true;
                    textEmpId.ReadOnly = true;
                    textPrice.ReadOnly = true;
                   
                    buttonFirst.Enabled = false;
                    buttonPrevious.Enabled = false;
                    buttonNext.Enabled = false;
                    buttonLast.Enabled = false;
                    buttonAddNew.Enabled = false;
                    buttonSave.Enabled = true;
                    buttonCancel.Enabled = true;
                    buttonEdit.Enabled = false;
                    buttonDelete.Enabled = false;
                    buttonDone.Enabled = false;
                    textMenuName.Focus();
                    break;
            }
        }
    }
}
