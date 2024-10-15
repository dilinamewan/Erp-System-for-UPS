using System.Drawing;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(800, 26);
            this.Header2.TabIndex = 4;
            // 
            // DriverName
            // 
            this.DriverName.AutoSize = true;
            this.DriverName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverName.Location = new System.Drawing.Point(21, 3);
            this.DriverName.Name = "DriverName";
            this.DriverName.Size = new System.Drawing.Size(84, 17);
            this.DriverName.TabIndex = 0;
            this.DriverName.Text = "Driver Name";
            this.DriverName.Click += new System.EventHandler(this.DriverName_Click);
            // 
            // dataGridViewDriver
            // 
            this.dataGridViewDriver.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDriver.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewDriver.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDriver.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDriver.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDriver.EnableHeadersVisualStyles = false;
            this.dataGridViewDriver.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewDriver.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewDriver.Name = "dataGridViewDriver";
            this.dataGridViewDriver.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dataGridViewDriver.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            this.dataGridViewDriver.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDriver.RowTemplate.Height = 40;
            this.dataGridViewDriver.Size = new System.Drawing.Size(800, 424);
            this.dataGridViewDriver.TabIndex = 5;
            this.dataGridViewDriver.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDriver_CellContentClick);
            // 
            // DriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDriver);
            this.Controls.Add(this.Header2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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