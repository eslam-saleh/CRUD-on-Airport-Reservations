namespace Airport
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pLANEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.egypt_AirDataSet = new Airport.Egypt_AirDataSet();
            this.pLANETableAdapter = new Airport.Egypt_AirDataSetTableAdapters.PLANETableAdapter();
            this.pLANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sTAFFTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.STAFFTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowFlight = new System.Windows.Forms.Button();
            this.DeleteFlight = new System.Windows.Forms.Button();
            this.UpdateFlight = new System.Windows.Forms.Button();
            this.InsertFlight = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mODELNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSSTOPDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fLIGHTTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.FLIGHTTableAdapter();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.JoinFlights = new System.Windows.Forms.Button();
            this.OperationsFlights = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pLANEBindingSource1
            // 
            this.pLANEBindingSource1.DataMember = "PLANE";
            this.pLANEBindingSource1.DataSource = this.egypt_AirDataSet;
            // 
            // egypt_AirDataSet
            // 
            this.egypt_AirDataSet.DataSetName = "Egypt_AirDataSet";
            this.egypt_AirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLANETableAdapter
            // 
            this.pLANETableAdapter.ClearBeforeFill = true;
            // 
            // pLANEBindingSource
            // 
            this.pLANEBindingSource.DataMember = "PLANE";
            this.pLANEBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(397, 263);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 63;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Flight Num";
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Stop";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Model Num";
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "From";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 55;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 54;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 53;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 51;
            // 
            // ShowFlight
            // 
            this.ShowFlight.Location = new System.Drawing.Point(697, 209);
            this.ShowFlight.Name = "ShowFlight";
            this.ShowFlight.Size = new System.Drawing.Size(75, 23);
            this.ShowFlight.TabIndex = 50;
            this.ShowFlight.Text = "Show Flights";
            this.ShowFlight.UseVisualStyleBackColor = true;
            this.ShowFlight.Click += new System.EventHandler(this.ShowFlight_Click);
            // 
            // DeleteFlight
            // 
            this.DeleteFlight.Location = new System.Drawing.Point(424, 204);
            this.DeleteFlight.Name = "DeleteFlight";
            this.DeleteFlight.Size = new System.Drawing.Size(104, 23);
            this.DeleteFlight.TabIndex = 49;
            this.DeleteFlight.Text = "Delete  Flight";
            this.DeleteFlight.UseVisualStyleBackColor = true;
            this.DeleteFlight.Click += new System.EventHandler(this.DeleteFlight_Click);
            // 
            // UpdateFlight
            // 
            this.UpdateFlight.Location = new System.Drawing.Point(289, 204);
            this.UpdateFlight.Name = "UpdateFlight";
            this.UpdateFlight.Size = new System.Drawing.Size(97, 23);
            this.UpdateFlight.TabIndex = 48;
            this.UpdateFlight.Text = "Updatet Flight";
            this.UpdateFlight.UseVisualStyleBackColor = true;
            this.UpdateFlight.Click += new System.EventHandler(this.UpdateFlight_Click);
            // 
            // InsertFlight
            // 
            this.InsertFlight.Location = new System.Drawing.Point(191, 204);
            this.InsertFlight.Name = "InsertFlight";
            this.InsertFlight.Size = new System.Drawing.Size(75, 23);
            this.InsertFlight.TabIndex = 47;
            this.InsertFlight.Text = "Insert Flight";
            this.InsertFlight.UseVisualStyleBackColor = true;
            this.InsertFlight.Click += new System.EventHandler(this.InsertFlight_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.mODELNODataGridViewTextBoxColumn,
            this.fromDataGridViewTextBoxColumn,
            this.toDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.iSSTOPDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.fLIGHTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(181, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(657, 150);
            this.dataGridView1.TabIndex = 64;
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            // 
            // mODELNODataGridViewTextBoxColumn
            // 
            this.mODELNODataGridViewTextBoxColumn.DataPropertyName = "MODEL_NO";
            this.mODELNODataGridViewTextBoxColumn.HeaderText = "MODEL_NO";
            this.mODELNODataGridViewTextBoxColumn.Name = "mODELNODataGridViewTextBoxColumn";
            // 
            // fromDataGridViewTextBoxColumn
            // 
            this.fromDataGridViewTextBoxColumn.DataPropertyName = "_From";
            this.fromDataGridViewTextBoxColumn.HeaderText = "_From";
            this.fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            // 
            // toDataGridViewTextBoxColumn
            // 
            this.toDataGridViewTextBoxColumn.DataPropertyName = "_To";
            this.toDataGridViewTextBoxColumn.HeaderText = "_To";
            this.toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "_Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "_Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // iSSTOPDataGridViewCheckBoxColumn
            // 
            this.iSSTOPDataGridViewCheckBoxColumn.DataPropertyName = "IS_STOP";
            this.iSSTOPDataGridViewCheckBoxColumn.HeaderText = "IS_STOP";
            this.iSSTOPDataGridViewCheckBoxColumn.Name = "iSSTOPDataGridViewCheckBoxColumn";
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(75, 145);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(55, 17);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "isStop";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // JoinFlights
            // 
            this.JoinFlights.Location = new System.Drawing.Point(495, 263);
            this.JoinFlights.Name = "JoinFlights";
            this.JoinFlights.Size = new System.Drawing.Size(75, 23);
            this.JoinFlights.TabIndex = 66;
            this.JoinFlights.Text = "Join Flights";
            this.JoinFlights.UseVisualStyleBackColor = true;
            this.JoinFlights.Click += new System.EventHandler(this.JoinFlights_Click);
            // 
            // OperationsFlights
            // 
            this.OperationsFlights.Location = new System.Drawing.Point(599, 263);
            this.OperationsFlights.Name = "OperationsFlights";
            this.OperationsFlights.Size = new System.Drawing.Size(75, 23);
            this.OperationsFlights.TabIndex = 67;
            this.OperationsFlights.Text = "Operations Flights";
            this.OperationsFlights.UseVisualStyleBackColor = true;
            this.OperationsFlights.Click += new System.EventHandler(this.OperationsFlights_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.OperationsFlights);
            this.Controls.Add(this.JoinFlights);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShowFlight);
            this.Controls.Add(this.DeleteFlight);
            this.Controls.Add(this.UpdateFlight);
            this.Controls.Add(this.InsertFlight);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Flights";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource pLANEBindingSource1;
        private Egypt_AirDataSet egypt_AirDataSet;
        private Egypt_AirDataSetTableAdapters.PLANETableAdapter pLANETableAdapter;
        private System.Windows.Forms.BindingSource pLANEBindingSource;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Egypt_AirDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowFlight;
        private System.Windows.Forms.Button DeleteFlight;
        private System.Windows.Forms.Button UpdateFlight;
        private System.Windows.Forms.Button InsertFlight;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Egypt_AirDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iSSTOPDataGridViewCheckBoxColumn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button JoinFlights;
        private System.Windows.Forms.Button OperationsFlights;
    }
}