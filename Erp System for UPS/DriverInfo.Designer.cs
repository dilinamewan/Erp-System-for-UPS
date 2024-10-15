namespace Erp_System_for_UPS
{
    partial class DriverInfo
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
            this.Header2 = new System.Windows.Forms.Panel();
            this.DriverName = new System.Windows.Forms.Label();
            this.dataGridViewDriver = new System.Windows.Forms.DataGridView();
            this.Header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).BeginInit();
            this.SuspendLayout();
            // 
            // Header2
            // 
            this.Header2.BackColor = System.Drawing.Color.White;
            this.Header2.Controls.Add(this.DriverName);
            this.Header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header2.Location = new System.Drawing.Point(0, 0);
            this.Header2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(1067, 32);
            this.Header2.TabIndex = 4;
            // 
            // DriverName
            // 
            this.DriverName.AutoSize = true;
            this.DriverName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverName.Location = new System.Drawing.Point(28, 4);
            this.DriverName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(107, 23);
            this.DriverName.TabIndex = 0;
            this.DriverName.Text = "Driver Name";
            this.DriverName.Click += new System.EventHandler(this.DriverName_Click);
            // 
            // dataGridViewDriver
            // 
            this.dataGridViewDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDriver.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewDriver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDriver.Name = "dataGridViewDriver";
            this.dataGridViewDriver.RowHeadersWidth = 51;
            this.dataGridViewDriver.Size = new System.Drawing.Size(1067, 522);
            this.dataGridViewDriver.TabIndex = 5;
            this.dataGridViewDriver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriver_CellContentClick);
            // 
            // DriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridViewDriver);
            this.Controls.Add(this.Header2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DriverInfo";
            this.Text = "DriverInfo";
            this.Load += new System.EventHandler(this.DriverInfo_Load);
            this.Header2.ResumeLayout(false);
            this.Header2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDriver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header2;
        private System.Windows.Forms.Label DriverName;
        private System.Windows.Forms.DataGridView dataGridViewDriver;
    }
}