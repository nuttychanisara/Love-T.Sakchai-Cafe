namespace veryVerySad
{
    partial class formOrderTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.orderId_TextBox = new System.Windows.Forms.TextBox();
            this.menuId_TextBox = new System.Windows.Forms.TextBox();
            this.orderUnit_TextBox = new System.Windows.Forms.TextBox();
            this.orderTime_TextBox = new System.Windows.Forms.TextBox();
            this.orderDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mycafeDBDataSet = new veryVerySad.MycafeDBDataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Order_TableAdapter();
            this.menu_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Menu_TableAdapter();
            this.tableAdapterManager = new veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager();
            this.menu_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "รายการอาหาร";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "สั่งอาหาร";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(850, 399);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 30;
            this.buttonDelete.TabStop = false;
            this.buttonDelete.Text = "&ลบออก";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(970, 363);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "&ยกเลิก";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Location = new System.Drawing.Point(729, 399);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(75, 30);
            this.buttonAddNew.TabIndex = 29;
            this.buttonAddNew.TabStop = false;
            this.buttonAddNew.Text = "เ&พิ่มใหม่";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(849, 363);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 27;
            this.buttonSave.TabStop = false;
            this.buttonSave.Text = "&บันทึก";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(728, 363);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 30);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.TabStop = false;
            this.buttonEdit.Text = "แ&ก้ไข";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // orderId_TextBox
            // 
            this.orderId_TextBox.Location = new System.Drawing.Point(868, 90);
            this.orderId_TextBox.Name = "orderId_TextBox";
            this.orderId_TextBox.Size = new System.Drawing.Size(100, 22);
            this.orderId_TextBox.TabIndex = 37;
            this.orderId_TextBox.TabStop = false;
            // 
            // menuId_TextBox
            // 
            this.menuId_TextBox.Location = new System.Drawing.Point(878, 169);
            this.menuId_TextBox.Name = "menuId_TextBox";
            this.menuId_TextBox.Size = new System.Drawing.Size(100, 22);
            this.menuId_TextBox.TabIndex = 37;
            this.menuId_TextBox.TabStop = false;
            // 
            // orderUnit_TextBox
            // 
            this.orderUnit_TextBox.Location = new System.Drawing.Point(945, 229);
            this.orderUnit_TextBox.Name = "orderUnit_TextBox";
            this.orderUnit_TextBox.Size = new System.Drawing.Size(100, 22);
            this.orderUnit_TextBox.TabIndex = 37;
            this.orderUnit_TextBox.TabStop = false;
            // 
            // orderTime_TextBox
            // 
            this.orderTime_TextBox.Location = new System.Drawing.Point(825, 299);
            this.orderTime_TextBox.Name = "orderTime_TextBox";
            this.orderTime_TextBox.Size = new System.Drawing.Size(100, 22);
            this.orderTime_TextBox.TabIndex = 37;
            this.orderTime_TextBox.TabStop = false;
            // 
            // orderDateDateTimePicker
            // 
            this.orderDateDateTimePicker.Location = new System.Drawing.Point(1003, 283);
            this.orderDateDateTimePicker.Name = "orderDateDateTimePicker";
            this.orderDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.orderDateDateTimePicker.TabIndex = 38;
            this.orderDateDateTimePicker.TabStop = false;
            // 
            // mycafeDBDataSet
            // 
            this.mycafeDBDataSet.DataSetName = "MycafeDBDataSet";
            this.mycafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order$";
            this.orderBindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // order_TableAdapter
            // 
            this.order_TableAdapter.ClearBeforeFill = true;
            // 
            // menu_BindingSource
            // 
            this.menu_BindingSource.DataMember = "Menu$";
            this.menu_BindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // menu_TableAdapter
            // 
            this.menu_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfirmOrder_TableAdapter = null;
            this.tableAdapterManager.Employee_TableAdapter = null;
            this.tableAdapterManager.Expenses_TableAdapter = null;
            this.tableAdapterManager.Material_TableAdapter = null;
            this.tableAdapterManager.Menu_TableAdapter = this.menu_TableAdapter;
            this.tableAdapterManager.Order_TableAdapter = this.order_TableAdapter;
            this.tableAdapterManager.Payment_TableAdapter = null;
            this.tableAdapterManager.PurchaseOrder_TableAdapter = null;
            this.tableAdapterManager.Quotation_TableAdapter = null;
            this.tableAdapterManager.Receipt_TableAdapter = null;
            this.tableAdapterManager.ReceiptOrder_TableAdapter = null;
            this.tableAdapterManager.Revenue_TableAdapter = null;
            this.tableAdapterManager.TypeMenu_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // menu_DataGridView
            // 
            this.menu_DataGridView.AutoGenerateColumns = false;
            this.menu_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menu_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.menu_DataGridView.DataSource = this.menu_BindingSource;
            this.menu_DataGridView.Location = new System.Drawing.Point(12, 79);
            this.menu_DataGridView.Name = "menu_DataGridView";
            this.menu_DataGridView.RowHeadersWidth = 51;
            this.menu_DataGridView.RowTemplate.Height = 24;
            this.menu_DataGridView.Size = new System.Drawing.Size(705, 220);
            this.menu_DataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MenuId ";
            this.dataGridViewTextBoxColumn1.HeaderText = "MenuId ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TMenuId ";
            this.dataGridViewTextBoxColumn2.HeaderText = "TMenuId ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmpId ";
            this.dataGridViewTextBoxColumn3.HeaderText = "EmpId ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MenuName ";
            this.dataGridViewTextBoxColumn4.HeaderText = "MenuName ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MenuPrice ";
            this.dataGridViewTextBoxColumn5.HeaderText = "MenuPrice ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // order_DataGridView
            // 
            this.order_DataGridView.AutoGenerateColumns = false;
            this.order_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.order_DataGridView.DataSource = this.orderBindingSource;
            this.order_DataGridView.Location = new System.Drawing.Point(12, 363);
            this.order_DataGridView.Name = "order_DataGridView";
            this.order_DataGridView.RowHeadersWidth = 51;
            this.order_DataGridView.RowTemplate.Height = 24;
            this.order_DataGridView.Size = new System.Drawing.Size(705, 220);
            this.order_DataGridView.TabIndex = 38;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OrderId ";
            this.dataGridViewTextBoxColumn6.HeaderText = "OrderId ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MenuId ";
            this.dataGridViewTextBoxColumn7.HeaderText = "MenuId ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "OrderUnit ";
            this.dataGridViewTextBoxColumn8.HeaderText = "OrderUnit ";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OrderTime ";
            this.dataGridViewTextBoxColumn10.HeaderText = "OrderTime ";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // formOrderTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 633);
            this.Controls.Add(this.order_DataGridView);
            this.Controls.Add(this.menu_DataGridView);
            this.Controls.Add(this.orderDateDateTimePicker);
            this.Controls.Add(this.orderTime_TextBox);
            this.Controls.Add(this.orderUnit_TextBox);
            this.Controls.Add(this.menuId_TextBox);
            this.Controls.Add(this.orderId_TextBox);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formOrderTest";
            this.Text = "formOrderTest";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formOrderTest_FormClosing);
            this.Load += new System.EventHandler(this.formOrderTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DateTimePicker orderDateDateTimePicker;
        private System.Windows.Forms.TextBox orderTime_TextBox;
        private System.Windows.Forms.TextBox orderUnit_TextBox;
        private System.Windows.Forms.TextBox menuId_TextBox;
        private System.Windows.Forms.TextBox orderId_TextBox;
        private MycafeDBDataSet mycafeDBDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private MycafeDBDataSetTableAdapters.Order_TableAdapter order_TableAdapter;
        private System.Windows.Forms.BindingSource menu_BindingSource;
        private MycafeDBDataSetTableAdapters.Menu_TableAdapter menu_TableAdapter;
        private MycafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView menu_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridView order_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}