namespace SecurityPanel
{
    partial class SecurityPanel
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.lstLogEntry = new System.Windows.Forms.ListBox();
            this.lblAccessLog = new System.Windows.Forms.Label();
            this.txtSecurityCode = new System.Windows.Forms.TextBox();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(144, 138);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(24, 24);
            this.btnEnter.TabIndex = 31;
            this.btnEnter.Text = "#";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(96, 138);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(24, 24);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "C";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(120, 138);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(24, 24);
            this.btnZero.TabIndex = 29;
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(144, 114);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(24, 24);
            this.btnNine.TabIndex = 28;
            this.btnNine.Text = "9";
            this.btnNine.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(120, 114);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(24, 24);
            this.btnEight.TabIndex = 27;
            this.btnEight.Text = "8";
            this.btnEight.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(96, 114);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(24, 24);
            this.btnSeven.TabIndex = 26;
            this.btnSeven.Text = "7";
            this.btnSeven.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(144, 90);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(24, 24);
            this.btnSix.TabIndex = 25;
            this.btnSix.Text = "6";
            this.btnSix.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(120, 90);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(24, 24);
            this.btnFive.TabIndex = 24;
            this.btnFive.Text = "5";
            this.btnFive.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(96, 90);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(24, 24);
            this.btnFour.TabIndex = 23;
            this.btnFour.Text = "4";
            this.btnFour.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(144, 66);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(24, 24);
            this.btnThree.TabIndex = 22;
            this.btnThree.Text = "3";
            this.btnThree.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(120, 66);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(24, 24);
            this.btnTwo.TabIndex = 21;
            this.btnTwo.Text = "2";
            this.btnTwo.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(96, 66);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(24, 24);
            this.btnOne.TabIndex = 20;
            this.btnOne.Text = "1";
            this.btnOne.Click += new System.EventHandler(this.btnNumberKey_Click);
            // 
            // lstLogEntry
            // 
            this.lstLogEntry.Location = new System.Drawing.Point(16, 210);
            this.lstLogEntry.Name = "lstLogEntry";
            this.lstLogEntry.Size = new System.Drawing.Size(232, 95);
            this.lstLogEntry.TabIndex = 19;
            // 
            // lblAccessLog
            // 
            this.lblAccessLog.Location = new System.Drawing.Point(16, 186);
            this.lblAccessLog.Name = "lblAccessLog";
            this.lblAccessLog.Size = new System.Drawing.Size(100, 16);
            this.lblAccessLog.TabIndex = 18;
            this.lblAccessLog.Text = "Access log:";
            this.lblAccessLog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSecurityCode
            // 
            this.txtSecurityCode.Enabled = false;
            this.txtSecurityCode.Location = new System.Drawing.Point(104, 18);
            this.txtSecurityCode.Name = "txtSecurityCode";
            this.txtSecurityCode.PasswordChar = '*';
            this.txtSecurityCode.ReadOnly = true;
            this.txtSecurityCode.Size = new System.Drawing.Size(144, 20);
            this.txtSecurityCode.TabIndex = 17;
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.Location = new System.Drawing.Point(16, 18);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(80, 21);
            this.lblSecurityCode.TabIndex = 16;
            this.lblSecurityCode.Text = "Security code:";
            this.lblSecurityCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecurityPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 338);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.lstLogEntry);
            this.Controls.Add(this.lblAccessLog);
            this.Controls.Add(this.txtSecurityCode);
            this.Controls.Add(this.lblSecurityCode);
            this.Name = "SecurityPanel";
            this.Text = "Security Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.ListBox lstLogEntry;
        private System.Windows.Forms.Label lblAccessLog;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.Label lblSecurityCode;
    }
}

