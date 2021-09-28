namespace Airport
{
    partial class Form8
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.Back = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Egypt_AirDataSet = new Airport.Egypt_AirDataSet();
            this.STAFFBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.STAFFTableAdapter = new Airport.Egypt_AirDataSetTableAdapters.STAFFTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Egypt_AirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAFFBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(592, 245);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 66;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.STAFFBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Airport.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(153, 38);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 67;
            this.reportViewer1.Load += new System.EventHandler(this.ReportViewer1_Load);
            // 
            // Egypt_AirDataSet
            // 
            this.Egypt_AirDataSet.DataSetName = "Egypt_AirDataSet";
            this.Egypt_AirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STAFFBindingSource
            // 
            this.STAFFBindingSource.DataMember = "STAFF";
            this.STAFFBindingSource.DataSource = this.Egypt_AirDataSet;
            // 
            // STAFFTableAdapter
            // 
            this.STAFFTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "Report1";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Egypt_AirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STAFFBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource STAFFBindingSource;
        private Egypt_AirDataSet Egypt_AirDataSet;
        private Egypt_AirDataSetTableAdapters.STAFFTableAdapter STAFFTableAdapter;
    }
}