namespace veryVerySad
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.mycafeDBDataSet = new veryVerySad.MycafeDBDataSet();
            this.confirmOrder_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmOrder_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.ConfirmOrder_TableAdapter();
            this.tableAdapterManager = new veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager();
            this.confirmOrder_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.confirmOrder_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.confirmOrder_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_BindingNavigator)).BeginInit();
            this.confirmOrder_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mycafeDBDataSet
            // 
            this.mycafeDBDataSet.DataSetName = "MycafeDBDataSet";
            this.mycafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.Payment_TableAdapter = null;
            this.tableAdapterManager.PurchaseOrder_TableAdapter = null;
            this.tableAdapterManager.Quotation_TableAdapter = null;
            this.tableAdapterManager.Receipt_TableAdapter = null;
            this.tableAdapterManager.ReceiptOrder_TableAdapter = null;
            this.tableAdapterManager.Revenue_TableAdapter = null;
            this.tableAdapterManager.TypeMenu_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // confirmOrder_BindingNavigator
            // 
            this.confirmOrder_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.confirmOrder_BindingNavigator.BindingSource = this.confirmOrder_BindingSource;
            this.confirmOrder_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.confirmOrder_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.confirmOrder_BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.confirmOrder_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.confirmOrder_BindingNavigatorSaveItem});
            this.confirmOrder_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.confirmOrder_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.confirmOrder_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.confirmOrder_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.confirmOrder_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.confirmOrder_BindingNavigator.Name = "confirmOrder_BindingNavigator";
            this.confirmOrder_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.confirmOrder_BindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.confirmOrder_BindingNavigator.TabIndex = 0;
            this.confirmOrder_BindingNavigator.Text = "bindingNavigator1";
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
            // confirmOrder_BindingNavigatorSaveItem
            // 
            this.confirmOrder_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.confirmOrder_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("confirmOrder_BindingNavigatorSaveItem.Image")));
            this.confirmOrder_BindingNavigatorSaveItem.Name = "confirmOrder_BindingNavigatorSaveItem";
            this.confirmOrder_BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.confirmOrder_BindingNavigatorSaveItem.Text = "Save Data";
            this.confirmOrder_BindingNavigatorSaveItem.Click += new System.EventHandler(this.confirmOrder_BindingNavigatorSaveItem_Click);
            // 
            // confirmOrder_DataGridView
            // 
            this.confirmOrder_DataGridView.AutoGenerateColumns = false;
            this.confirmOrder_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.confirmOrder_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.confirmOrder_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.confirmOrder_DataGridView.DataSource = this.confirmOrder_BindingSource;
            this.confirmOrder_DataGridView.Location = new System.Drawing.Point(12, 42);
            this.confirmOrder_DataGridView.Name = "confirmOrder_DataGridView";
            this.confirmOrder_DataGridView.RowHeadersWidth = 51;
            this.confirmOrder_DataGridView.RowTemplate.Height = 24;
            this.confirmOrder_DataGridView.Size = new System.Drawing.Size(776, 380);
            this.confirmOrder_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CfOrderId ";
            this.dataGridViewTextBoxColumn1.HeaderText = "CfOrderId ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderId ";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderId ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CfOrderMenu ";
            this.dataGridViewTextBoxColumn3.HeaderText = "CfOrderMenu ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CfOrderTime ";
            this.dataGridViewTextBoxColumn4.HeaderText = "CfOrderTime ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmOrder_DataGridView);
            this.Controls.Add(this.confirmOrder_BindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_BindingNavigator)).EndInit();
            this.confirmOrder_BindingNavigator.ResumeLayout(false);
            this.confirmOrder_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrder_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MycafeDBDataSet mycafeDBDataSet;
        private System.Windows.Forms.BindingSource confirmOrder_BindingSource;
        private MycafeDBDataSetTableAdapters.ConfirmOrder_TableAdapter confirmOrder_TableAdapter;
        private MycafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator confirmOrder_BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton confirmOrder_BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView confirmOrder_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}