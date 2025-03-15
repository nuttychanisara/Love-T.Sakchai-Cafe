namespace veryVerySad
{
    partial class formPayment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPayment));
            System.Windows.Forms.Label pOrderId_Label;
            System.Windows.Forms.Label payDate_Label;
            System.Windows.Forms.Label payTime_Label;
            System.Windows.Forms.Label payName_Label;
            System.Windows.Forms.Label payLName_Label;
            System.Windows.Forms.Label payAmount_Label;
            System.Windows.Forms.Label payStatus_Label;
            System.Windows.Forms.Label cfOrderId_Label;
            this.mycafeDBDataSet = new veryVerySad.MycafeDBDataSet();
            this.payment_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payment_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Payment_TableAdapter();
            this.tableAdapterManager = new veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager();
            this.payment_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.payment_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.payment_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmOrder_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmOrder_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.ConfirmOrder_TableAdapter();
            this.confirmOrder_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOrderId_TextBox = new System.Windows.Forms.TextBox();
            this.payDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.payTime_TextBox = new System.Windows.Forms.TextBox();
            this.payName_TextBox = new System.Windows.Forms.TextBox();
            this.payLName_TextBox = new System.Windows.Forms.TextBox();
            this.payAmount_TextBox = new System.Windows.Forms.TextBox();
            this.payStatus_TextBox = new System.Windows.Forms.TextBox();
            this.cfOrderId_ComboBox = new System.Windows.Forms.ComboBox();
            pOrderId_Label = new System.Windows.Forms.Label();
            payDate_Label = new System.Windows.Forms.Label();
            payTime_Label = new System.Windows.Forms.Label();
            payName_Label = new System.Windows.Forms.Label();
            payLName_Label = new System.Windows.Forms.Label();
            payAmount_Label = new System.Windows.Forms.Label();
            payStatus_Label = new System.Windows.Forms.Label();
            cfOrderId_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_BindingNavigator)).BeginInit();
            this.payment_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mycafeDBDataSet
            // 
            this.mycafeDBDataSet.DataSetName = "MycafeDBDataSet";
            this.mycafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payment_BindingSource
            // 
            this.payment_BindingSource.DataMember = "Payment$";
            this.payment_BindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // payment_TableAdapter
            // 
            this.payment_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfirmOrder_TableAdapter = this.confirmOrder_TableAdapter;
            this.tableAdapterManager.Employee_TableAdapter = null;
            this.tableAdapterManager.EmpPosition_TableAdapter = null;
            this.tableAdapterManager.Expenses_TableAdapter = null;
            this.tableAdapterManager.Material_TableAdapter = null;
            this.tableAdapterManager.Menu_TableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.Payment_TableAdapter = this.payment_TableAdapter;
            this.tableAdapterManager.PurchaseOrder_TableAdapter = null;
            this.tableAdapterManager.Quotation_TableAdapter = null;
            this.tableAdapterManager.Receipt_TableAdapter = null;
            this.tableAdapterManager.ReceiptOrder_TableAdapter = null;
            this.tableAdapterManager.Revenue_TableAdapter = null;
            this.tableAdapterManager.TypeMenu_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // payment_BindingNavigator
            // 
            this.payment_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.payment_BindingNavigator.BindingSource = this.payment_BindingSource;
            this.payment_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.payment_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.payment_BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.payment_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.payment_BindingNavigatorSaveItem});
            this.payment_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.payment_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.payment_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.payment_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.payment_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.payment_BindingNavigator.Name = "payment_BindingNavigator";
            this.payment_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.payment_BindingNavigator.Size = new System.Drawing.Size(1119, 27);
            this.payment_BindingNavigator.TabIndex = 0;
            this.payment_BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // payment_BindingNavigatorSaveItem
            // 
            this.payment_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.payment_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("payment_BindingNavigatorSaveItem.Image")));
            this.payment_BindingNavigatorSaveItem.Name = "payment_BindingNavigatorSaveItem";
            this.payment_BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.payment_BindingNavigatorSaveItem.Text = "Save Data";
            this.payment_BindingNavigatorSaveItem.Click += new System.EventHandler(this.payment_BindingNavigatorSaveItem_Click_1);
            // 
            // payment_DataGridView
            // 
            this.payment_DataGridView.AutoGenerateColumns = false;
            this.payment_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payment_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.payment_DataGridView.DataSource = this.payment_BindingSource;
            this.payment_DataGridView.Location = new System.Drawing.Point(29, 83);
            this.payment_DataGridView.Name = "payment_DataGridView";
            this.payment_DataGridView.RowHeadersWidth = 51;
            this.payment_DataGridView.RowTemplate.Height = 24;
            this.payment_DataGridView.Size = new System.Drawing.Size(644, 220);
            this.payment_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PayId ";
            this.dataGridViewTextBoxColumn1.HeaderText = "PayId ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CfOrderId ";
            this.dataGridViewTextBoxColumn2.HeaderText = "CfOrderId ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PayDate ";
            this.dataGridViewTextBoxColumn3.HeaderText = "PayDate ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PayTime ";
            this.dataGridViewTextBoxColumn4.HeaderText = "PayTime ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PayName ";
            this.dataGridViewTextBoxColumn5.HeaderText = "PayName ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PayLName ";
            this.dataGridViewTextBoxColumn6.HeaderText = "PayLName ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PayAmount ";
            this.dataGridViewTextBoxColumn7.HeaderText = "PayAmount ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PayStatus ";
            this.dataGridViewTextBoxColumn8.HeaderText = "PayStatus ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // confirmOrder_BindingSource
            // 
            this.confirmOrder_BindingSource.DataMember = "ConfirmOrder$";
            this.confirmOrder_BindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // confirmOrder_TableAdapter
            // 
            this.confirmOrder_TableAdapter.ClearBeforeFill = true;
            // 
            // confirmOrder_DataGridView
            // 
            this.confirmOrder_DataGridView.AutoGenerateColumns = false;
            this.confirmOrder_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.confirmOrder_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confirmOrder_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.confirmOrder_DataGridView.DataSource = this.confirmOrder_BindingSource;
            this.confirmOrder_DataGridView.Location = new System.Drawing.Point(29, 354);
            this.confirmOrder_DataGridView.Name = "confirmOrder_DataGridView";
            this.confirmOrder_DataGridView.RowHeadersWidth = 51;
            this.confirmOrder_DataGridView.RowTemplate.Height = 24;
            this.confirmOrder_DataGridView.Size = new System.Drawing.Size(644, 220);
            this.confirmOrder_DataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CfOrderId ";
            this.dataGridViewTextBoxColumn9.HeaderText = "CfOrderId ";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OrderId ";
            this.dataGridViewTextBoxColumn10.HeaderText = "OrderId ";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CfOrderMenu ";
            this.dataGridViewTextBoxColumn11.HeaderText = "CfOrderMenu ";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "CfOrderTime ";
            this.dataGridViewTextBoxColumn12.HeaderText = "CfOrderTime ";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // pOrderId_Label
            // 
            pOrderId_Label.AutoSize = true;
            pOrderId_Label.Location = new System.Drawing.Point(785, 66);
            pOrderId_Label.Name = "pOrderId_Label";
            pOrderId_Label.Size = new System.Drawing.Size(70, 16);
            pOrderId_Label.TabIndex = 3;
            pOrderId_Label.Text = "POrder Id :";
            // 
            // pOrderId_TextBox
            // 
            this.pOrderId_TextBox.Location = new System.Drawing.Point(861, 63);
            this.pOrderId_TextBox.Name = "pOrderId_TextBox";
            this.pOrderId_TextBox.Size = new System.Drawing.Size(100, 22);
            this.pOrderId_TextBox.TabIndex = 4;
            // 
            // payDate_Label
            // 
            payDate_Label.AutoSize = true;
            payDate_Label.Location = new System.Drawing.Point(779, 182);
            payDate_Label.Name = "payDate_Label";
            payDate_Label.Size = new System.Drawing.Size(69, 16);
            payDate_Label.TabIndex = 7;
            payDate_Label.Text = "Pay Date :";
            // 
            // payDate_DateTimePicker
            // 
            this.payDate_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payment_BindingSource, "PayDate ", true));
            this.payDate_DateTimePicker.Location = new System.Drawing.Point(854, 178);
            this.payDate_DateTimePicker.Name = "payDate_DateTimePicker";
            this.payDate_DateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.payDate_DateTimePicker.TabIndex = 8;
            // 
            // payTime_Label
            // 
            payTime_Label.AutoSize = true;
            payTime_Label.Location = new System.Drawing.Point(777, 249);
            payTime_Label.Name = "payTime_Label";
            payTime_Label.Size = new System.Drawing.Size(71, 16);
            payTime_Label.TabIndex = 9;
            payTime_Label.Text = "Pay Time :";
            // 
            // payTime_TextBox
            // 
            this.payTime_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_BindingSource, "PayTime ", true));
            this.payTime_TextBox.Location = new System.Drawing.Point(854, 246);
            this.payTime_TextBox.Name = "payTime_TextBox";
            this.payTime_TextBox.Size = new System.Drawing.Size(100, 22);
            this.payTime_TextBox.TabIndex = 10;
            // 
            // payName_Label
            // 
            payName_Label.AutoSize = true;
            payName_Label.Location = new System.Drawing.Point(806, 313);
            payName_Label.Name = "payName_Label";
            payName_Label.Size = new System.Drawing.Size(77, 16);
            payName_Label.TabIndex = 11;
            payName_Label.Text = "Pay Name :";
            // 
            // payName_TextBox
            // 
            this.payName_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_BindingSource, "PayName ", true));
            this.payName_TextBox.Location = new System.Drawing.Point(889, 310);
            this.payName_TextBox.Name = "payName_TextBox";
            this.payName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.payName_TextBox.TabIndex = 12;
            // 
            // payLName_Label
            // 
            payLName_Label.AutoSize = true;
            payLName_Label.Location = new System.Drawing.Point(843, 371);
            payLName_Label.Name = "payLName_Label";
            payLName_Label.Size = new System.Drawing.Size(84, 16);
            payLName_Label.TabIndex = 13;
            payLName_Label.Text = "Pay LName :";
            // 
            // payLName_TextBox
            // 
            this.payLName_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_BindingSource, "PayLName ", true));
            this.payLName_TextBox.Location = new System.Drawing.Point(933, 368);
            this.payLName_TextBox.Name = "payLName_TextBox";
            this.payLName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.payLName_TextBox.TabIndex = 14;
            // 
            // payAmount_Label
            // 
            payAmount_Label.AutoSize = true;
            payAmount_Label.Location = new System.Drawing.Point(867, 439);
            payAmount_Label.Name = "payAmount_Label";
            payAmount_Label.Size = new System.Drawing.Size(85, 16);
            payAmount_Label.TabIndex = 15;
            payAmount_Label.Text = "Pay Amount :";
            // 
            // payAmount_TextBox
            // 
            this.payAmount_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_BindingSource, "PayAmount ", true));
            this.payAmount_TextBox.Location = new System.Drawing.Point(958, 436);
            this.payAmount_TextBox.Name = "payAmount_TextBox";
            this.payAmount_TextBox.Size = new System.Drawing.Size(100, 22);
            this.payAmount_TextBox.TabIndex = 16;
            // 
            // payStatus_Label
            // 
            payStatus_Label.AutoSize = true;
            payStatus_Label.Location = new System.Drawing.Point(880, 512);
            payStatus_Label.Name = "payStatus_Label";
            payStatus_Label.Size = new System.Drawing.Size(77, 16);
            payStatus_Label.TabIndex = 17;
            payStatus_Label.Text = "Pay Status :";
            // 
            // payStatus_TextBox
            // 
            this.payStatus_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payment_BindingSource, "PayStatus ", true));
            this.payStatus_TextBox.Location = new System.Drawing.Point(963, 509);
            this.payStatus_TextBox.Name = "payStatus_TextBox";
            this.payStatus_TextBox.Size = new System.Drawing.Size(100, 22);
            this.payStatus_TextBox.TabIndex = 18;
            // 
            // cfOrderId_Label
            // 
            cfOrderId_Label.AutoSize = true;
            cfOrderId_Label.Location = new System.Drawing.Point(772, 140);
            cfOrderId_Label.Name = "cfOrderId_Label";
            cfOrderId_Label.Size = new System.Drawing.Size(76, 16);
            cfOrderId_Label.TabIndex = 18;
            cfOrderId_Label.Text = "Cf Order Id :";
            // 
            // cfOrderId_ComboBox
            // 
            this.cfOrderId_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.confirmOrder_BindingSource, "CfOrderId ", true));
            this.cfOrderId_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.payment_BindingSource, "CfOrderId ", true));
            this.cfOrderId_ComboBox.DataSource = this.confirmOrder_BindingSource;
            this.cfOrderId_ComboBox.DisplayMember = "CfOrderId ";
            this.cfOrderId_ComboBox.FormattingEnabled = true;
            this.cfOrderId_ComboBox.Location = new System.Drawing.Point(883, 132);
            this.cfOrderId_ComboBox.Name = "cfOrderId_ComboBox";
            this.cfOrderId_ComboBox.Size = new System.Drawing.Size(121, 24);
            this.cfOrderId_ComboBox.TabIndex = 19;
            this.cfOrderId_ComboBox.ValueMember = "CfOrderId ";
            // 
            // formPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 611);
            this.Controls.Add(cfOrderId_Label);
            this.Controls.Add(this.cfOrderId_ComboBox);
            this.Controls.Add(payStatus_Label);
            this.Controls.Add(this.payStatus_TextBox);
            this.Controls.Add(payAmount_Label);
            this.Controls.Add(this.payAmount_TextBox);
            this.Controls.Add(payLName_Label);
            this.Controls.Add(this.payLName_TextBox);
            this.Controls.Add(payName_Label);
            this.Controls.Add(this.payName_TextBox);
            this.Controls.Add(payTime_Label);
            this.Controls.Add(this.payTime_TextBox);
            this.Controls.Add(payDate_Label);
            this.Controls.Add(this.payDate_DateTimePicker);
            this.Controls.Add(pOrderId_Label);
            this.Controls.Add(this.pOrderId_TextBox);
            this.Controls.Add(this.confirmOrder_DataGridView);
            this.Controls.Add(this.payment_DataGridView);
            this.Controls.Add(this.payment_BindingNavigator);
            this.Name = "formPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formPayment";
            this.Load += new System.EventHandler(this.formPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_BindingNavigator)).EndInit();
            this.payment_BindingNavigator.ResumeLayout(false);
            this.payment_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payment_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MycafeDBDataSet mycafeDBDataSet;
        private System.Windows.Forms.BindingSource payment_BindingSource;
        private MycafeDBDataSetTableAdapters.Payment_TableAdapter payment_TableAdapter;
        private MycafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator payment_BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton payment_BindingNavigatorSaveItem;
        private MycafeDBDataSetTableAdapters.ConfirmOrder_TableAdapter confirmOrder_TableAdapter;
        private System.Windows.Forms.DataGridView payment_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource confirmOrder_BindingSource;
        private System.Windows.Forms.DataGridView confirmOrder_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.TextBox pOrderId_TextBox;
        private System.Windows.Forms.DateTimePicker payDate_DateTimePicker;
        private System.Windows.Forms.TextBox payTime_TextBox;
        private System.Windows.Forms.TextBox payName_TextBox;
        private System.Windows.Forms.TextBox payLName_TextBox;
        private System.Windows.Forms.TextBox payAmount_TextBox;
        private System.Windows.Forms.TextBox payStatus_TextBox;
        private System.Windows.Forms.ComboBox cfOrderId_ComboBox;
    }
}