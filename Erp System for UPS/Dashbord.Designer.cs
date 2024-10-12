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
            this.Header = new System.Windows.Forms.Panel();
            this.H1 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.LogOut = new System.Windows.Forms.Button();
            this.ManageDrivers = new System.Windows.Forms.Button();
            this.VehicleMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.ManageVehicles = new System.Windows.Forms.Button();
            this.AllVehicles = new System.Windows.Forms.Button();
            this.AvailbleVehicles = new System.Windows.Forms.Button();
            this.Alert = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Header2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MenuTransision = new System.Windows.Forms.Timer(this.components);
            this.Header.SuspendLayout();
            this.SideBar.SuspendLayout();
            this.VehicleMenu.SuspendLayout();
            this.Header2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(101)))), ((int)(((byte)(199)))));
            this.Header.Controls.Add(this.H1);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(951, 44);
            this.Header.TabIndex = 0;
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H1.ForeColor = System.Drawing.Color.White;
            this.H1.Location = new System.Drawing.Point(35, 9);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(117, 25);
            this.H1.TabIndex = 0;
            this.H1.Text = "UPS System";
            this.H1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.H1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.SideBar.Controls.Add(this.LogOut);
            this.SideBar.Controls.Add(this.VehicleMenu);
            this.SideBar.Controls.Add(this.Dashboard);
            this.SideBar.Controls.Add(this.ManageDrivers);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 44);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 592);
            this.SideBar.TabIndex = 1;
            this.SideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // LogOut
            // 
            this.LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.LogOut.FlatAppearance.BorderSize = 0;
            this.LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOut.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.LogOut.Location = new System.Drawing.Point(0, 336);
            this.LogOut.Name = "LogOut";
            this.LogOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.LogOut.Size = new System.Drawing.Size(200, 60);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log Out";
            this.LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOut.UseVisualStyleBackColor = false;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // ManageDrivers
            // 
            this.ManageDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.ManageDrivers.FlatAppearance.BorderSize = 0;
            this.ManageDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageDrivers.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageDrivers.Location = new System.Drawing.Point(0, 270);
            this.ManageDrivers.Name = "ManageDrivers";
            this.ManageDrivers.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageDrivers.Size = new System.Drawing.Size(200, 60);
            this.ManageDrivers.TabIndex = 5;
            this.ManageDrivers.Text = "Manage Drivers";
            this.ManageDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageDrivers.UseVisualStyleBackColor = false;
            this.ManageDrivers.Click += new System.EventHandler(this.ManageDrivers_Click);
            // 
            // VehicleMenu
            // 
            this.VehicleMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.VehicleMenu.Controls.Add(this.ManageVehicles);
            this.VehicleMenu.Controls.Add(this.AllVehicles);
            this.VehicleMenu.Controls.Add(this.AvailbleVehicles);
            this.VehicleMenu.Controls.Add(this.Alert);
            this.VehicleMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.VehicleMenu.Location = new System.Drawing.Point(0, 61);
            this.VehicleMenu.Name = "VehicleMenu";
            this.VehicleMenu.Size = new System.Drawing.Size(200, 210);
            this.VehicleMenu.TabIndex = 7;
            this.VehicleMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.VehicleMenu_Paint);
            // 
            // ManageVehicles
            // 
            this.ManageVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.ManageVehicles.FlatAppearance.BorderSize = 0;
            this.ManageVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManageVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.ManageVehicles.Location = new System.Drawing.Point(0, 0);
            this.ManageVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.ManageVehicles.Name = "ManageVehicles";
            this.ManageVehicles.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ManageVehicles.Size = new System.Drawing.Size(200, 60);
            this.ManageVehicles.TabIndex = 6;
            this.ManageVehicles.Text = "Manage Vehicles";
            this.ManageVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ManageVehicles.UseVisualStyleBackColor = false;
            this.ManageVehicles.Click += new System.EventHandler(this.ManageVehicles_Click);
            // 
            // AllVehicles
            // 
            this.AllVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.AllVehicles.FlatAppearance.BorderSize = 0;
            this.AllVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.AllVehicles.Location = new System.Drawing.Point(0, 60);
            this.AllVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.AllVehicles.Name = "AllVehicles";
            this.AllVehicles.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AllVehicles.Size = new System.Drawing.Size(200, 43);
            this.AllVehicles.TabIndex = 7;
            this.AllVehicles.Text = "All Vehicles";
            this.AllVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AllVehicles.UseVisualStyleBackColor = false;
            // 
            // AvailbleVehicles
            // 
            this.AvailbleVehicles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.AvailbleVehicles.FlatAppearance.BorderSize = 0;
            this.AvailbleVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AvailbleVehicles.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailbleVehicles.ForeColor = System.Drawing.SystemColors.Control;
            this.AvailbleVehicles.Location = new System.Drawing.Point(0, 103);
            this.AvailbleVehicles.Margin = new System.Windows.Forms.Padding(0);
            this.AvailbleVehicles.Name = "AvailbleVehicles";
            this.AvailbleVehicles.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AvailbleVehicles.Size = new System.Drawing.Size(200, 43);
            this.AvailbleVehicles.TabIndex = 8;
            this.AvailbleVehicles.Text = "Availble Vehicles";
            this.AvailbleVehicles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AvailbleVehicles.UseVisualStyleBackColor = false;
            // 
            // Alert
            // 
            this.Alert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(93)))), ((int)(((byte)(148)))));
            this.Alert.FlatAppearance.BorderSize = 0;
            this.Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alert.ForeColor = System.Drawing.SystemColors.Control;
            this.Alert.Location = new System.Drawing.Point(0, 146);
            this.Alert.Margin = new System.Windows.Forms.Padding(0);
            this.Alert.Name = "Alert";
            this.Alert.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Alert.Size = new System.Drawing.Size(200, 43);
            this.Alert.TabIndex = 8;
            this.Alert.Text = "Maintanace Alert";
            this.Alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Alert.UseVisualStyleBackColor = false;
            this.Alert.Click += new System.EventHandler(this.Alert_Click);
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(73)))), ((int)(((byte)(97)))));
            this.Dashboard.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Location = new System.Drawing.Point(0, 0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Dashboard.Size = new System.Drawing.Size(200, 60);
            this.Dashboard.TabIndex = 3;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.UseVisualStyleBackColor = false;
            // 
            // Header2
            // 
            this.Header2.BackColor = System.Drawing.SystemColors.Control;
            this.Header2.Controls.Add(this.label1);
            this.Header2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header2.Location = new System.Drawing.Point(200, 44);
            this.Header2.Name = "Header2";
            this.Header2.Size = new System.Drawing.Size(751, 26);
            this.Header2.TabIndex = 2;
            this.Header2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // MenuTransision
            // 
            this.MenuTransision.Enabled = true;
            this.MenuTransision.Interval = 1;
            this.MenuTransision.Tick += new System.EventHandler(this.MenuTransision_Tick);
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(951, 636);
            this.Controls.Add(this.Header2);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.Header);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.SideBar.ResumeLayout(false);
            this.VehicleMenu.ResumeLayout(false);
            this.Header2.ResumeLayout(false);
            this.Header2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header2;
        private System.Windows.Forms.Label H1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.Button ManageDrivers;
        private System.Windows.Forms.Button ManageVehicles;
        private System.Windows.Forms.FlowLayoutPanel VehicleMenu;
        private System.Windows.Forms.Button AllVehicles;
        private System.Windows.Forms.Button AvailbleVehicles;
        private System.Windows.Forms.Button Alert;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Timer MenuTransision;
    }
}