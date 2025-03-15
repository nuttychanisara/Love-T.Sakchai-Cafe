namespace veryVerySad
{
    partial class formOrder1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formOrder1));
            System.Windows.Forms.Label orderId_Label;
            System.Windows.Forms.Label menuName_Label;
            this.mycafeDBDataSet = new veryVerySad.MycafeDBDataSet();
            this.order_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Order_TableAdapter();
            this.tableAdapterManager = new veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager();
            this.order_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.order_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.order_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderId_TextBox = new System.Windows.Forms.TextBox();
            this.menu_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menu_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Menu_TableAdapter();
            this.menuName_TextBox = new System.Windows.Forms.TextBox();
            orderId_Label = new System.Windows.Forms.Label();
            menuName_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_BindingNavigator)).BeginInit();
            this.order_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mycafeDBDataSet
            // 
            this.mycafeDBDataSet.DataSetName = "MycafeDBDataSet";
            this.mycafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_BindingSource
            // 
            this.order_BindingSource.DataMember = "Order$";
            this.order_BindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // order_TableAdapter
            // 
            this.order_TableAdapter.ClearBeforeFill = true;
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
            // order_BindingNavigator
            // 
            this.order_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.order_BindingNavigator.BindingSource = this.order_BindingSource;
            this.order_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.order_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.order_BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.order_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.order_BindingNavigatorSaveItem});
            this.order_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.order_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.order_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.order_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.order_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.order_BindingNavigator.Name = "order_BindingNavigator";
            this.order_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.order_BindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.order_BindingNavigator.TabIndex = 0;
            this.order_BindingNavigator.Text = "bindingNavigator1";
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
            // order_BindingNavigatorSaveItem
            // 
            this.order_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.order_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("order_BindingNavigatorSaveItem.Image")));
            this.order_BindingNavigatorSaveItem.Name = "order_BindingNavigatorSaveItem";
            this.order_BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.order_BindingNavigatorSaveItem.Text = "Save Data";
            this.order_BindingNavigatorSaveItem.Click += new System.EventHandler(this.order_BindingNavigatorSaveItem_Click);
            // 
            // order_DataGridView
            // 
            this.order_DataGridView.AutoGenerateColumns = false;
            this.order_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.order_DataGridView.DataSource = this.order_BindingSource;
            this.order_DataGridView.Location = new System.Drawing.Point(22, 53);
            this.order_DataGridView.Name = "order_DataGridView";
            this.order_DataGridView.RowHeadersWidth = 51;
            this.order_DataGridView.RowTemplate.Height = 24;
            this.order_DataGridView.Size = new System.Drawing.Size(677, 220);
            this.order_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderId ";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderId ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MenuId ";
            this.dataGridViewTextBoxColumn2.HeaderText = "MenuId ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OrderUnit ";
            this.dataGridViewTextBoxColumn3.HeaderText = "OrderUnit ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "OrderTime ";
            this.dataGridViewTextBoxColumn5.HeaderText = "OrderTime ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // orderId_Label
            // 
            orderId_Label.AutoSize = true;
            orderId_Label.Location = new System.Drawing.Point(57, 310);
            orderId_Label.Name = "orderId_Label";
            orderId_Label.Size = new System.Drawing.Size(61, 16);
            orderId_Label.TabIndex = 2;
            orderId_Label.Text = "Order Id :";
            // 
            // orderId_TextBox
            // 
            this.orderId_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_BindingSource, "OrderId ", true));
            this.orderId_TextBox.Location = new System.Drawing.Point(124, 307);
            this.orderId_TextBox.Name = "orderId_TextBox";
            this.orderId_TextBox.Size = new System.Drawing.Size(100, 22);
            this.orderId_TextBox.TabIndex = 3;
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
            // menuName_Label
            // 
            menuName_Label.AutoSize = true;
            menuName_Label.Location = new System.Drawing.Point(287, 310);
            menuName_Label.Name = "menuName_Label";
            menuName_Label.Size = new System.Drawing.Size(86, 16);
            menuName_Label.TabIndex = 4;
            menuName_Label.Text = "Menu Name :";
            // 
            // menuName_TextBox
            // 
            this.menuName_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.menu_BindingSource, "MenuName ", true));
            this.menuName_TextBox.Location = new System.Drawing.Point(379, 307);
            this.menuName_TextBox.Name = "menuName_TextBox";
            this.menuName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.menuName_TextBox.TabIndex = 5;
            // 
            // formOrder1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(menuName_Label);
            this.Controls.Add(this.menuName_TextBox);
            this.Controls.Add(orderId_Label);
            this.Controls.Add(this.orderId_TextBox);
            this.Controls.Add(this.order_DataGridView);
            this.Controls.Add(this.order_BindingNavigator);
            this.Name = "formOrder1";
            this.Text = "formOrder1";
            this.Load += new System.EventHandler(this.formOrder1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_BindingNavigator)).EndInit();
            this.order_BindingNavigator.ResumeLayout(false);
            this.order_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MycafeDBDataSet mycafeDBDataSet;
        private System.Windows.Forms.BindingSource order_BindingSource;
        private MycafeDBDataSetTableAdapters.Order_TableAdapter order_TableAdapter;
        private MycafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator order_BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton order_BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView order_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MycafeDBDataSetTableAdapters.Menu_TableAdapter menu_TableAdapter;
        private System.Windows.Forms.TextBox orderId_TextBox;
        private System.Windows.Forms.BindingSource menu_BindingSource;
        private System.Windows.Forms.TextBox menuName_TextBox;
    }
}