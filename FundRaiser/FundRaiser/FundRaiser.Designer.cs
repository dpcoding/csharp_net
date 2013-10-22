namespace FundRaiser
{
    partial class FundRaiser
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
            this.btnDonate = new System.Windows.Forms.Button();
            this.txtDonation = new System.Windows.Forms.TextBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDonatedValue = new System.Windows.Forms.Label();
            this.lblDonated = new System.Windows.Forms.Label();
            this.lblDonation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDonate
            // 
            this.btnDonate.Location = new System.Drawing.Point(79, 115);
            this.btnDonate.Name = "btnDonate";
            this.btnDonate.Size = new System.Drawing.Size(104, 24);
            this.btnDonate.TabIndex = 13;
            this.btnDonate.Text = "Make Donation";
            this.btnDonate.Click += new System.EventHandler(this.btnDonate_Click);
            // 
            // txtDonation
            // 
            this.txtDonation.Location = new System.Drawing.Point(119, 19);
            this.txtDonation.Name = "txtDonation";
            this.txtDonation.Size = new System.Drawing.Size(120, 20);
            this.txtDonation.TabIndex = 12;
            this.txtDonation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalValue.Location = new System.Drawing.Point(119, 83);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(120, 20);
            this.lblTotalValue.TabIndex = 11;
            this.lblTotalValue.Text = "$0.00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(23, 83);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 20);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total raised:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonatedValue
            // 
            this.lblDonatedValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDonatedValue.Location = new System.Drawing.Point(119, 51);
            this.lblDonatedValue.Name = "lblDonatedValue";
            this.lblDonatedValue.Size = new System.Drawing.Size(120, 20);
            this.lblDonatedValue.TabIndex = 9;
            this.lblDonatedValue.Text = "$0.00";
            this.lblDonatedValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDonated
            // 
            this.lblDonated.Location = new System.Drawing.Point(23, 51);
            this.lblDonated.Name = "lblDonated";
            this.lblDonated.Size = new System.Drawing.Size(88, 20);
            this.lblDonated.TabIndex = 8;
            this.lblDonated.Text = "After expenses:";
            this.lblDonated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDonation
            // 
            this.lblDonation.Location = new System.Drawing.Point(23, 19);
            this.lblDonation.Name = "lblDonation";
            this.lblDonation.Size = new System.Drawing.Size(80, 20);
            this.lblDonation.TabIndex = 7;
            this.lblDonation.Text = "Donation:";
            this.lblDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FundRaiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 154);
            this.Controls.Add(this.btnDonate);
            this.Controls.Add(this.txtDonation);
            this.Controls.Add(this.lblTotalValue);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDonatedValue);
            this.Controls.Add(this.lblDonated);
            this.Controls.Add(this.lblDonation);
            this.Name = "FundRaiser";
            this.Text = "Fund Raiser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDonate;
        private System.Windows.Forms.TextBox txtDonation;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDonatedValue;
        private System.Windows.Forms.Label lblDonated;
        private System.Windows.Forms.Label lblDonation;
    }
}

