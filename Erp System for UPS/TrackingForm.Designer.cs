using System.Windows.Forms;

namespace Erp_System_for_UPS
{
    partial class TrackingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxPackageID = new System.Windows.Forms.TextBox();
            this.labelPackageID = new System.Windows.Forms.Label();
            this.btnTrack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(212, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Package Tracking System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Erp_System_for_UPS.Properties.Resources.pictureBox1_Image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxPackageID
            // 
            this.textBoxPackageID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPackageID.Location = new System.Drawing.Point(147, 130);
            this.textBoxPackageID.Name = "textBoxPackageID";
            this.textBoxPackageID.Size = new System.Drawing.Size(280, 24);
            this.textBoxPackageID.TabIndex = 1;
            this.textBoxPackageID.TextChanged += new System.EventHandler(this.textBoxPackageID_TextChanged_1);
            // 
            // labelPackageID
            // 
            this.labelPackageID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPackageID.AutoSize = true;
            this.labelPackageID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPackageID.Location = new System.Drawing.Point(144, 110);
            this.labelPackageID.Name = "labelPackageID";
            this.labelPackageID.Size = new System.Drawing.Size(78, 17);
            this.labelPackageID.TabIndex = 2;
            this.labelPackageID.Text = "Package ID:";
            this.labelPackageID.Click += new System.EventHandler(this.labelPackageID_Click);
            // 
            // btnTrack
            // 
            this.btnTrack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTrack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTrack.BackColor = System.Drawing.Color.Goldenrod;
            this.btnTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrack.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnTrack.Location = new System.Drawing.Point(147, 188);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(280, 33);
            this.btnTrack.TabIndex = 3;
            this.btnTrack.Text = "Track";
            this.btnTrack.UseVisualStyleBackColor = false;
            this.btnTrack.Click += new System.EventHandler(this.btnTrack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(46, 268);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20);
            this.label2.Size = new System.Drawing.Size(487, 197);
            this.label2.TabIndex = 4;
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(593, 504);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.labelPackageID);
            this.Controls.Add(this.textBoxPackageID);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TrackingForm";
            this.Text = "Package Tracking";
            this.Load += new System.EventHandler(this.TrackingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxPackageID;
        private System.Windows.Forms.Label labelPackageID;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label label2;
    }
}
