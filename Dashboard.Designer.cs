using System;

namespace FP
{
    partial class Dashboard
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelindicator1 = new System.Windows.Forms.Label();
            this.labelindicator2 = new System.Windows.Forms.Label();
            this.labelindicator3 = new System.Windows.Forms.Label();
            this.Addpr = new System.Windows.Forms.Button();
            this.AddDI = new System.Windows.Forms.Button();
            this.btnpf = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelind = new System.Windows.Forms.Label();
            this.btndocinfo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelind5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONTROLLERS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hospital Managment System";
            // 
            // labelindicator1
            // 
            this.labelindicator1.AutoSize = true;
            this.labelindicator1.BackColor = System.Drawing.Color.White;
            this.labelindicator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator1.Location = new System.Drawing.Point(1, 44);
            this.labelindicator1.Name = "labelindicator1";
            this.labelindicator1.Size = new System.Drawing.Size(36, 25);
            this.labelindicator1.TabIndex = 4;
            this.labelindicator1.Text = "=>";
            // 
            // labelindicator2
            // 
            this.labelindicator2.AutoSize = true;
            this.labelindicator2.BackColor = System.Drawing.Color.White;
            this.labelindicator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator2.Location = new System.Drawing.Point(1, 91);
            this.labelindicator2.Name = "labelindicator2";
            this.labelindicator2.Size = new System.Drawing.Size(36, 25);
            this.labelindicator2.TabIndex = 6;
            this.labelindicator2.Text = "=>";
            // 
            // labelindicator3
            // 
            this.labelindicator3.AutoSize = true;
            this.labelindicator3.BackColor = System.Drawing.Color.White;
            this.labelindicator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelindicator3.Location = new System.Drawing.Point(1, 137);
            this.labelindicator3.Name = "labelindicator3";
            this.labelindicator3.Size = new System.Drawing.Size(36, 25);
            this.labelindicator3.TabIndex = 8;
            this.labelindicator3.Text = "=>";
            this.labelindicator3.Click += new System.EventHandler(this.label5_Click);
            // 
            // Addpr
            // 
            this.Addpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Addpr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addpr.Location = new System.Drawing.Point(54, 44);
            this.Addpr.Name = "Addpr";
            this.Addpr.Size = new System.Drawing.Size(217, 33);
            this.Addpr.TabIndex = 11;
            this.Addpr.Text = "Add Patient Record";
            this.Addpr.UseVisualStyleBackColor = false;
            this.Addpr.Click += new System.EventHandler(this.Addpr_Click);
            // 
            // AddDI
            // 
            this.AddDI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddDI.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDI.Location = new System.Drawing.Point(54, 83);
            this.AddDI.Name = "AddDI";
            this.AddDI.Size = new System.Drawing.Size(217, 33);
            this.AddDI.TabIndex = 13;
            this.AddDI.Text = "Add Diagnosis Information";
            this.AddDI.UseVisualStyleBackColor = false;
            this.AddDI.Click += new System.EventHandler(this.AddDI_Click);
            // 
            // btnpf
            // 
            this.btnpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnpf.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpf.Location = new System.Drawing.Point(54, 129);
            this.btnpf.Name = "btnpf";
            this.btnpf.Size = new System.Drawing.Size(217, 33);
            this.btnpf.TabIndex = 15;
            this.btnpf.Text = "Patient Full History";
            this.btnpf.UseVisualStyleBackColor = false;
            this.btnpf.Click += new System.EventHandler(this.btnpf_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnexit.Location = new System.Drawing.Point(110, 257);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "Logout";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Fuchsia;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 361);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(240, 105);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // labelind
            // 
            this.labelind.AutoSize = true;
            this.labelind.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelind.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind.Location = new System.Drawing.Point(1, 175);
            this.labelind.Name = "labelind";
            this.labelind.Size = new System.Drawing.Size(32, 26);
            this.labelind.TabIndex = 23;
            this.labelind.Text = "=>";
            // 
            // btndocinfo
            // 
            this.btndocinfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btndocinfo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndocinfo.Location = new System.Drawing.Point(54, 168);
            this.btndocinfo.Name = "btndocinfo";
            this.btndocinfo.Size = new System.Drawing.Size(217, 33);
            this.btndocinfo.TabIndex = 24;
            this.btndocinfo.Text = "Add Doctor Info";
            this.btndocinfo.UseVisualStyleBackColor = false;
            this.btndocinfo.Click += new System.EventHandler(this.btndocinfo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(54, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 33);
            this.button1.TabIndex = 25;
            this.button1.Text = "Full Doctor Info";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelind5
            // 
            this.labelind5.AutoSize = true;
            this.labelind5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelind5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelind5.Location = new System.Drawing.Point(5, 225);
            this.labelind5.Name = "labelind5";
            this.labelind5.Size = new System.Drawing.Size(32, 26);
            this.labelind5.TabIndex = 26;
            this.labelind5.Text = "=>";
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelind5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndocinfo);
            this.Controls.Add(this.labelind);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnpf);
            this.Controls.Add(this.AddDI);
            this.Controls.Add(this.Addpr);
            this.Controls.Add(this.labelindicator3);
            this.Controls.Add(this.labelindicator2);
            this.Controls.Add(this.labelindicator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelindicator1;
        private System.Windows.Forms.Label labelindicator2;
        private System.Windows.Forms.Label labelindicator3;
        private System.Windows.Forms.Button Addpr;
        private System.Windows.Forms.Button AddDI;
        private System.Windows.Forms.Button btnpf;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource hospitalDataSetBindingSource;
        private System.Windows.Forms.Label labelind;
        private System.Windows.Forms.Button btndocinfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelind5;
    }
}
    
      