namespace Erp_System_for_UPS
{
    partial class VehicleInfo
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
            this.VehicleVIN = new System.Windows.Forms.Label();
            this.dataGridViewVehicle = new System.Windows.Forms.DataGridView();
            this.Header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).BeginInit();
            this.SuspendLayout();
            // 
            // Header2
            // 
            this.Header2.BackColor = System.Drawing.Color.White;
            this.Header2.Controls.Add(this.VehicleVIN);
            this.Header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header2.Location = new System.Drawing.Point(0, 0);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(800, 26);
            this.Header2.TabIndex = 5;
            // 
            // VehicleVIN
            // 
            this.VehicleVIN.AutoSize = true;
            this.VehicleVIN.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleVIN.Location = new System.Drawing.Point(21, 3);
            this.VehicleVIN.Name = "VehicleVIN";
            this.VehicleVIN.Size = new System.Drawing.Size(75, 17);
            this.VehicleVIN.TabIndex = 0;
            this.VehicleVIN.Text = "Vehicle VIN";
            // 
            // dataGridViewVehicle
            // 
            this.dataGridViewVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVehicle.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewVehicle.Name = "dataGridViewVehicle";
            this.dataGridViewVehicle.Size = new System.Drawing.Size(800, 424);
            this.dataGridViewVehicle.TabIndex = 6;
            // 
            // VehicleInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewVehicle);
            this.Controls.Add(this.Header2);
            this.Name = "VehicleInfo";
            this.Text = "VehicleInfo";
            this.Load += new System.EventHandler(this.VehicleInfo_Load);
            this.Header2.ResumeLayout(false);
            this.Header2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVehicle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header2;
        private System.Windows.Forms.Label VehicleVIN;
        private System.Windows.Forms.DataGridView dataGridViewVehicle;
    }
}