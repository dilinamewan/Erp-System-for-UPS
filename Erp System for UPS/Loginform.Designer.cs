namespace Erp_System_for_UPS
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.Label();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.lblclear = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 79);
            this.panel1.TabIndex = 0;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(13, 252);
            this.textBoxname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(280, 28);
            this.textBoxname.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Location = new System.Drawing.Point(9, 227);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(106, 21);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "User Name:";
            // 
            // txtpass
            // 
            this.txtpass.AutoSize = true;
            this.txtpass.Location = new System.Drawing.Point(9, 297);
            this.txtpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(93, 21);
            this.txtpass.TabIndex = 4;
            this.txtpass.Text = "Password:";
            this.txtpass.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(9, 322);
            this.textBoxpass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(280, 28);
            this.textBoxpass.TabIndex = 3;
            this.textBoxpass.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Goldenrod;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(13, 383);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(280, 33);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(61, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Operation Management System";
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxpass.Location = new System.Drawing.Point(148, 441);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(145, 24);
            this.checkBoxpass.TabIndex = 7;
            this.checkBoxpass.Text = "Show Password";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            // 
            // lblclear
            // 
            this.lblclear.AutoSize = true;
            this.lblclear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclear.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblclear.Location = new System.Drawing.Point(59, 445);
            this.lblclear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblclear.Name = "lblclear";
            this.lblclear.Size = new System.Drawing.Size(49, 18);
            this.lblclear.TabIndex = 8;
            this.lblclear.Text = "Clear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 550);
            this.Controls.Add(this.lblclear);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label txtpass;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.Label lblclear;
    }
}

