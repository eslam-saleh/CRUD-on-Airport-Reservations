namespace Airport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Staff = new System.Windows.Forms.Button();
            this.Passenger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Staff
            // 
            this.Staff.Location = new System.Drawing.Point(72, 73);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(75, 23);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "Staff";
            this.Staff.UseVisualStyleBackColor = true;
            this.Staff.Click += new System.EventHandler(this.Staff_Click);
            // 
            // Passenger
            // 
            this.Passenger.Location = new System.Drawing.Point(72, 145);
            this.Passenger.Name = "Passenger";
            this.Passenger.Size = new System.Drawing.Size(75, 23);
            this.Passenger.TabIndex = 1;
            this.Passenger.Text = "Passenger";
            this.Passenger.UseVisualStyleBackColor = true;
            this.Passenger.Click += new System.EventHandler(this.Passenger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 240);
            this.Controls.Add(this.Passenger);
            this.Controls.Add(this.Staff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Egypt Air";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Staff;
        private System.Windows.Forms.Button Passenger;
    }
}

