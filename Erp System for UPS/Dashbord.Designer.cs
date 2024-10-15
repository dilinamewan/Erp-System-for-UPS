namespace Erp_System_for_UPS
{
    partial class Dashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashbord));
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.H1 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.PackageTracking = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.VehicleMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.ManageVehicles = new System.Windows.Forms.Button();
            this.AllVehicles = new System.Windows.Forms.Button();
            this.AvailbleVehicles = new System.Windows.Forms.Button();
            this.Alert = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.ManageDrivers = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MenuTransision = new System.Windows.Forms.Timer(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SideBar.SuspendLayout();
            this.VehicleMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Goldenrod;
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.H1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1251, 54);
            this.Header.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(267, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.ForeColor = System.Drawing.Color.White;
            this.H1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.H1.Location = new System.Drawing.Point(469, 11);
            this.H1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(387, 32);
            this.H1.TabIndex = 0;
            this.H1.Text = "Universal Parcel Tracking System";
            this.H1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.H1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.SideBar.Controls.Add(this.PackageTracking);
            this.SideBar.Controls.Add(this.LogOutButton);
            this.SideBar.Controls.Add(this.VehicleMenu);
            this.SideBar.Controls.Add(this.Dashboard);
            this.SideBar.Controls.Add(this.ManageDrivers);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 54);
            this.SideBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(267, 623);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // PackageTracking
            // 
            this.PackageTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.PackageTracking.FlatAppearance.BorderSize = 0;
            this.PackageTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PackageTracking.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageTracking.ForeColor = System.Drawing.SystemColors.Control;
            this.PackageTracking.Location = new System.Drawing.Point(0, 236);
            this.PackageTracking.Margin = new System.Windows.Forms.Padding(0);
            this.PackageTracking.Name = "PackageTracking";
            this.PackageTracking.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.PackageTracking.Size = new System.Drawing.Size(267, 74);
            this.PackageTracking.TabIndex = 9;
            this.PackageTracking.Text = "Package Tracking";
            this.PackageTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PackageTracking.UseVisualStyleBackColor = false;
            this.PackageTracking.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOutButton.Location = new System.Drawing.Point(0, 549);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.LogOutButton.Size = new System.Drawing.Size(267, 74);
            this.LogOutButton.TabIndex = 8;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // VehicleMenu
            // 
            this.VehicleMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(64)))));
            this.VehicleMenu.Controls.Add(this.ManageVehicles);
            this.VehicleMenu.Controls.Add(this.AllVehicles);
            this.VehicleMenu.Controls.Add(this.AvailbleVehicles);
            this.VehicleMenu.Controls.Add(this.Alert);
            this.VehicleMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.VehicleMenu.Location = new System.Drawing.Point(0, 162);
            this.VehicleMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VehicleMenu.Name = "VehicleMenu";
            this.VehicleMenu.Size = new System.Drawing.Size(267, 74);
            this.VehicleMenu.TabIndex = 7;
            this.VehicleMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.VehicleMenu_Paint);
            // 
            // ManageVehicles
            // 
            this.ManageVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.ManageVehicles.FlatAppearance.BorderSize = 0;
            this.ManageVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageVehicles.Location = new System.Drawing.Point(0, 0);
            this.ManageVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.ManageVehicles.Name = "ManageVehicles";
            this.ManageVehicles.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.ManageVehicles.Size = new System.Drawing.Size(267, 74);
            this.ManageVehicles.TabIndex = 6;
            this.ManageVehicles.Text = "Manage Vehicles";
            this.ManageVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageVehicles.UseVisualStyleBackColor = false;
            this.ManageVehicles.Click += new System.EventHandler(this.ManageVehicles_Click);
            // 
            // AllVehicles
            // 
            this.AllVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(64)))));
            this.AllVehicles.FlatAppearance.BorderSize = 0;
            this.AllVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.AllVehicles.Location = new System.Drawing.Point(267, 0);
            this.AllVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.AllVehicles.Name = "AllVehicles";
            this.AllVehicles.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.AllVehicles.Size = new System.Drawing.Size(267, 53);
            this.AllVehicles.TabIndex = 7;
            this.AllVehicles.Text = "All Vehicles";
            this.AllVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllVehicles.UseVisualStyleBackColor = false;
            this.AllVehicles.Click += new System.EventHandler(this.AllVehicles_Click);
            // 
            // AvailbleVehicles
            // 
            this.AvailbleVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(64)))));
            this.AvailbleVehicles.FlatAppearance.BorderSize = 0;
            this.AvailbleVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailbleVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailbleVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.AvailbleVehicles.Location = new System.Drawing.Point(534, 0);
            this.AvailbleVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.AvailbleVehicles.Name = "AvailbleVehicles";
            this.AvailbleVehicles.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.AvailbleVehicles.Size = new System.Drawing.Size(267, 53);
            this.AvailbleVehicles.TabIndex = 8;
            this.AvailbleVehicles.Text = "Availble Vehicles";
            this.AvailbleVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvailbleVehicles.UseVisualStyleBackColor = false;
            // 
            // Alert
            // 
            this.Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(112)))), ((int)(((byte)(64)))));
            this.Alert.FlatAppearance.BorderSize = 0;
            this.Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert.ForeColor = System.Drawing.SystemColors.Control;
            this.Alert.Location = new System.Drawing.Point(801, 0);
            this.Alert.Margin = new System.Windows.Forms.Padding(0);
            this.Alert.Name = "Alert";
            this.Alert.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Alert.Size = new System.Drawing.Size(267, 53);
            this.Alert.TabIndex = 8;
            this.Alert.Text = "Maintanace Alert";
            this.Alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alert.UseVisualStyleBackColor = false;
            this.Alert.Click += new System.EventHandler(this.Alert_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(267, 74);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = false;
            // 
            // ManageDrivers
            // 
            this.ManageDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(80)))), ((int)(((byte)(58)))));
            this.ManageDrivers.FlatAppearance.BorderSize = 0;
            this.ManageDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageDrivers.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageDrivers.Location = new System.Drawing.Point(0, 81);
            this.ManageDrivers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageDrivers.Name = "ManageDrivers";
            this.ManageDrivers.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.ManageDrivers.Size = new System.Drawing.Size(267, 74);
            this.ManageDrivers.TabIndex = 5;
            this.ManageDrivers.Text = "Manage Drivers";
            this.ManageDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageDrivers.UseVisualStyleBackColor = false;
            this.ManageDrivers.Click += new System.EventHandler(this.ManageDrivers_Click);
            // 
            // MenuTransision
            // 
            this.MenuTransision.Enabled = true;
            this.MenuTransision.Interval = 1;
            this.MenuTransision.Tick += new System.EventHandler(this.MenuTransision_Tick);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(267, 54);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(984, 623);
            this.MainPanel.TabIndex = 3;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1251, 677);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Header);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.VehicleMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Label H1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button ManageDrivers;
        private System.Windows.Forms.Button ManageVehicles;
        private System.Windows.Forms.FlowLayoutPanel VehicleMenu;
        private System.Windows.Forms.Button AllVehicles;
        private System.Windows.Forms.Button AvailbleVehicles;
        private System.Windows.Forms.Button Alert;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Timer MenuTransision;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button PackageTracking;
    }
}