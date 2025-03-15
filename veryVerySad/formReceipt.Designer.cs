namespace veryVerySad
{
    partial class formReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formReceipt));
            System.Windows.Forms.Label recId_Label;
            System.Windows.Forms.Label payId_Label;
            System.Windows.Forms.Label recDate_Label;
            System.Windows.Forms.Label recName_Label;
            System.Windows.Forms.Label recLName_Label;
            System.Windows.Forms.Label recTime_Label;
            System.Windows.Forms.Label recAmount_Label;
            this.mycafeDBDataSet = new veryVerySad.MycafeDBDataSet();
            this.receipt_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receipt_TableAdapter = new veryVerySad.MycafeDBDataSetTableAdapters.Receipt_TableAdapter();
            this.tableAdapterManager = new veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager();
            this.receipt_BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.receipt_BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.receipt_DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recId_TextBox = new System.Windows.Forms.TextBox();
            this.payId_TextBox = new System.Windows.Forms.TextBox();
            this.recDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recName_TextBox = new System.Windows.Forms.TextBox();
            this.recLName_TextBox = new System.Windows.Forms.TextBox();
            this.recTime_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.recAmount_TextBox = new System.Windows.Forms.TextBox();
            recId_Label = new System.Windows.Forms.Label();
            payId_Label = new System.Windows.Forms.Label();
            recDate_Label = new System.Windows.Forms.Label();
            recName_Label = new System.Windows.Forms.Label();
            recLName_Label = new System.Windows.Forms.Label();
            recTime_Label = new System.Windows.Forms.Label();
            recAmount_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_BindingNavigator)).BeginInit();
            this.receipt_BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mycafeDBDataSet
            // 
            this.mycafeDBDataSet.DataSetName = "MycafeDBDataSet";
            this.mycafeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // receipt_BindingSource
            // 
            this.receipt_BindingSource.DataMember = "Receipt$";
            this.receipt_BindingSource.DataSource = this.mycafeDBDataSet;
            // 
            // receipt_TableAdapter
            // 
            this.receipt_TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfirmOrder_TableAdapter = null;
            this.tableAdapterManager.Employee_TableAdapter = null;
            this.tableAdapterManager.Expenses_TableAdapter = null;
            this.tableAdapterManager.Material_TableAdapter = null;
            this.tableAdapterManager.Menu_TableAdapter = null;
            this.tableAdapterManager.Order_TableAdapter = null;
            this.tableAdapterManager.Payment_TableAdapter = null;
            this.tableAdapterManager.PurchaseOrder_TableAdapter = null;
            this.tableAdapterManager.Quotation_TableAdapter = null;
            this.tableAdapterManager.Receipt_TableAdapter = this.receipt_TableAdapter;
            this.tableAdapterManager.ReceiptOrder_TableAdapter = null;
            this.tableAdapterManager.Revenue_TableAdapter = null;
            this.tableAdapterManager.TypeMenu_TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = veryVerySad.MycafeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // receipt_BindingNavigator
            // 
            this.receipt_BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.receipt_BindingNavigator.BindingSource = this.receipt_BindingSource;
            this.receipt_BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.receipt_BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.receipt_BindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.receipt_BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.receipt_BindingNavigatorSaveItem});
            this.receipt_BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.receipt_BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.receipt_BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.receipt_BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.receipt_BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.receipt_BindingNavigator.Name = "receipt_BindingNavigator";
            this.receipt_BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.receipt_BindingNavigator.Size = new System.Drawing.Size(837, 27);
            this.receipt_BindingNavigator.TabIndex = 0;
            this.receipt_BindingNavigator.Text = "bindingNavigator1";
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
            // receipt_BindingNavigatorSaveItem
            // 
            this.receipt_BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.receipt_BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("receipt_BindingNavigatorSaveItem.Image")));
            this.receipt_BindingNavigatorSaveItem.Name = "receipt_BindingNavigatorSaveItem";
            this.receipt_BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.receipt_BindingNavigatorSaveItem.Text = "Save Data";
            this.receipt_BindingNavigatorSaveItem.Click += new System.EventHandler(this.receipt_BindingNavigatorSaveItem_Click);
            // 
            // receipt_DataGridView
            // 
            this.receipt_DataGridView.AutoGenerateColumns = false;
            this.receipt_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.receipt_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receipt_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.receipt_DataGridView.DataSource = this.receipt_BindingSource;
            this.receipt_DataGridView.Location = new System.Drawing.Point(12, 43);
            this.receipt_DataGridView.Name = "receipt_DataGridView";
            this.receipt_DataGridView.RowHeadersWidth = 51;
            this.receipt_DataGridView.RowTemplate.Height = 24;
            this.receipt_DataGridView.Size = new System.Drawing.Size(776, 220);
            this.receipt_DataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RecId ";
            this.dataGridViewTextBoxColumn1.HeaderText = "RecId ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PayId ";
            this.dataGridViewTextBoxColumn2.HeaderText = "PayId ";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RecDate ";
            this.dataGridViewTextBoxColumn3.HeaderText = "RecDate ";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RecName ";
            this.dataGridViewTextBoxColumn4.HeaderText = "RecName ";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RecLName ";
            this.dataGridViewTextBoxColumn5.HeaderText = "RecLName ";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "RecTime ";
            this.dataGridViewTextBoxColumn6.HeaderText = "RecTime ";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "RecAmount ";
            this.dataGridViewTextBoxColumn7.HeaderText = "RecAmount ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // recId_Label
            // 
            recId_Label.AutoSize = true;
            recId_Label.Location = new System.Drawing.Point(43, 306);
            recId_Label.Name = "recId_Label";
            recId_Label.Size = new System.Drawing.Size(52, 16);
            recId_Label.TabIndex = 2;
            recId_Label.Text = "Rec Id :";
            // 
            // recId_TextBox
            // 
            this.recId_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receipt_BindingSource, "RecId ", true));
            this.recId_TextBox.Location = new System.Drawing.Point(101, 303);
            this.recId_TextBox.Name = "recId_TextBox";
            this.recId_TextBox.Size = new System.Drawing.Size(100, 22);
            this.recId_TextBox.TabIndex = 3;
            // 
            // payId_Label
            // 
            payId_Label.AutoSize = true;
            payId_Label.Location = new System.Drawing.Point(265, 309);
            payId_Label.Name = "payId_Label";
            payId_Label.Size = new System.Drawing.Size(51, 16);
            payId_Label.TabIndex = 4;
            payId_Label.Text = "Pay Id :";
            // 
            // payId_TextBox
            // 
            this.payId_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receipt_BindingSource, "PayId ", true));
            this.payId_TextBox.Location = new System.Drawing.Point(322, 306);
            this.payId_TextBox.Name = "payId_TextBox";
            this.payId_TextBox.Size = new System.Drawing.Size(100, 22);
            this.payId_TextBox.TabIndex = 5;
            // 
            // recDate_Label
            // 
            recDate_Label.AutoSize = true;
            recDate_Label.Location = new System.Drawing.Point(25, 356);
            recDate_Label.Name = "recDate_Label";
            recDate_Label.Size = new System.Drawing.Size(70, 16);
            recDate_Label.TabIndex = 6;
            recDate_Label.Text = "Rec Date :";
            // 
            // recDate_DateTimePicker
            // 
            this.recDate_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receipt_BindingSource, "RecDate ", true));
            this.recDate_DateTimePicker.Location = new System.Drawing.Point(120, 352);
            this.recDate_DateTimePicker.Name = "recDate_DateTimePicker";
            this.recDate_DateTimePicker.Size = new System.Drawing.Size(181, 22);
            this.recDate_DateTimePicker.TabIndex = 7;
            // 
            // recName_Label
            // 
            recName_Label.AutoSize = true;
            recName_Label.Location = new System.Drawing.Point(338, 355);
            recName_Label.Name = "recName_Label";
            recName_Label.Size = new System.Drawing.Size(78, 16);
            recName_Label.TabIndex = 8;
            recName_Label.Text = "Rec Name :";
            // 
            // recName_TextBox
            // 
            this.recName_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receipt_BindingSource, "RecName ", true));
            this.recName_TextBox.Location = new System.Drawing.Point(422, 352);
            this.recName_TextBox.Name = "recName_TextBox";
            this.recName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.recName_TextBox.TabIndex = 9;
            // 
            // recLName_Label
            // 
            recLName_Label.AutoSize = true;
            recLName_Label.Location = new System.Drawing.Point(626, 366);
            recLName_Label.Name = "recLName_Label";
            recLName_Label.Size = new System.Drawing.Size(85, 16);
            recLName_Label.TabIndex = 10;
            recLName_Label.Text = "Rec LName :";
            // 
            // recLName_TextBox
            // 
            this.recLName_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receipt_BindingSource, "RecLName ", true));
            this.recLName_TextBox.Location = new System.Drawing.Point(717, 363);
            this.recLName_TextBox.Name = "recLName_TextBox";
            this.recLName_TextBox.Size = new System.Drawing.Size(100, 22);
            this.recLName_TextBox.TabIndex = 11;
            // 
            // recTime_Label
            // 
            recTime_Label.AutoSize = true;
            recTime_Label.Location = new System.Drawing.Point(25, 405);
            recTime_Label.Name = "recTime_Label";
            recTime_Label.Size = new System.Drawing.Size(72, 16);
            recTime_Label.TabIndex = 12;
            recTime_Label.Text = "Rec Time :";
            // 
            // recTime_DateTimePicker
            // 
            this.recTime_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.receipt_BindingSource, "RecTime ", true));
            this.recTime_DateTimePicker.Location = new System.Drawing.Point(120, 401);
            this.recTime_DateTimePicker.Name = "recTime_DateTimePicker";
            this.recTime_DateTimePicker.Size = new System.Drawing.Size(183, 22);
            this.recTime_DateTimePicker.TabIndex = 13;
            // 
            // recAmount_Label
            // 
            recAmount_Label.AutoSize = true;
            recAmount_Label.Location = new System.Drawing.Point(330, 405);
            recAmount_Label.Name = "recAmount_Label";
            recAmount_Label.Size = new System.Drawing.Size(86, 16);
            recAmount_Label.TabIndex = 14;
            recAmount_Label.Text = "Rec Amount :";
            // 
            // recAmount_TextBox
            // 
            this.recAmount_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receipt_BindingSource, "RecAmount ", true));
            this.recAmount_TextBox.Location = new System.Drawing.Point(422, 402);
            this.recAmount_TextBox.Name = "recAmount_TextBox";
            this.recAmount_TextBox.Size = new System.Drawing.Size(100, 22);
            this.recAmount_TextBox.TabIndex = 15;
            // 
            // formReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 453);
            this.Controls.Add(recAmount_Label);
            this.Controls.Add(this.recAmount_TextBox);
            this.Controls.Add(recTime_Label);
            this.Controls.Add(this.recTime_DateTimePicker);
            this.Controls.Add(recLName_Label);
            this.Controls.Add(this.recLName_TextBox);
            this.Controls.Add(recName_Label);
            this.Controls.Add(this.recName_TextBox);
            this.Controls.Add(recDate_Label);
            this.Controls.Add(this.recDate_DateTimePicker);
            this.Controls.Add(payId_Label);
            this.Controls.Add(this.payId_TextBox);
            this.Controls.Add(recId_Label);
            this.Controls.Add(this.recId_TextBox);
            this.Controls.Add(this.receipt_DataGridView);
            this.Controls.Add(this.receipt_BindingNavigator);
            this.Name = "formReceipt";
            this.Text = "formReceipt";
            this.Load += new System.EventHandler(this.formReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mycafeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_BindingNavigator)).EndInit();
            this.receipt_BindingNavigator.ResumeLayout(false);
            this.receipt_BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receipt_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MycafeDBDataSet mycafeDBDataSet;
        private System.Windows.Forms.BindingSource receipt_BindingSource;
        private MycafeDBDataSetTableAdapters.Receipt_TableAdapter receipt_TableAdapter;
        private MycafeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator receipt_BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton receipt_BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView receipt_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox recId_TextBox;
        private System.Windows.Forms.TextBox payId_TextBox;
        private System.Windows.Forms.DateTimePicker recDate_DateTimePicker;
        private System.Windows.Forms.TextBox recName_TextBox;
        private System.Windows.Forms.TextBox recLName_TextBox;
        private System.Windows.Forms.DateTimePicker recTime_DateTimePicker;
        private System.Windows.Forms.TextBox recAmount_TextBox;
    }
}