namespace Airport
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.fLIGHTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.egypt_AirDataSet = new Airport.Egypt_AirDataSet();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DeletePassenger = new System.Windows.Forms.Button();
            this.UpdatePassenger = new System.Windows.Forms.Button();
            this.InsertPassenger = new System.Windows.Forms.Button();
            this.fLIGHTTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.FLIGHTTableAdapter();
            this.sTAFFTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.STAFFTableAdapter();
            this.sTAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pLANETableAdapter = new Airport.Egypt_AirDataSetTableAdapters.PLANETableAdapter();
            this.ShowPassenger = new System.Windows.Forms.Button();
            this.pLANEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pASSPORTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLIGHTNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sOURCEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESTINATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pASSENGERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pASSENGERTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.PASSENGERTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSENGERBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fLIGHTBindingSource
            // 
            this.fLIGHTBindingSource.DataMember = "FLIGHT";
            this.fLIGHTBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // egypt_AirDataSet
            // 
            this.egypt_AirDataSet.DataSetName = "Egypt_AirDataSet";
            this.egypt_AirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(572, 259);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 81;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "Flight Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Source";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(73, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 74;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 76;
            this.label2.Text = "Passport ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(73, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 72;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 70;
            // 
            // DeletePassenger
            // 
            this.DeletePassenger.Location = new System.Drawing.Point(438, 184);
            this.DeletePassenger.Name = "DeletePassenger";
            this.DeletePassenger.Size = new System.Drawing.Size(104, 23);
            this.DeletePassenger.TabIndex = 68;
            this.DeletePassenger.Text = "Delete  Passenger";
            this.DeletePassenger.UseVisualStyleBackColor = true;
            this.DeletePassenger.Click += new System.EventHandler(this.DeletePassenger_Click);
            // 
            // UpdatePassenger
            // 
            this.UpdatePassenger.Location = new System.Drawing.Point(318, 184);
            this.UpdatePassenger.Name = "UpdatePassenger";
            this.UpdatePassenger.Size = new System.Drawing.Size(97, 23);
            this.UpdatePassenger.TabIndex = 67;
            this.UpdatePassenger.Text = "Updatet Passenger";
            this.UpdatePassenger.UseVisualStyleBackColor = true;
            this.UpdatePassenger.Click += new System.EventHandler(this.UpdatePassenger_Click);
            // 
            // InsertPassenger
            // 
            this.InsertPassenger.Location = new System.Drawing.Point(220, 184);
            this.InsertPassenger.Name = "InsertPassenger";
            this.InsertPassenger.Size = new System.Drawing.Size(75, 23);
            this.InsertPassenger.TabIndex = 66;
            this.InsertPassenger.Text = "Insert Passenger";
            this.InsertPassenger.UseVisualStyleBackColor = true;
            this.InsertPassenger.Click += new System.EventHandler(this.InsertPassenger_Click);
            // 
            // fLIGHTTableAdapter
            // 
            this.fLIGHTTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFTableAdapter
            // 
            this.sTAFFTableAdapter.ClearBeforeFill = true;
            // 
            // sTAFFBindingSource
            // 
            this.sTAFFBindingSource.DataMember = "STAFF";
            this.sTAFFBindingSource.DataSource = this.egypt_AirDataSet;
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
            // ShowPassenger
            // 
            this.ShowPassenger.Location = new System.Drawing.Point(695, 209);
            this.ShowPassenger.Name = "ShowPassenger";
            this.ShowPassenger.Size = new System.Drawing.Size(131, 23);
            this.ShowPassenger.TabIndex = 69;
            this.ShowPassenger.Text = "Show Passengers";
            this.ShowPassenger.UseVisualStyleBackColor = true;
            this.ShowPassenger.Click += new System.EventHandler(this.ShowPassenger_Click);
            // 
            // pLANEBindingSource1
            // 
            this.pLANEBindingSource1.DataMember = "PLANE";
            this.pLANEBindingSource1.DataSource = this.egypt_AirDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pASSPORTIDDataGridViewTextBoxColumn,
            this.fLIGHTNODataGridViewTextBoxColumn,
            this.sOURCEDataGridViewTextBoxColumn,
            this.dESTINATIONDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.sEXDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pASSENGERBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(189, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 148);
            this.dataGridView1.TabIndex = 84;
            // 
            // pASSPORTIDDataGridViewTextBoxColumn
            // 
            this.pASSPORTIDDataGridViewTextBoxColumn.DataPropertyName = "PASSPORT_ID";
            this.pASSPORTIDDataGridViewTextBoxColumn.HeaderText = "PASSPORT_ID";
            this.pASSPORTIDDataGridViewTextBoxColumn.Name = "pASSPORTIDDataGridViewTextBoxColumn";
            // 
            // fLIGHTNODataGridViewTextBoxColumn
            // 
            this.fLIGHTNODataGridViewTextBoxColumn.DataPropertyName = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.HeaderText = "FLIGHT_NO";
            this.fLIGHTNODataGridViewTextBoxColumn.Name = "fLIGHTNODataGridViewTextBoxColumn";
            // 
            // sOURCEDataGridViewTextBoxColumn
            // 
            this.sOURCEDataGridViewTextBoxColumn.DataPropertyName = "SOURCE";
            this.sOURCEDataGridViewTextBoxColumn.HeaderText = "SOURCE";
            this.sOURCEDataGridViewTextBoxColumn.Name = "sOURCEDataGridViewTextBoxColumn";
            // 
            // dESTINATIONDataGridViewTextBoxColumn
            // 
            this.dESTINATIONDataGridViewTextBoxColumn.DataPropertyName = "DESTINATION";
            this.dESTINATIONDataGridViewTextBoxColumn.HeaderText = "DESTINATION";
            this.dESTINATIONDataGridViewTextBoxColumn.Name = "dESTINATIONDataGridViewTextBoxColumn";
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            // 
            // sEXDataGridViewTextBoxColumn
            // 
            this.sEXDataGridViewTextBoxColumn.DataPropertyName = "SEX";
            this.sEXDataGridViewTextBoxColumn.HeaderText = "SEX";
            this.sEXDataGridViewTextBoxColumn.Name = "sEXDataGridViewTextBoxColumn";
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            // 
            // pASSENGERBindingSource
            // 
            this.pASSENGERBindingSource.DataMember = "PASSENGER";
            this.pASSENGERBindingSource.DataSource = this.egypt_AirDataSet;
            // 
            // pASSENGERTableAdapter
            // 
            this.pASSENGERTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(73, 142);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 86;
            this.label7.Text = "Phone";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(24, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 87;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(95, 22);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 88;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(13, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 49);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeletePassenger);
            this.Controls.Add(this.UpdatePassenger);
            this.Controls.Add(this.InsertPassenger);
            this.Controls.Add(this.ShowPassenger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Passengers";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fLIGHTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egypt_AirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTAFFBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLANEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pASSENGERBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource fLIGHTBindingSource;
        private Egypt_AirDataSet egypt_AirDataSet;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DeletePassenger;
        private System.Windows.Forms.Button UpdatePassenger;
        private System.Windows.Forms.Button InsertPassenger;
        private Egypt_AirDataSetTableAdapters.FLIGHTTableAdapter fLIGHTTableAdapter;
        private Egypt_AirDataSetTableAdapters.STAFFTableAdapter sTAFFTableAdapter;
        private System.Windows.Forms.BindingSource sTAFFBindingSource;
        private System.Windows.Forms.BindingSource pLANEBindingSource;
        private Egypt_AirDataSetTableAdapters.PLANETableAdapter pLANETableAdapter;
        private System.Windows.Forms.Button ShowPassenger;
        private System.Windows.Forms.BindingSource pLANEBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pASSENGERBindingSource;
        private Egypt_AirDataSetTableAdapters.PASSENGERTableAdapter pASSENGERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pASSPORTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLIGHTNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sOURCEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESTINATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}