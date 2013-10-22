namespace ScreenScraping2010
{
    partial class FrmScreenScraping
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
            this.lblHTML = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cboItems = new System.Windows.Forms.ComboBox();
            this.lblItem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHTML
            // 
            this.lblHTML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHTML.Location = new System.Drawing.Point(34, 119);
            this.lblHTML.Name = "lblHTML";
            this.lblHTML.Size = new System.Drawing.Size(224, 112);
            this.lblHTML.TabIndex = 13;
            // 
            // lblSource
            // 
            this.lblSource.Location = new System.Drawing.Point(26, 95);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(48, 16);
            this.lblSource.TabIndex = 8;
            this.lblSource.Text = "Source:";
            this.lblSource.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(178, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "&Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(74, 63);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(96, 21);
            this.lblResult.TabIndex = 10;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Location = new System.Drawing.Point(26, 63);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 21);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboItems
            // 
            this.cboItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItems.Items.AddRange(new object[] {
            "Antique Rocking Chair",
            "Silver Teapot",
            "Gold Pocket Watch"});
            this.cboItems.Location = new System.Drawing.Point(74, 31);
            this.cboItems.Name = "cboItems";
            this.cboItems.Size = new System.Drawing.Size(184, 21);
            this.cboItems.TabIndex = 12;
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(26, 31);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(40, 21);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Item:";
            this.lblItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmScreenScraping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblHTML);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.cboItems);
            this.Controls.Add(this.lblItem);
            this.Name = "FrmScreenScraping";
            this.Text = "Screen Scraping";
            this.Load += new System.EventHandler(this.FrmScreenScraping_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHTML;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cboItems;
        private System.Windows.Forms.Label lblItem;
    }
}

