namespace WindowsFormsApp3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddroom = new System.Windows.Forms.Button();
            this.btncusomterregester = new System.Windows.Forms.Button();
            this.btncheckout = new System.Windows.Forms.Button();
            this.btncutomerdetails = new System.Windows.Forms.Button();
            this.btnemployee = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnminimize = new System.Windows.Forms.Button();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnemployee);
            this.panel1.Controls.Add(this.btncutomerdetails);
            this.panel1.Controls.Add(this.btncheckout);
            this.panel1.Controls.Add(this.btncusomterregester);
            this.panel1.Controls.Add(this.btnaddroom);
            this.panel1.Location = new System.Drawing.Point(41, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1249, 130);
            this.panel1.TabIndex = 0;
            // 
            // btnaddroom
            // 
            this.btnaddroom.BackColor = System.Drawing.Color.DarkGray;
            this.btnaddroom.Image = ((System.Drawing.Image)(resources.GetObject("btnaddroom.Image")));
            this.btnaddroom.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaddroom.Location = new System.Drawing.Point(56, 21);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.Size = new System.Drawing.Size(184, 86);
            this.btnaddroom.TabIndex = 0;
            this.btnaddroom.Text = "add room";
            this.btnaddroom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnaddroom.UseVisualStyleBackColor = false;
            this.btnaddroom.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // btncusomterregester
            // 
            this.btncusomterregester.BackColor = System.Drawing.Color.DarkGray;
            this.btncusomterregester.Image = ((System.Drawing.Image)(resources.GetObject("btncusomterregester.Image")));
            this.btncusomterregester.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncusomterregester.Location = new System.Drawing.Point(283, 20);
            this.btncusomterregester.Name = "btncusomterregester";
            this.btncusomterregester.Size = new System.Drawing.Size(189, 86);
            this.btncusomterregester.TabIndex = 1;
            this.btncusomterregester.Text = "Customer Registeration";
            this.btncusomterregester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncusomterregester.UseVisualStyleBackColor = false;
            this.btncusomterregester.Click += new System.EventHandler(this.button2_Click);
            // 
            // btncheckout
            // 
            this.btncheckout.BackColor = System.Drawing.Color.DarkGray;
            this.btncheckout.Image = ((System.Drawing.Image)(resources.GetObject("btncheckout.Image")));
            this.btncheckout.Location = new System.Drawing.Point(562, 20);
            this.btncheckout.Name = "btncheckout";
            this.btncheckout.Size = new System.Drawing.Size(186, 86);
            this.btncheckout.TabIndex = 2;
            this.btncheckout.Text = "check out ";
            this.btncheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncheckout.UseVisualStyleBackColor = false;
            this.btncheckout.Click += new System.EventHandler(this.btncheckout_Click);
            // 
            // btncutomerdetails
            // 
            this.btncutomerdetails.BackColor = System.Drawing.Color.DarkGray;
            this.btncutomerdetails.Image = ((System.Drawing.Image)(resources.GetObject("btncutomerdetails.Image")));
            this.btncutomerdetails.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncutomerdetails.Location = new System.Drawing.Point(798, 20);
            this.btncutomerdetails.Name = "btncutomerdetails";
            this.btncutomerdetails.Size = new System.Drawing.Size(186, 86);
            this.btncutomerdetails.TabIndex = 3;
            this.btncutomerdetails.Text = "customer details";
            this.btncutomerdetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btncutomerdetails.UseVisualStyleBackColor = false;
            this.btncutomerdetails.Click += new System.EventHandler(this.btncutomerdetails_Click);
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.DarkGray;
            this.btnemployee.Image = ((System.Drawing.Image)(resources.GetObject("btnemployee.Image")));
            this.btnemployee.Location = new System.Drawing.Point(1039, 20);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(186, 81);
            this.btnemployee.TabIndex = 4;
            this.btnemployee.Text = "Employee";
            this.btnemployee.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnemployee.UseVisualStyleBackColor = false;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Location = new System.Drawing.Point(2, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(33, 28);
            this.btnexit.TabIndex = 0;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnminimize
            // 
            this.btnminimize.BackColor = System.Drawing.Color.Black;
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnminimize.Image = ((System.Drawing.Image)(resources.GetObject("btnminimize.Image")));
            this.btnminimize.Location = new System.Drawing.Point(2, 61);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(33, 30);
            this.btnminimize.TabIndex = 0;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.MovingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MovingPanel.Location = new System.Drawing.Point(56, 111);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(183, 10);
            this.MovingPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1294, 451);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1329, 676);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnminimize);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btncutomerdetails;
        private System.Windows.Forms.Button btncheckout;
        private System.Windows.Forms.Button btncusomterregester;
        private System.Windows.Forms.Button btnaddroom;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Panel MovingPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}