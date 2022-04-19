
namespace GUI
{
    partial class Invoice
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
            this.crvinvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvinvoice
            // 
            this.crvinvoice.ActiveViewIndex = -1;
            this.crvinvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvinvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvinvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvinvoice.Location = new System.Drawing.Point(0, 0);
            this.crvinvoice.Name = "crvinvoice";
            this.crvinvoice.Size = new System.Drawing.Size(800, 450);
            this.crvinvoice.TabIndex = 0;
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvinvoice);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvinvoice;
    }
}