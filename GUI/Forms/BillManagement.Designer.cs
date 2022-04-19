
namespace GUI.Forms
{
    partial class BillManagement
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
            this.btnCustomer = new FontAwesome.Sharp.IconButton();
            this.btnBill = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 332);
            this.panel1.TabIndex = 0;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCustomer.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCustomer.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCustomer.IconColor = System.Drawing.Color.Black;
            this.btnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomer.Location = new System.Drawing.Point(149, 133);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(163, 68);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnBill
            // 
            this.btnBill.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBill.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBill.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBill.IconColor = System.Drawing.Color.Black;
            this.btnBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBill.Location = new System.Drawing.Point(336, 133);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(163, 68);
            this.btnBill.TabIndex = 3;
            this.btnBill.Text = "Đơn hàng";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.panel1);
            this.Name = "BillManagement";
            this.Text = "BillManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBill;
        private FontAwesome.Sharp.IconButton btnCustomer;
    }
}