
namespace GUI.Forms
{
    partial class ProductManagement
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
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnProductType = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btnProductType);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 332);
            this.panel1.TabIndex = 0;
            // 
            // btnProduct
            // 
            this.btnProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProduct.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProduct.IconColor = System.Drawing.Color.Black;
            this.btnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProduct.Location = new System.Drawing.Point(351, 111);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(163, 68);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Sản phẩm";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnProductType
            // 
            this.btnProductType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProductType.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProductType.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnProductType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductType.ForeColor = System.Drawing.Color.White;
            this.btnProductType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnProductType.IconColor = System.Drawing.Color.Black;
            this.btnProductType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProductType.Location = new System.Drawing.Point(130, 111);
            this.btnProductType.Name = "btnProductType";
            this.btnProductType.Size = new System.Drawing.Size(163, 68);
            this.btnProductType.TabIndex = 1;
            this.btnProductType.Text = "Loại sản phẩm";
            this.btnProductType.UseVisualStyleBackColor = false;
            this.btnProductType.Click += new System.EventHandler(this.btnProductType_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 332);
            this.Controls.Add(this.panel1);
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnProductType;
        private FontAwesome.Sharp.IconButton btnProduct;
    }
}