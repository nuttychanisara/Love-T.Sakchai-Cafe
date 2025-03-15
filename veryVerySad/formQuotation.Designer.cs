namespace veryVerySad
{
    partial class formQuotation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formQuotation));
            this.mycafeDBDataSet = new veryVerySad.MycafeDBDataSet();
            this.quotation_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Quotation_TableAdapter();
            this.tableAdapterManager = new veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager();
            this.quotation_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quotation_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mycafeDBDataSet1 = new veryVerySad.MycafeDBDataSet1();
            this.quotation_BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.quotation_TableAdapter1 = new veryVerySad.MycafeDBDataSet1TableAdapters.Quotation_TableAdapter();
            this.tableAdapterManager1 = new veryVerySad.MycafeDBDataSet1TableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoLNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoShopNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoHnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoSoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoMooDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoRoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sareaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dareaIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.provinceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoPostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_BindingNavigator)).BeginInit();
            this.quotation_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mycafeDBDataSet
            // 
            this.mycafeDBDataSet.DataSetName = "MycafeDBDataSet";
            this.mycafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quotation_BindingSource
            // 
            this.quotation_BindingSource.DataMember = "Quotation$";
            this.quotation_BindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // quotation_TableAdapter
            // 
            this.quotation_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfirmOrder_TableAdapter = null;
            this.tableAdapterManager.Employee_TableAdapter = null;
            this.tableAdapterManager.EmpPosition_TableAdapter = null;
            this.tableAdapterManager.Expenses_TableAdapter = null;
            this.tableAdapterManager.Material_TableAdapter = null;
            this.tableAdapterManager.Menu_TableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.Payment_TableAdapter = null;
            this.tableAdapterManager.PurchaseOrder_TableAdapter = null;
            this.tableAdapterManager.Quotation_TableAdapter = this.quotation_TableAdapter;
            this.tableAdapterManager.Receipt_TableAdapter = null;
            this.tableAdapterManager.ReceiptOrder_TableAdapter = null;
            this.tableAdapterManager.Revenue_TableAdapter = null;
            this.tableAdapterManager.TypeMenu_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // quotation_BindingNavigator
            // 
            this.quotation_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.quotation_BindingNavigator.BindingSource = this.quotation_BindingSource;
            this.quotation_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.quotation_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.quotation_BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.quotation_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.quotation_BindingNavigatorSaveItem});
            this.quotation_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.quotation_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.quotation_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.quotation_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.quotation_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.quotation_BindingNavigator.Name = "quotation_BindingNavigator";
            this.quotation_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.quotation_BindingNavigator.Size = new System.Drawing.Size(963, 27);
            this.quotation_BindingNavigator.TabIndex = 0;
            this.quotation_BindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // quotation_BindingNavigatorSaveItem
            // 
            this.quotation_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.quotation_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("quotation_BindingNavigatorSaveItem.Image")));
            this.quotation_BindingNavigatorSaveItem.Name = "quotation_BindingNavigatorSaveItem";
            this.quotation_BindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.quotation_BindingNavigatorSaveItem.Text = "Save Data";
            this.quotation_BindingNavigatorSaveItem.Click += new System.EventHandler(this.quotation_BindingNavigatorSaveItem_Click);
            // 
            // mycafeDBDataSet1
            // 
            this.mycafeDBDataSet1.DataSetName = "MycafeDBDataSet1";
            this.mycafeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quotation_BindingSource1
            // 
            this.quotation_BindingSource1.DataMember = "Quotation$";
            this.quotation_BindingSource1.DataSource = this.mycafeDBDataSet1;
            // 
            // quotation_TableAdapter1
            // 
            this.quotation_TableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ConfirmOrder_TableAdapter = null;
            this.tableAdapterManager1.Employee_TableAdapter = null;
            this.tableAdapterManager1.Expenses_TableAdapter = null;
            this.tableAdapterManager1.Material_TableAdapter = null;
            this.tableAdapterManager1.Menu_TableAdapter = null;
            this.tableAdapterManager1.Order_TableAdapter = null;
            this.tableAdapterManager1.Payment_TableAdapter = null;
            this.tableAdapterManager1.PurchaseOrder_TableAdapter = null;
            this.tableAdapterManager1.Quotation_TableAdapter = this.quotation_TableAdapter1;
            this.tableAdapterManager1.Receipt_TableAdapter = null;
            this.tableAdapterManager1.ReceiptOrder_TableAdapter = null;
            this.tableAdapterManager1.Revenue_TableAdapter = null;
            this.tableAdapterManager1.TypeMenu_TableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = veryVerySad.MycafeDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.quoIdDataGridViewTextBoxColumn,
            this.matIdDataGridViewTextBoxColumn,
            this.quoNameDataGridViewTextBoxColumn,
            this.quoLNameDataGridViewTextBoxColumn,
            this.quoTelDataGridViewTextBoxColumn,
            this.quoShopNameDataGridViewTextBoxColumn,
            this.quoHnumDataGridViewTextBoxColumn,
            this.quoSoiDataGridViewTextBoxColumn,
            this.quoMooDataGridViewTextBoxColumn,
            this.quoRoadDataGridViewTextBoxColumn,
            this.sareaIdDataGridViewTextBoxColumn,
            this.dareaIdDataGridViewTextBoxColumn,
            this.provinceIdDataGridViewTextBoxColumn,
            this.quoPostalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.quotation_BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(830, 249);
            this.dataGridView1.TabIndex = 1;
            // 
            // quoIdDataGridViewTextBoxColumn
            // 
            this.quoIdDataGridViewTextBoxColumn.DataPropertyName = "QuoId";
            this.quoIdDataGridViewTextBoxColumn.HeaderText = "QuoId";
            this.quoIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoIdDataGridViewTextBoxColumn.Name = "quoIdDataGridViewTextBoxColumn";
            this.quoIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // matIdDataGridViewTextBoxColumn
            // 
            this.matIdDataGridViewTextBoxColumn.DataPropertyName = "MatId ";
            this.matIdDataGridViewTextBoxColumn.HeaderText = "MatId ";
            this.matIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matIdDataGridViewTextBoxColumn.Name = "matIdDataGridViewTextBoxColumn";
            this.matIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoNameDataGridViewTextBoxColumn
            // 
            this.quoNameDataGridViewTextBoxColumn.DataPropertyName = "QuoName ";
            this.quoNameDataGridViewTextBoxColumn.HeaderText = "QuoName ";
            this.quoNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoNameDataGridViewTextBoxColumn.Name = "quoNameDataGridViewTextBoxColumn";
            this.quoNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoLNameDataGridViewTextBoxColumn
            // 
            this.quoLNameDataGridViewTextBoxColumn.DataPropertyName = "QuoLName ";
            this.quoLNameDataGridViewTextBoxColumn.HeaderText = "QuoLName ";
            this.quoLNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoLNameDataGridViewTextBoxColumn.Name = "quoLNameDataGridViewTextBoxColumn";
            this.quoLNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoTelDataGridViewTextBoxColumn
            // 
            this.quoTelDataGridViewTextBoxColumn.DataPropertyName = "QuoTel ";
            this.quoTelDataGridViewTextBoxColumn.HeaderText = "QuoTel ";
            this.quoTelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoTelDataGridViewTextBoxColumn.Name = "quoTelDataGridViewTextBoxColumn";
            this.quoTelDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoShopNameDataGridViewTextBoxColumn
            // 
            this.quoShopNameDataGridViewTextBoxColumn.DataPropertyName = "QuoShopName ";
            this.quoShopNameDataGridViewTextBoxColumn.HeaderText = "QuoShopName ";
            this.quoShopNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoShopNameDataGridViewTextBoxColumn.Name = "quoShopNameDataGridViewTextBoxColumn";
            this.quoShopNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoHnumDataGridViewTextBoxColumn
            // 
            this.quoHnumDataGridViewTextBoxColumn.DataPropertyName = "QuoHnum ";
            this.quoHnumDataGridViewTextBoxColumn.HeaderText = "QuoHnum ";
            this.quoHnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoHnumDataGridViewTextBoxColumn.Name = "quoHnumDataGridViewTextBoxColumn";
            this.quoHnumDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoSoiDataGridViewTextBoxColumn
            // 
            this.quoSoiDataGridViewTextBoxColumn.DataPropertyName = "QuoSoi ";
            this.quoSoiDataGridViewTextBoxColumn.HeaderText = "QuoSoi ";
            this.quoSoiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoSoiDataGridViewTextBoxColumn.Name = "quoSoiDataGridViewTextBoxColumn";
            this.quoSoiDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoMooDataGridViewTextBoxColumn
            // 
            this.quoMooDataGridViewTextBoxColumn.DataPropertyName = "QuoMoo ";
            this.quoMooDataGridViewTextBoxColumn.HeaderText = "QuoMoo ";
            this.quoMooDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoMooDataGridViewTextBoxColumn.Name = "quoMooDataGridViewTextBoxColumn";
            this.quoMooDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoRoadDataGridViewTextBoxColumn
            // 
            this.quoRoadDataGridViewTextBoxColumn.DataPropertyName = "QuoRoad ";
            this.quoRoadDataGridViewTextBoxColumn.HeaderText = "QuoRoad ";
            this.quoRoadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoRoadDataGridViewTextBoxColumn.Name = "quoRoadDataGridViewTextBoxColumn";
            this.quoRoadDataGridViewTextBoxColumn.Width = 125;
            // 
            // sareaIdDataGridViewTextBoxColumn
            // 
            this.sareaIdDataGridViewTextBoxColumn.DataPropertyName = "SareaId";
            this.sareaIdDataGridViewTextBoxColumn.HeaderText = "SareaId";
            this.sareaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sareaIdDataGridViewTextBoxColumn.Name = "sareaIdDataGridViewTextBoxColumn";
            this.sareaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dareaIdDataGridViewTextBoxColumn
            // 
            this.dareaIdDataGridViewTextBoxColumn.DataPropertyName = "DareaId";
            this.dareaIdDataGridViewTextBoxColumn.HeaderText = "DareaId";
            this.dareaIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dareaIdDataGridViewTextBoxColumn.Name = "dareaIdDataGridViewTextBoxColumn";
            this.dareaIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // provinceIdDataGridViewTextBoxColumn
            // 
            this.provinceIdDataGridViewTextBoxColumn.DataPropertyName = "ProvinceId";
            this.provinceIdDataGridViewTextBoxColumn.HeaderText = "ProvinceId";
            this.provinceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.provinceIdDataGridViewTextBoxColumn.Name = "provinceIdDataGridViewTextBoxColumn";
            this.provinceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // quoPostalDataGridViewTextBoxColumn
            // 
            this.quoPostalDataGridViewTextBoxColumn.DataPropertyName = "QuoPostal ";
            this.quoPostalDataGridViewTextBoxColumn.HeaderText = "QuoPostal ";
            this.quoPostalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quoPostalDataGridViewTextBoxColumn.Name = "quoPostalDataGridViewTextBoxColumn";
            this.quoPostalDataGridViewTextBoxColumn.Width = 125;
            // 
            // formQuotation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quotation_BindingNavigator);
            this.Name = "formQuotation";
            this.Text = "formQuotation";
            this.Load += new System.EventHandler(this.formQuotation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_BindingNavigator)).EndInit();
            this.quotation_BindingNavigator.ResumeLayout(false);
            this.quotation_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotation_BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MycafeDBDataSet mycafeDBDataSet;
        private System.Windows.Forms.BindingSource quotation_BindingSource;
        private MycafeDBDataSetTableAdapters.Quotation_TableAdapter quotation_TableAdapter;
        private MycafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator quotation_BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton quotation_BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private MycafeDBDataSet1 mycafeDBDataSet1;
        private System.Windows.Forms.BindingSource quotation_BindingSource1;
        private MycafeDBDataSet1TableAdapters.Quotation_TableAdapter quotation_TableAdapter1;
        private MycafeDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoLNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoShopNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoHnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoSoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoMooDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoRoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sareaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dareaIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn provinceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoPostalDataGridViewTextBoxColumn;
    }
}