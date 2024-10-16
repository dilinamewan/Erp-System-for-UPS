namespace Erp_System_for_UPS
{
    partial class DashbordElements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashbordElements));
            this.Header2 = new System.Windows.Forms.Panel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.h2 = new System.Windows.Forms.Label();
            this.AlertBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaintenanceAvailableVehiclesCount = new System.Windows.Forms.Label();
            this.UnassignedVehiclesCount = new System.Windows.Forms.Label();
            this.AssignedVehiclesCount = new System.Windows.Forms.Label();
            this.IncidentVehicleCount = new System.Windows.Forms.Label();
            this.TotalVehicleCount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.DailyIncidentCount = new System.Windows.Forms.Label();
            this.YearlyIncidentCount = new System.Windows.Forms.Label();
            this.MonthlyIncidentCount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AssignedDriverCount = new System.Windows.Forms.Label();
            this.ActiveDriverCount = new System.Windows.Forms.Label();
            this.InactiveDriverCount = new System.Windows.Forms.Label();
            this.TotalDriverCount = new System.Windows.Forms.Label();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Header2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header2
            // 
            this.Header2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(42)))));
            this.Header2.Controls.Add(this.metroDateTime1);
            this.Header2.Controls.Add(this.h2);
            this.Header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header2.Location = new System.Drawing.Point(0, 0);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(926, 26);
            this.Header2.TabIndex = 5;
            this.Header2.Paint += new System.Windows.Forms.PaintEventHandler(this.Header2_Paint);
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroDateTime1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroDateTime1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(42)))));
            this.metroDateTime1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(42)))));
            this.metroDateTime1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(42)))));
            this.metroDateTime1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(48)))), ((int)(((byte)(42)))));
            this.metroDateTime1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroDateTime1.Location = new System.Drawing.Point(726, 0);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 1;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // h2
            // 
            this.h2.AutoSize = true;
            this.h2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2.ForeColor = System.Drawing.Color.White;
            this.h2.Location = new System.Drawing.Point(21, 3);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(74, 17);
            this.h2.TabIndex = 0;
            this.h2.Text = "Dashboard";
            this.h2.Click += new System.EventHandler(this.h2_Click);
            // 
            // AlertBtn
            // 
            this.AlertBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AlertBtn.AutoSize = true;
            this.AlertBtn.BackColor = System.Drawing.Color.White;
            this.AlertBtn.FlatAppearance.BorderSize = 0;
            this.AlertBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertBtn.ForeColor = System.Drawing.Color.Red;
            this.AlertBtn.Image = ((System.Drawing.Image)(resources.GetObject("AlertBtn.Image")));
            this.AlertBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AlertBtn.Location = new System.Drawing.Point(24, 17);
            this.AlertBtn.Name = "AlertBtn";
            this.AlertBtn.Size = new System.Drawing.Size(367, 108);
            this.AlertBtn.TabIndex = 2;
            this.AlertBtn.Text = "Maintenance Alerts";
            this.AlertBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AlertBtn.UseVisualStyleBackColor = false;
            this.AlertBtn.Click += new System.EventHandler(this.AlertBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.MaintenanceAvailableVehiclesCount);
            this.panel1.Controls.Add(this.UnassignedVehiclesCount);
            this.panel1.Controls.Add(this.AssignedVehiclesCount);
            this.panel1.Controls.Add(this.IncidentVehicleCount);
            this.panel1.Controls.Add(this.TotalVehicleCount);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(491, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 108);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // MaintenanceAvailableVehiclesCount
            // 
            this.MaintenanceAvailableVehiclesCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MaintenanceAvailableVehiclesCount.AutoSize = true;
            this.MaintenanceAvailableVehiclesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaintenanceAvailableVehiclesCount.ForeColor = System.Drawing.Color.White;
            this.MaintenanceAvailableVehiclesCount.Location = new System.Drawing.Point(157, 76);
            this.MaintenanceAvailableVehiclesCount.Name = "MaintenanceAvailableVehiclesCount";
            this.MaintenanceAvailableVehiclesCount.Size = new System.Drawing.Size(69, 17);
            this.MaintenanceAvailableVehiclesCount.TabIndex = 5;
            this.MaintenanceAvailableVehiclesCount.Text = "Total - 100";
            this.MaintenanceAvailableVehiclesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MaintenanceAvailableVehiclesCount.Click += new System.EventHandler(this.MaintenanceAvailableVehiclesCount_Click);
            // 
            // UnassignedVehiclesCount
            // 
            this.UnassignedVehiclesCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnassignedVehiclesCount.AutoSize = true;
            this.UnassignedVehiclesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnassignedVehiclesCount.ForeColor = System.Drawing.Color.White;
            this.UnassignedVehiclesCount.Location = new System.Drawing.Point(157, 59);
            this.UnassignedVehiclesCount.Name = "UnassignedVehiclesCount";
            this.UnassignedVehiclesCount.Size = new System.Drawing.Size(69, 17);
            this.UnassignedVehiclesCount.TabIndex = 4;
            this.UnassignedVehiclesCount.Text = "Total - 100";
            this.UnassignedVehiclesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UnassignedVehiclesCount.Click += new System.EventHandler(this.UnassignedVehiclesCount_Click);
            // 
            // AssignedVehiclesCount
            // 
            this.AssignedVehiclesCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssignedVehiclesCount.AutoSize = true;
            this.AssignedVehiclesCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedVehiclesCount.ForeColor = System.Drawing.Color.White;
            this.AssignedVehiclesCount.Location = new System.Drawing.Point(157, 42);
            this.AssignedVehiclesCount.Name = "AssignedVehiclesCount";
            this.AssignedVehiclesCount.Size = new System.Drawing.Size(69, 17);
            this.AssignedVehiclesCount.TabIndex = 3;
            this.AssignedVehiclesCount.Text = "Total - 100";
            this.AssignedVehiclesCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AssignedVehiclesCount.Click += new System.EventHandler(this.AssignedVehiclesCount_Click);
            // 
            // IncidentVehicleCount
            // 
            this.IncidentVehicleCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncidentVehicleCount.AutoSize = true;
            this.IncidentVehicleCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncidentVehicleCount.ForeColor = System.Drawing.Color.White;
            this.IncidentVehicleCount.Location = new System.Drawing.Point(157, 27);
            this.IncidentVehicleCount.Name = "IncidentVehicleCount";
            this.IncidentVehicleCount.Size = new System.Drawing.Size(69, 17);
            this.IncidentVehicleCount.TabIndex = 2;
            this.IncidentVehicleCount.Text = "Total - 100";
            this.IncidentVehicleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IncidentVehicleCount.Click += new System.EventHandler(this.IncidentVehicleCount_Click);
            // 
            // TotalVehicleCount
            // 
            this.TotalVehicleCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalVehicleCount.AutoSize = true;
            this.TotalVehicleCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalVehicleCount.ForeColor = System.Drawing.Color.White;
            this.TotalVehicleCount.Location = new System.Drawing.Point(157, 10);
            this.TotalVehicleCount.Name = "TotalVehicleCount";
            this.TotalVehicleCount.Size = new System.Drawing.Size(69, 17);
            this.TotalVehicleCount.TabIndex = 1;
            this.TotalVehicleCount.Text = "Total - 100";
            this.TotalVehicleCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalVehicleCount.Click += new System.EventHandler(this.TotalVehicleCount_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.DailyIncidentCount);
            this.panel2.Controls.Add(this.YearlyIncidentCount);
            this.panel2.Controls.Add(this.MonthlyIncidentCount);
            this.panel2.Location = new System.Drawing.Point(491, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(405, 108);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // DailyIncidentCount
            // 
            this.DailyIncidentCount.AutoSize = true;
            this.DailyIncidentCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DailyIncidentCount.ForeColor = System.Drawing.Color.White;
            this.DailyIncidentCount.Location = new System.Drawing.Point(157, 61);
            this.DailyIncidentCount.Name = "DailyIncidentCount";
            this.DailyIncidentCount.Size = new System.Drawing.Size(69, 17);
            this.DailyIncidentCount.TabIndex = 8;
            this.DailyIncidentCount.Text = "Total - 100";
            this.DailyIncidentCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DailyIncidentCount.Click += new System.EventHandler(this.label8_Click);
            // 
            // YearlyIncidentCount
            // 
            this.YearlyIncidentCount.AutoSize = true;
            this.YearlyIncidentCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearlyIncidentCount.ForeColor = System.Drawing.Color.White;
            this.YearlyIncidentCount.Location = new System.Drawing.Point(157, 29);
            this.YearlyIncidentCount.Name = "YearlyIncidentCount";
            this.YearlyIncidentCount.Size = new System.Drawing.Size(69, 17);
            this.YearlyIncidentCount.TabIndex = 6;
            this.YearlyIncidentCount.Text = "Total - 100";
            this.YearlyIncidentCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.YearlyIncidentCount.Click += new System.EventHandler(this.YearlyIncidentCount_Click);
            // 
            // MonthlyIncidentCount
            // 
            this.MonthlyIncidentCount.AutoSize = true;
            this.MonthlyIncidentCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyIncidentCount.ForeColor = System.Drawing.Color.White;
            this.MonthlyIncidentCount.Location = new System.Drawing.Point(157, 46);
            this.MonthlyIncidentCount.Name = "MonthlyIncidentCount";
            this.MonthlyIncidentCount.Size = new System.Drawing.Size(69, 17);
            this.MonthlyIncidentCount.TabIndex = 7;
            this.MonthlyIncidentCount.Text = "Total - 100";
            this.MonthlyIncidentCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MonthlyIncidentCount.Click += new System.EventHandler(this.MonthlyIncidentCount_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.AssignedDriverCount);
            this.panel3.Controls.Add(this.ActiveDriverCount);
            this.panel3.Controls.Add(this.InactiveDriverCount);
            this.panel3.Controls.Add(this.TotalDriverCount);
            this.panel3.Location = new System.Drawing.Point(24, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 108);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(91, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AssignedDriverCount
            // 
            this.AssignedDriverCount.AutoSize = true;
            this.AssignedDriverCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedDriverCount.ForeColor = System.Drawing.Color.White;
            this.AssignedDriverCount.Location = new System.Drawing.Point(153, 74);
            this.AssignedDriverCount.Name = "AssignedDriverCount";
            this.AssignedDriverCount.Size = new System.Drawing.Size(69, 17);
            this.AssignedDriverCount.TabIndex = 14;
            this.AssignedDriverCount.Text = "Total - 100";
            this.AssignedDriverCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AssignedDriverCount.Click += new System.EventHandler(this.AssignedDriverCount_Click);
            // 
            // ActiveDriverCount
            // 
            this.ActiveDriverCount.AutoSize = true;
            this.ActiveDriverCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveDriverCount.ForeColor = System.Drawing.Color.White;
            this.ActiveDriverCount.Location = new System.Drawing.Point(153, 42);
            this.ActiveDriverCount.Name = "ActiveDriverCount";
            this.ActiveDriverCount.Size = new System.Drawing.Size(69, 17);
            this.ActiveDriverCount.TabIndex = 12;
            this.ActiveDriverCount.Text = "Total - 100";
            this.ActiveDriverCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ActiveDriverCount.Click += new System.EventHandler(this.ActiveDriverCount_Click);
            // 
            // InactiveDriverCount
            // 
            this.InactiveDriverCount.AutoSize = true;
            this.InactiveDriverCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InactiveDriverCount.ForeColor = System.Drawing.Color.White;
            this.InactiveDriverCount.Location = new System.Drawing.Point(153, 57);
            this.InactiveDriverCount.Name = "InactiveDriverCount";
            this.InactiveDriverCount.Size = new System.Drawing.Size(69, 17);
            this.InactiveDriverCount.TabIndex = 13;
            this.InactiveDriverCount.Text = "Total - 100";
            this.InactiveDriverCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.InactiveDriverCount.Click += new System.EventHandler(this.InactiveDriverCount_Click);
            // 
            // TotalDriverCount
            // 
            this.TotalDriverCount.AutoSize = true;
            this.TotalDriverCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDriverCount.ForeColor = System.Drawing.Color.White;
            this.TotalDriverCount.Location = new System.Drawing.Point(153, 25);
            this.TotalDriverCount.Name = "TotalDriverCount";
            this.TotalDriverCount.Size = new System.Drawing.Size(69, 17);
            this.TotalDriverCount.TabIndex = 11;
            this.TotalDriverCount.Text = "Total - 100";
            this.TotalDriverCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TotalDriverCount.Click += new System.EventHandler(this.TotalDriverCount_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.panel3);
            this.metroPanel1.Controls.Add(this.panel2);
            this.metroPanel1.Controls.Add(this.panel1);
            this.metroPanel1.Controls.Add(this.AlertBtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 26);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(926, 303);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 329);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(926, 227);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // DashbordElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 556);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Header2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashbordElements";
            this.Text = "DashbordElements";
            this.Load += new System.EventHandler(this.DashbordElements_Load);
            this.Header2.ResumeLayout(false);
            this.Header2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header2;
        private System.Windows.Forms.Label h2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private System.Windows.Forms.Button AlertBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MaintenanceAvailableVehiclesCount;
        private System.Windows.Forms.Label UnassignedVehiclesCount;
        private System.Windows.Forms.Label AssignedVehiclesCount;
        private System.Windows.Forms.Label IncidentVehicleCount;
        private System.Windows.Forms.Label TotalVehicleCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label DailyIncidentCount;
        private System.Windows.Forms.Label YearlyIncidentCount;
        private System.Windows.Forms.Label MonthlyIncidentCount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label AssignedDriverCount;
        private System.Windows.Forms.Label ActiveDriverCount;
        private System.Windows.Forms.Label InactiveDriverCount;
        private System.Windows.Forms.Label TotalDriverCount;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Panel panel4;
    }
}