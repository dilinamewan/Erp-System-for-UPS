namespace Erp_System_for_UPS
{
    partial class ManageUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDrivers = new System.Windows.Forms.DataGridView();
            this.Header2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // Header2
            // 
            this.Header2.BackColor = System.Drawing.Color.White;
            this.Header2.Controls.Add(this.label1);
            this.Header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header2.Location = new System.Drawing.Point(0, 0);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(942, 26);
            this.Header2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // dataGridViewDrivers
            // 
            this.dataGridViewDrivers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrivers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDrivers.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewDrivers.Name = "dataGridViewDrivers";
            this.dataGridViewDrivers.Size = new System.Drawing.Size(942, 569);
            this.dataGridViewDrivers.TabIndex = 4;
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(942, 595);
            this.Controls.Add(this.dataGridViewDrivers);
            this.Controls.Add(this.Header2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUserForm";
            this.Text = "ManageUserForm";
            this.Load += new System.EventHandler(this.ManageUserForm_Load);
            this.Header2.ResumeLayout(false);
            this.Header2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrivers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDrivers;
    }
}