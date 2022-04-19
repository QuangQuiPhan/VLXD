
namespace GUI
{
    partial class Home
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnAccountManagement = new FontAwesome.Sharp.IconButton();
            this.btnBillManagement = new FontAwesome.Sharp.IconButton();
            this.btnProductManagement = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnReport);
            this.panelMenu.Controls.Add(this.btnAccountManagement);
            this.panelMenu.Controls.Add(this.btnBillManagement);
            this.panelMenu.Controls.Add(this.btnProductManagement);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(328, 453);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(328, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Thoát";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.btnLogout.IconColor = System.Drawing.Color.Aqua;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 330);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(328, 60);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.btnReport.IconColor = System.Drawing.Color.Aqua;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 270);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(328, 60);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAccountManagement
            // 
            this.btnAccountManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccountManagement.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountManagement.ForeColor = System.Drawing.Color.White;
            this.btnAccountManagement.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.btnAccountManagement.IconColor = System.Drawing.Color.Aqua;
            this.btnAccountManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountManagement.Location = new System.Drawing.Point(0, 210);
            this.btnAccountManagement.Name = "btnAccountManagement";
            this.btnAccountManagement.Size = new System.Drawing.Size(328, 60);
            this.btnAccountManagement.TabIndex = 4;
            this.btnAccountManagement.Text = "Quản lý tài khoản";
            this.btnAccountManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccountManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccountManagement.UseVisualStyleBackColor = true;
            this.btnAccountManagement.Click += new System.EventHandler(this.btnAccountManagement_Click_1);
            // 
            // btnBillManagement
            // 
            this.btnBillManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBillManagement.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBillManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillManagement.ForeColor = System.Drawing.Color.White;
            this.btnBillManagement.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.btnBillManagement.IconColor = System.Drawing.Color.Aqua;
            this.btnBillManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBillManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillManagement.Location = new System.Drawing.Point(0, 150);
            this.btnBillManagement.Name = "btnBillManagement";
            this.btnBillManagement.Size = new System.Drawing.Size(328, 60);
            this.btnBillManagement.TabIndex = 3;
            this.btnBillManagement.Text = "Quản lý đơn hàng";
            this.btnBillManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBillManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBillManagement.UseVisualStyleBackColor = true;
            this.btnBillManagement.Click += new System.EventHandler(this.btnBillManagement_Click_1);
            // 
            // btnProductManagement
            // 
            this.btnProductManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductManagement.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductManagement.ForeColor = System.Drawing.Color.White;
            this.btnProductManagement.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.btnProductManagement.IconColor = System.Drawing.Color.Aqua;
            this.btnProductManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductManagement.Location = new System.Drawing.Point(0, 90);
            this.btnProductManagement.Name = "btnProductManagement";
            this.btnProductManagement.Size = new System.Drawing.Size(328, 60);
            this.btnProductManagement.TabIndex = 1;
            this.btnProductManagement.Text = "Quản lý sản phẩm";
            this.btnProductManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductManagement.UseVisualStyleBackColor = true;
            this.btnProductManagement.Click += new System.EventHandler(this.btnProductManagement_Click_1);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnReset);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(328, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.btnReset.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 90;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.Location = new System.Drawing.Point(70, 0);
            this.btnReset.Margin = new System.Windows.Forms.Padding(70, 0, 0, 0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 90);
            this.btnReset.TabIndex = 0;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(328, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(656, 55);
            this.panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(245, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Trang chủ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(328, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 8);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(328, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(656, 390);
            this.panel2.TabIndex = 3;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.Azure;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.OldRepublic;
            this.iconPictureBox1.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 273;
            this.iconPictureBox1.Location = new System.Drawing.Point(176, 63);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(446, 273);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 453);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Home";
            this.Text = "Trang chủ";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAccountManagement;
        private FontAwesome.Sharp.IconButton btnBillManagement;
        private FontAwesome.Sharp.IconButton btnProductManagement;
        private System.Windows.Forms.FlowLayoutPanel panelLogo;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnLogout;
    }
}

