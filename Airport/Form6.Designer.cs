namespace Airport
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label mODEL_NOLabel;
            this.egypt_AirDataSet = new Airport.Egypt_AirDataSet();
            this.pLANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANETableAdapter = new Airport.Egypt_AirDataSetTableAdapters.PLANETableAdapter();
            this.tableAdapterManager = new Airport.Egypt_AirDataSetTableAdapters.TableAdapterManager();
            this.pLANEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pLANEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mODEL_NOTextBox = new System.Windows.Forms.TextBox();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.FLIGHTTableAdapter();
            this.fLIGHTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Back = new System.Windows.Forms.Button();
            mODEL_NOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingNavigator)).BeginInit();
            this.pLANEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // egypt_AirDataSet
            // 
            this.egypt_AirDataSet.DataSetName = "Egypt_AirDataSet";
            this.egypt_AirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLANEBindingSource
            // 
            this.pLANEBindingSource.DataMember = "PLANE";
            this.pLANEBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // pLANETableAdapter
            // 
            this.pLANETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AIRPORTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAGTableAdapter = null;
            this.tableAdapterManager.EMPLOYEE_SHIFTTableAdapter = null;
            this.tableAdapterManager.FLIGHTTableAdapter = this.fLIGHTTableAdapter;
            this.tableAdapterManager.PASSENGERTableAdapter = null;
            this.tableAdapterManager.PLANETableAdapter = this.pLANETableAdapter;
            this.tableAdapterManager.RESERVETableAdapter = null;
            this.tableAdapterManager.STAFFTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Airport.Egypt_AirDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pLANEBindingNavigator
            // 
            this.pLANEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pLANEBindingNavigator.BindingSource = this.pLANEBindingSource;
            this.pLANEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pLANEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pLANEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pLANEBindingNavigatorSaveItem});
            this.pLANEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pLANEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pLANEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pLANEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pLANEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pLANEBindingNavigator.Name = "pLANEBindingNavigator";
            this.pLANEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pLANEBindingNavigator.Size = new System.Drawing.Size(716, 25);
            this.pLANEBindingNavigator.TabIndex = 0;
            this.pLANEBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
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
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pLANEBindingNavigatorSaveItem
            // 
            this.pLANEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pLANEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pLANEBindingNavigatorSaveItem.Image")));
            this.pLANEBindingNavigatorSaveItem.Name = "pLANEBindingNavigatorSaveItem";
            this.pLANEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pLANEBindingNavigatorSaveItem.Text = "Save Data";
            this.pLANEBindingNavigatorSaveItem.Click += new System.EventHandler(this.PLANEBindingNavigatorSaveItem_Click);
            // 
            // mODEL_NOLabel
            // 
            mODEL_NOLabel.AutoSize = true;
            mODEL_NOLabel.Location = new System.Drawing.Point(186, 31);
            mODEL_NOLabel.Name = "mODEL_NOLabel";
            mODEL_NOLabel.Size = new System.Drawing.Size(67, 13);
            mODEL_NOLabel.TabIndex = 1;
            mODEL_NOLabel.Text = "MODEL NO:";
            // 
            // mODEL_NOTextBox
            // 
            this.mODEL_NOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pLANEBindingSource, "MODEL_NO", true));
            this.mODEL_NOTextBox.Location = new System.Drawing.Point(297, 28);
            this.mODEL_NOTextBox.Name = "mODEL_NOTextBox";
            this.mODEL_NOTextBox.Size = new System.Drawing.Size(100, 20);
            this.mODEL_NOTextBox.TabIndex = 2;
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FK_FLIGHT_FLY_ON_PLANE";
            this.fLIGHTBindingSource.DataSource = this.pLANEBindingSource;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // fLIGHTDataGridView
            // 
            this.fLIGHTDataGridView.AutoGenerateColumns = false;
            this.fLIGHTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fLIGHTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.fLIGHTDataGridView.DataSource = this.fLIGHTBindingSource;
            this.fLIGHTDataGridView.Location = new System.Drawing.Point(52, 54);
            this.fLIGHTDataGridView.Name = "fLIGHTDataGridView";
            this.fLIGHTDataGridView.Size = new System.Drawing.Size(650, 111);
            this.fLIGHTDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FLIGHT_NO";
            this.dataGridViewTextBoxColumn1.HeaderText = "FLIGHT_NO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MODEL_NO";
            this.dataGridViewTextBoxColumn2.HeaderText = "MODEL_NO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "_From";
            this.dataGridViewTextBoxColumn3.HeaderText = "_From";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "_To";
            this.dataGridViewTextBoxColumn4.HeaderText = "_To";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "_Time";
            this.dataGridViewTextBoxColumn5.HeaderText = "_Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IS_STOP";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IS_STOP";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(607, 26);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 66;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 182);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.fLIGHTDataGridView);
            this.Controls.Add(mODEL_NOLabel);
            this.Controls.Add(this.mODEL_NOTextBox);
            this.Controls.Add(this.pLANEBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Join";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingNavigator)).EndInit();
            this.pLANEBindingNavigator.ResumeLayout(false);
            this.pLANEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Egypt_AirDataSet egypt_AirDataSet;
        private System.Windows.Forms.BindingSource pLANEBindingSource;
        private Egypt_AirDataSetTableAdapters.PLANETableAdapter pLANETableAdapter;
        private Egypt_AirDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pLANEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pLANEBindingNavigatorSaveItem;
        private Egypt_AirDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.TextBox mODEL_NOTextBox;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private System.Windows.Forms.DataGridView fLIGHTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button Back;
    }
}