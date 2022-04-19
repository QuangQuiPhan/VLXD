
namespace GUI.Forms
{
    partial class AccountManagement
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
            this.btnEmploy = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnAccountGroup = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnAccountGroup);
            this.panel1.Controls.Add(this.btnAccount);
            this.panel1.Controls.Add(this.btnEmploy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 332);
            this.panel1.TabIndex = 0;
            // 
            // btnEmploy
            // 
            this.btnEmploy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmploy.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmploy.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnEmploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploy.ForeColor = System.Drawing.Color.White;
            this.btnEmploy.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEmploy.IconColor = System.Drawing.Color.Black;
            this.btnEmploy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEmploy.Location = new System.Drawing.Point(56, 117);
            this.btnEmploy.Name = "btnEmploy";
            this.btnEmploy.Size = new System.Drawing.Size(160, 68);
            this.btnEmploy.TabIndex = 0;
            this.btnEmploy.Text = "Nhân viên";
            this.btnEmploy.UseVisualStyleBackColor = false;
            this.btnEmploy.Click += new System.EventHandler(this.btnEmploy_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccount.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAccount.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccount.IconColor = System.Drawing.Color.Black;
            this.btnAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccount.Location = new System.Drawing.Point(239, 117);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(160, 68);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnAccountGroup
            // 
            this.btnAccountGroup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccountGroup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAccountGroup.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAccountGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountGroup.ForeColor = System.Drawing.Color.White;
            this.btnAccountGroup.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAccountGroup.IconColor = System.Drawing.Color.Black;
            this.btnAccountGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccountGroup.Location = new System.Drawing.Point(422, 117);
            this.btnAccountGroup.Name = "btnAccountGroup";
            this.btnAccountGroup.Size = new System.Drawing.Size(160, 68);
            this.btnAccountGroup.TabIndex = 2;
            this.btnAccountGroup.Text = "Loại tài khoản";
            this.btnAccountGroup.UseVisualStyleBackColor = false;
            this.btnAccountGroup.Click += new System.EventHandler(this.btnAccountGroup_Click);
            // 
            // AccountManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.panel1);
            this.Name = "AccountManagement";
            this.Text = "AccountManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnEmploy;
        private FontAwesome.Sharp.IconButton btnAccountGroup;
        private FontAwesome.Sharp.IconButton btnAccount;
    }
}