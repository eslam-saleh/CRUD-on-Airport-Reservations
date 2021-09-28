namespace Airport
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.Back = new System.Windows.Forms.Button();
            this.egypt_AirDataSet = new Airport.Egypt_AirDataSet();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sTAFFTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.STAFFTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowPlane = new System.Windows.Forms.Button();
            this.DeletePlane = new System.Windows.Forms.Button();
            this.UpdatePlane = new System.Windows.Forms.Button();
            this.InsertPlane = new System.Windows.Forms.Button();
            this.pLANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANETableAdapter = new Airport.Egypt_AirDataSetTableAdapters.PLANETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mODELNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVAILABLESEATSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPANYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPEEDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLANEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(577, 259);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 45;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // egypt_AirDataSet
            // 
            this.egypt_AirDataSet.DataSetName = "Egypt_AirDataSet";
            this.egypt_AirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Speed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Type Name";
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ave Seats";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Model Num";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(78, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 29;
            // 
            // ShowPlane
            // 
            this.ShowPlane.Location = new System.Drawing.Point(700, 209);
            this.ShowPlane.Name = "ShowPlane";
            this.ShowPlane.Size = new System.Drawing.Size(75, 23);
            this.ShowPlane.TabIndex = 26;
            this.ShowPlane.Text = "Show Planes";
            this.ShowPlane.UseVisualStyleBackColor = true;
            this.ShowPlane.Click += new System.EventHandler(this.ShowStaff_Click);
            // 
            // DeletePlane
            // 
            this.DeletePlane.Location = new System.Drawing.Point(427, 204);
            this.DeletePlane.Name = "DeletePlane";
            this.DeletePlane.Size = new System.Drawing.Size(104, 23);
            this.DeletePlane.TabIndex = 25;
            this.DeletePlane.Text = "Delete  Plane";
            this.DeletePlane.UseVisualStyleBackColor = true;
            this.DeletePlane.Click += new System.EventHandler(this.DeletePlane_Click);
            // 
            // UpdatePlane
            // 
            this.UpdatePlane.Location = new System.Drawing.Point(292, 204);
            this.UpdatePlane.Name = "UpdatePlane";
            this.UpdatePlane.Size = new System.Drawing.Size(97, 23);
            this.UpdatePlane.TabIndex = 24;
            this.UpdatePlane.Text = "Updatet Plane";
            this.UpdatePlane.UseVisualStyleBackColor = true;
            this.UpdatePlane.Click += new System.EventHandler(this.UpdatePlane_Click);
            // 
            // InsertPlane
            // 
            this.InsertPlane.Location = new System.Drawing.Point(194, 204);
            this.InsertPlane.Name = "InsertPlane";
            this.InsertPlane.Size = new System.Drawing.Size(75, 23);
            this.InsertPlane.TabIndex = 23;
            this.InsertPlane.Text = "Insert Plane";
            this.InsertPlane.UseVisualStyleBackColor = true;
            this.InsertPlane.Click += new System.EventHandler(this.InsertPlane_Click);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mODELNODataGridViewTextBoxColumn,
            this.aDDRESSDataGridViewTextBoxColumn,
            this.aVAILABLESEATSDataGridViewTextBoxColumn,
            this.cOMPANYDataGridViewTextBoxColumn,
            this.tYPENAMEDataGridViewTextBoxColumn,
            this.sPEEDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pLANEBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(194, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 150);
            this.dataGridView1.TabIndex = 46;
            // 
            // mODELNODataGridViewTextBoxColumn
            // 
            this.mODELNODataGridViewTextBoxColumn.DataPropertyName = "MODEL_NO";
            this.mODELNODataGridViewTextBoxColumn.HeaderText = "MODEL_NO";
            this.mODELNODataGridViewTextBoxColumn.Name = "mODELNODataGridViewTextBoxColumn";
            // 
            // aDDRESSDataGridViewTextBoxColumn
            // 
            this.aDDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.aDDRESSDataGridViewTextBoxColumn.Name = "aDDRESSDataGridViewTextBoxColumn";
            // 
            // aVAILABLESEATSDataGridViewTextBoxColumn
            // 
            this.aVAILABLESEATSDataGridViewTextBoxColumn.DataPropertyName = "AVAILABLE_SEATS";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.HeaderText = "AVAILABLE_SEATS";
            this.aVAILABLESEATSDataGridViewTextBoxColumn.Name = "aVAILABLESEATSDataGridViewTextBoxColumn";
            // 
            // cOMPANYDataGridViewTextBoxColumn
            // 
            this.cOMPANYDataGridViewTextBoxColumn.DataPropertyName = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.HeaderText = "COMPANY";
            this.cOMPANYDataGridViewTextBoxColumn.Name = "cOMPANYDataGridViewTextBoxColumn";
            // 
            // tYPENAMEDataGridViewTextBoxColumn
            // 
            this.tYPENAMEDataGridViewTextBoxColumn.DataPropertyName = "TYPE_NAME";
            this.tYPENAMEDataGridViewTextBoxColumn.HeaderText = "TYPE_NAME";
            this.tYPENAMEDataGridViewTextBoxColumn.Name = "tYPENAMEDataGridViewTextBoxColumn";
            // 
            // sPEEDDataGridViewTextBoxColumn
            // 
            this.sPEEDDataGridViewTextBoxColumn.DataPropertyName = "SPEED";
            this.sPEEDDataGridViewTextBoxColumn.HeaderText = "SPEED";
            this.sPEEDDataGridViewTextBoxColumn.Name = "sPEEDDataGridViewTextBoxColumn";
            // 
            // pLANEBindingSource1
            // 
            this.pLANEBindingSource1.DataMember = "PLANE";
            this.pLANEBindingSource1.DataSource = this.egypt_AirDataSet;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShowPlane);
            this.Controls.Add(this.DeletePlane);
            this.Controls.Add(this.UpdatePlane);
            this.Controls.Add(this.InsertPlane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private Egypt_AirDataSet egypt_AirDataSet;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Egypt_AirDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ShowPlane;
        private System.Windows.Forms.Button DeletePlane;
        private System.Windows.Forms.Button UpdatePlane;
        private System.Windows.Forms.Button InsertPlane;
        private System.Windows.Forms.BindingSource pLANEBindingSource;
        private Egypt_AirDataSetTableAdapters.PLANETableAdapter pLANETableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mODELNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVAILABLESEATSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOMPANYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPEEDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pLANEBindingSource1;
    }
}