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
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingNavigator)).BeginInit();
            this.groupDevicesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(16, 264);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(100, 34);
            this.insertButton.TabIndex = 0;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // devName
            // 
            this.devName.Location = new System.Drawing.Point(95, 54);
            this.devName.Name = "devName";
            this.devName.Size = new System.Drawing.Size(100, 20);
            this.devName.TabIndex = 1;
            // 
            // devIp
            // 
            this.devIp.Location = new System.Drawing.Point(95, 215);
            this.devIp.Name = "devIp";
            this.devIp.Size = new System.Drawing.Size(100, 20);
            this.devIp.TabIndex = 4;
            // 
            // modId
            // 
            this.modId.Location = new System.Drawing.Point(95, 188);
            this.modId.Name = "modId";
            this.modId.Size = new System.Drawing.Size(100, 20);
            this.modId.TabIndex = 5;
            // 
            // ctyCode
            // 
            this.ctyCode.Location = new System.Drawing.Point(95, 157);
            this.ctyCode.Name = "ctyCode";
            this.ctyCode.Size = new System.Drawing.Size(100, 20);
            this.ctyCode.TabIndex = 6;
            // 
            // pltNumber
            // 
            this.pltNumber.Location = new System.Drawing.Point(95, 124);
            this.pltNumber.Name = "pltNumber";
            this.pltNumber.Size = new System.Drawing.Size(100, 20);
            this.pltNumber.TabIndex = 7;
            // 
            // grpId
            // 
            this.grpId.Location = new System.Drawing.Point(95, 92);
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
            this.groupDevicesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupDevicesBindingNavigator.Size = new System.Drawing.Size(1207, 25);
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
            this.groupDevicesDataGridView.Location = new System.Drawing.Point(389, 28);
            this.groupDevicesDataGridView.Name = "groupDevicesDataGridView";
            this.groupDevicesDataGridView.Size = new System.Drawing.Size(741, 317);
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
            this.label1.Location = new System.Drawing.Point(13, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Device Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Group Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Plate Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "City Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Modem Id";
            // 
            // updateDev
            // 
            this.updateDev.Location = new System.Drawing.Point(147, 264);
            this.updateDev.Name = "updateDev";
            this.updateDev.Size = new System.Drawing.Size(106, 34);
            this.updateDev.TabIndex = 16;
            this.updateDev.Text = "Update";
            this.updateDev.UseVisualStyleBackColor = true;
            this.updateDev.Click += new System.EventHandler(this.updateDev_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(79, 317);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(116, 28);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 399);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesBindingNavigator)).EndInit();
            this.groupDevicesBindingNavigator.ResumeLayout(false);
            this.groupDevicesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupDevicesDataGridView)).EndInit();
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
    }
}

