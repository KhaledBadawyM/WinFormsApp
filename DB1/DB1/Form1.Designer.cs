namespace DB1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.insertButton = new System.Windows.Forms.Button();
            this.devName = new System.Windows.Forms.TextBox();
            this.devIp = new System.Windows.Forms.TextBox();
            this.modId = new System.Windows.Forms.TextBox();
            this.ctyCode = new System.Windows.Forms.TextBox();
            this.pltNumber = new System.Windows.Forms.TextBox();
            this.grpId = new System.Windows.Forms.TextBox();
            this.database1DataSet = new DB1.Database1DataSet();
            this.groupDevicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupDevicesTableAdapter = new DB1.Database1DataSetTableAdapters.groupDevicesTableAdapter();
            this.tableAdapterManager = new DB1.Database1DataSetTableAdapters.TableAdapterManager();
            this.groupDevicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupDevicesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupDevicesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateDev = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.database1DataSet1 = new DB1.Database1DataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DB1.Database1DataSet1TableAdapters.usersTableAdapter();
            this.tableAdapterManager1 = new DB1.Database1DataSet1TableAdapters.TableAdapterManager();
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._username = new System.Windows.Forms.TextBox();
            this._password = new System.Windows.Forms.TextBox();
            this._privilege = new System.Windows.Forms.TextBox();
            this._groupid = new System.Windows.Forms.TextBox();
            this.insertUser = new System.Windows.Forms.Button();
            this.database1DataSet2 = new DB1.Database1DataSet2();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new DB1.Database1DataSet2TableAdapters.GroupsTableAdapter();
            this.tableAdapterManager2 = new DB1.Database1DataSet2TableAdapters.TableAdapterManager();
            this.groupsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGroup = new System.Windows.Forms.Button();
            this.updateGroup = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this._groupName = new System.Windows.Forms.TextBox();
            this._allowed = new System.Windows.Forms.TextBox();
            this._login = new System.Windows.Forms.TextBox();
            this._name = new System.Windows.Forms.TextBox();
            this.insertGroup = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this._desc = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingNavigator)).BeginInit();
            this.groupDevicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(22, 290);
            this.insertButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 33);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // devName
            // 
            this.devName.Location = new System.Drawing.Point(102, 92);
            this.devName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devName.Name = "devName";
            this.devName.Size = new System.Drawing.Size(100, 20);
            this.devName.TabIndex = 1;
            // 
            // devIp
            // 
            this.devIp.Location = new System.Drawing.Point(102, 255);
            this.devIp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.devIp.Name = "devIp";
            this.devIp.Size = new System.Drawing.Size(100, 20);
            this.devIp.TabIndex = 4;
            // 
            // modId
            // 
            this.modId.Location = new System.Drawing.Point(102, 229);
            this.modId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modId.Name = "modId";
            this.modId.Size = new System.Drawing.Size(100, 20);
            this.modId.TabIndex = 5;
            // 
            // ctyCode
            // 
            this.ctyCode.Location = new System.Drawing.Point(102, 196);
            this.ctyCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctyCode.Name = "ctyCode";
            this.ctyCode.Size = new System.Drawing.Size(100, 20);
            this.ctyCode.TabIndex = 6;
            // 
            // pltNumber
            // 
            this.pltNumber.Location = new System.Drawing.Point(102, 164);
            this.pltNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pltNumber.Name = "pltNumber";
            this.pltNumber.Size = new System.Drawing.Size(100, 20);
            this.pltNumber.TabIndex = 7;
            // 
            // grpId
            // 
            this.grpId.Location = new System.Drawing.Point(102, 131);
            this.grpId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpId.Name = "grpId";
            this.grpId.Size = new System.Drawing.Size(100, 20);
            this.grpId.TabIndex = 8;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupDevicesBindingSource
            // 
            this.groupDevicesBindingSource.DataMember = "groupDevices";
            this.groupDevicesBindingSource.DataSource = this.database1DataSet;
            // 
            // groupDevicesTableAdapter
            // 
            this.groupDevicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.groupDevicesTableAdapter = this.groupDevicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = DB1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupDevicesBindingNavigator
            // 
            this.groupDevicesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupDevicesBindingNavigator.BindingSource = this.groupDevicesBindingSource;
            this.groupDevicesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupDevicesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupDevicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.groupDevicesBindingNavigatorSaveItem});
            this.groupDevicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupDevicesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupDevicesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupDevicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupDevicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupDevicesBindingNavigator.Name = "groupDevicesBindingNavigator";
            this.groupDevicesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.groupDevicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupDevicesBindingNavigator.Size = new System.Drawing.Size(1168, 25);
            this.groupDevicesBindingNavigator.TabIndex = 9;
            this.groupDevicesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupDevicesBindingNavigatorSaveItem
            // 
            this.groupDevicesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupDevicesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupDevicesBindingNavigatorSaveItem.Image")));
            this.groupDevicesBindingNavigatorSaveItem.Name = "groupDevicesBindingNavigatorSaveItem";
            this.groupDevicesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.groupDevicesBindingNavigatorSaveItem.Text = "Save Data";
            this.groupDevicesBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupDevicesBindingNavigatorSaveItem_Click);
            // 
            // groupDevicesDataGridView
            // 
            this.groupDevicesDataGridView.AutoGenerateColumns = false;
            this.groupDevicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupDevicesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.groupDevicesDataGridView.DataSource = this.groupDevicesBindingSource;
            this.groupDevicesDataGridView.Location = new System.Drawing.Point(388, 92);
            this.groupDevicesDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDevicesDataGridView.Name = "groupDevicesDataGridView";
            this.groupDevicesDataGridView.Size = new System.Drawing.Size(750, 300);
            this.groupDevicesDataGridView.TabIndex = 9;
            this.groupDevicesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupDevicesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "deviceId";
            this.dataGridViewTextBoxColumn1.HeaderText = "deviceId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "deviceName";
            this.dataGridViewTextBoxColumn2.HeaderText = "deviceName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "groupid";
            this.dataGridViewTextBoxColumn3.HeaderText = "groupid";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "platenumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "platenumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "citycode";
            this.dataGridViewTextBoxColumn5.HeaderText = "citycode";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "modemid";
            this.dataGridViewTextBoxColumn6.HeaderText = "modemid";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IP";
            this.dataGridViewTextBoxColumn7.HeaderText = "IP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Group Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Plate Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "City Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modem Id";
            // 
            // updateDev
            // 
            this.updateDev.Location = new System.Drawing.Point(154, 290);
            this.updateDev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateDev.Name = "updateDev";
            this.updateDev.Size = new System.Drawing.Size(106, 33);
            this.updateDev.TabIndex = 16;
            this.updateDev.Text = "Update";
            this.updateDev.UseVisualStyleBackColor = true;
            this.updateDev.Click += new System.EventHandler(this.updateDev_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(86, 344);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 28);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.database1DataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = DB1.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = this.usersTableAdapter;
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.usersDataGridView.DataSource = this.usersBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(388, 456);
            this.usersDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.Size = new System.Drawing.Size(750, 300);
            this.usersDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "userId";
            this.dataGridViewTextBoxColumn8.HeaderText = "userId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "userName";
            this.dataGridViewTextBoxColumn9.HeaderText = "userName";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn10.HeaderText = "password";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "privilege";
            this.dataGridViewTextBoxColumn11.HeaderText = "privilege";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "groupId";
            this.dataGridViewTextBoxColumn12.HeaderText = "groupId";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(122, 679);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(116, 28);
            this.deleteUser.TabIndex = 32;
            this.deleteUser.Text = "Delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(190, 625);
            this.updateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(106, 33);
            this.updateUser.TabIndex = 31;
            this.updateUser.Text = "Update";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 560);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Group ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 532);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Privilege";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(54, 501);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 464);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "User Name";
            // 
            // _username
            // 
            this._username.Location = new System.Drawing.Point(138, 462);
            this._username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._username.Name = "_username";
            this._username.Size = new System.Drawing.Size(100, 20);
            this._username.TabIndex = 24;
            // 
            // _password
            // 
            this._password.Location = new System.Drawing.Point(138, 493);
            this._password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._password.Name = "_password";
            this._password.Size = new System.Drawing.Size(100, 20);
            this._password.TabIndex = 23;
            // 
            // _privilege
            // 
            this._privilege.Location = new System.Drawing.Point(138, 527);
            this._privilege.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._privilege.Name = "_privilege";
            this._privilege.Size = new System.Drawing.Size(100, 20);
            this._privilege.TabIndex = 22;
            // 
            // _groupid
            // 
            this._groupid.Location = new System.Drawing.Point(138, 555);
            this._groupid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupid.Name = "_groupid";
            this._groupid.Size = new System.Drawing.Size(100, 20);
            this._groupid.TabIndex = 21;
            // 
            // insertUser
            // 
            this.insertUser.Location = new System.Drawing.Point(58, 625);
            this.insertUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertUser.Name = "insertUser";
            this.insertUser.Size = new System.Drawing.Size(100, 33);
            this.insertUser.TabIndex = 18;
            this.insertUser.Text = "Insert";
            this.insertUser.UseVisualStyleBackColor = true;
            this.insertUser.Click += new System.EventHandler(this.insertUser_Click);
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.database1DataSet2;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager2.UpdateOrder = DB1.Database1DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupsDataGridView
            // 
            this.groupsDataGridView.AutoGenerateColumns = false;
            this.groupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.groupsDataGridView.DataSource = this.groupsBindingSource;
            this.groupsDataGridView.Location = new System.Drawing.Point(388, 778);
            this.groupsDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.groupsDataGridView.Name = "groupsDataGridView";
            this.groupsDataGridView.Size = new System.Drawing.Size(750, 300);
            this.groupsDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "groupname";
            this.dataGridViewTextBoxColumn14.HeaderText = "groupname";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "allowedlogin";
            this.dataGridViewTextBoxColumn15.HeaderText = "allowedlogin";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn16.HeaderText = "login";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn17.HeaderText = "Name";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn18.HeaderText = "Description";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // deleteGroup
            // 
            this.deleteGroup.Location = new System.Drawing.Point(122, 1023);
            this.deleteGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteGroup.Name = "deleteGroup";
            this.deleteGroup.Size = new System.Drawing.Size(116, 28);
            this.deleteGroup.TabIndex = 43;
            this.deleteGroup.Text = "Delete";
            this.deleteGroup.UseVisualStyleBackColor = true;
            this.deleteGroup.Click += new System.EventHandler(this.deleteGroup_Click);
            // 
            // updateGroup
            // 
            this.updateGroup.Location = new System.Drawing.Point(190, 969);
            this.updateGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.updateGroup.Name = "updateGroup";
            this.updateGroup.Size = new System.Drawing.Size(106, 33);
            this.updateGroup.TabIndex = 42;
            this.updateGroup.Text = "Update";
            this.updateGroup.UseVisualStyleBackColor = true;
            this.updateGroup.Click += new System.EventHandler(this.updateGroup_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 904);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 876);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Login";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(54, 841);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Allowed Login";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(56, 807);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Group Name";
            // 
            // _groupName
            // 
            this._groupName.Location = new System.Drawing.Point(138, 802);
            this._groupName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupName.Name = "_groupName";
            this._groupName.Size = new System.Drawing.Size(100, 20);
            this._groupName.TabIndex = 37;
            // 
            // _allowed
            // 
            this._allowed.Location = new System.Drawing.Point(138, 837);
            this._allowed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._allowed.Name = "_allowed";
            this._allowed.Size = new System.Drawing.Size(100, 20);
            this._allowed.TabIndex = 36;
            // 
            // _login
            // 
            this._login.Location = new System.Drawing.Point(138, 867);
            this._login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._login.Name = "_login";
            this._login.Size = new System.Drawing.Size(100, 20);
            this._login.TabIndex = 35;
            // 
            // _name
            // 
            this._name.Location = new System.Drawing.Point(138, 900);
            this._name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(100, 20);
            this._name.TabIndex = 34;
            // 
            // insertGroup
            // 
            this.insertGroup.Location = new System.Drawing.Point(58, 969);
            this.insertGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertGroup.Name = "insertGroup";
            this.insertGroup.Size = new System.Drawing.Size(100, 33);
            this.insertGroup.TabIndex = 33;
            this.insertGroup.Text = "Insert";
            this.insertGroup.UseVisualStyleBackColor = true;
            this.insertGroup.Click += new System.EventHandler(this.insertGroup_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 930);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Description";
            // 
            // _desc
            // 
            this._desc.Location = new System.Drawing.Point(138, 926);
            this._desc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._desc.Name = "_desc";
            this._desc.Size = new System.Drawing.Size(100, 20);
            this._desc.TabIndex = 44;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 425);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(877, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "_________________________________________________________________________________" +
    "________________________________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 761);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(889, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 37);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 31);
            this.label18.TabIndex = 48;
            this.label18.Text = "Group Devices";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 68);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(889, 13);
            this.label19.TabIndex = 49;
            this.label19.Text = "_________________________________________________________________________________" +
    "__________________________________________________________________";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 395);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 31);
            this.label20.TabIndex = 50;
            this.label20.Text = "Users";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(14, 729);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(103, 31);
            this.label21.TabIndex = 51;
            this.label21.Text = "Groups";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1185, 749);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this._desc);
            this.Controls.Add(this.deleteGroup);
            this.Controls.Add(this.updateGroup);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this._groupName);
            this.Controls.Add(this._allowed);
            this.Controls.Add(this._login);
            this.Controls.Add(this._name);
            this.Controls.Add(this.insertGroup);
            this.Controls.Add(this.groupsDataGridView);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this._username);
            this.Controls.Add(this._password);
            this.Controls.Add(this._privilege);
            this.Controls.Add(this._groupid);
            this.Controls.Add(this.insertUser);
            this.Controls.Add(this.usersDataGridView);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.updateDev);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDevicesDataGridView);
            this.Controls.Add(this.groupDevicesBindingNavigator);
            this.Controls.Add(this.grpId);
            this.Controls.Add(this.pltNumber);
            this.Controls.Add(this.ctyCode);
            this.Controls.Add(this.modId);
            this.Controls.Add(this.devIp);
            this.Controls.Add(this.devName);
            this.Controls.Add(this.insertButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingNavigator)).EndInit();
            this.groupDevicesBindingNavigator.ResumeLayout(false);
            this.groupDevicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.TextBox devName;
        private System.Windows.Forms.TextBox devIp;
        private System.Windows.Forms.TextBox modId;
        private System.Windows.Forms.TextBox ctyCode;
        private System.Windows.Forms.TextBox pltNumber;
        private System.Windows.Forms.TextBox grpId;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource groupDevicesBindingSource;
        private Database1DataSetTableAdapters.groupDevicesTableAdapter groupDevicesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupDevicesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton groupDevicesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView groupDevicesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateDev;
        private System.Windows.Forms.Button buttonDelete;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Database1DataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _username;
        private System.Windows.Forms.TextBox _password;
        private System.Windows.Forms.TextBox _privilege;
        private System.Windows.Forms.TextBox _groupid;
        private System.Windows.Forms.Button insertUser;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private Database1DataSet2TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private Database1DataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.DataGridView groupsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.Button deleteGroup;
        private System.Windows.Forms.Button updateGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox _groupName;
        private System.Windows.Forms.TextBox _allowed;
        private System.Windows.Forms.TextBox _login;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Button insertGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox _desc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
    }
}

