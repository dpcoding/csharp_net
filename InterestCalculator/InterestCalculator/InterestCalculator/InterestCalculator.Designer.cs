namespace InterestCalculator
{
   partial class InterestCalculator
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
          this.txtResult = new System.Windows.Forms.TextBox();
          this.updYear = new System.Windows.Forms.NumericUpDown();
          this.btnCalculate = new System.Windows.Forms.Button();
          this.txtRate = new System.Windows.Forms.TextBox();
          this.txtPrincipal = new System.Windows.Forms.TextBox();
          this.lblYearlyAccount = new System.Windows.Forms.Label();
          this.lblYears = new System.Windows.Forms.Label();
          this.lblRate = new System.Windows.Forms.Label();
          this.lblPrincipal = new System.Windows.Forms.Label();
          ((System.ComponentModel.ISupportInitialize)(this.updYear)).BeginInit();
          this.SuspendLayout();
          // 
          // txtResult
          // 
          this.txtResult.Location = new System.Drawing.Point(5, 159);
          this.txtResult.Multiline = true;
          this.txtResult.Name = "txtResult";
          this.txtResult.ReadOnly = true;
          this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
          this.txtResult.Size = new System.Drawing.Size(272, 88);
          this.txtResult.TabIndex = 26;
          // 
          // updYear
          // 
          this.updYear.Location = new System.Drawing.Point(85, 95);
          this.updYear.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
          this.updYear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
          this.updYear.Name = "updYear";
          this.updYear.ReadOnly = true;
          this.updYear.Size = new System.Drawing.Size(104, 20);
          this.updYear.TabIndex = 25;
          this.updYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          this.updYear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
          // 
          // btnCalculate
          // 
          this.btnCalculate.Location = new System.Drawing.Point(205, 15);
          this.btnCalculate.Name = "btnCalculate";
          this.btnCalculate.Size = new System.Drawing.Size(75, 23);
          this.btnCalculate.TabIndex = 24;
          this.btnCalculate.Text = "Calculate";
          // 
          // txtRate
          // 
          this.txtRate.Location = new System.Drawing.Point(85, 55);
          this.txtRate.Name = "txtRate";
          this.txtRate.Size = new System.Drawing.Size(100, 20);
          this.txtRate.TabIndex = 23;
          this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          // 
          // txtPrincipal
          // 
          this.txtPrincipal.Location = new System.Drawing.Point(85, 15);
          this.txtPrincipal.Name = "txtPrincipal";
          this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
          this.txtPrincipal.TabIndex = 22;
          this.txtPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
          // 
          // lblYearlyAccount
          // 
          this.lblYearlyAccount.Location = new System.Drawing.Point(5, 135);
          this.lblYearlyAccount.Name = "lblYearlyAccount";
          this.lblYearlyAccount.Size = new System.Drawing.Size(128, 23);
          this.lblYearlyAccount.TabIndex = 21;
          this.lblYearlyAccount.Text = "Yearly account balance:";
          this.lblYearlyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // lblYears
          // 
          this.lblYears.Location = new System.Drawing.Point(5, 95);
          this.lblYears.Name = "lblYears";
          this.lblYears.Size = new System.Drawing.Size(48, 24);
          this.lblYears.TabIndex = 20;
          this.lblYears.Text = "Years:";
          this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // lblRate
          // 
          this.lblRate.Location = new System.Drawing.Point(5, 55);
          this.lblRate.Name = "lblRate";
          this.lblRate.Size = new System.Drawing.Size(80, 24);
          this.lblRate.TabIndex = 19;
          this.lblRate.Text = "Interest Rate:";
          this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // lblPrincipal
          // 
          this.lblPrincipal.Location = new System.Drawing.Point(5, 15);
          this.lblPrincipal.Name = "lblPrincipal";
          this.lblPrincipal.Size = new System.Drawing.Size(56, 24);
          this.lblPrincipal.TabIndex = 18;
          this.lblPrincipal.Text = "Principal:";
          this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          // 
          // InterestCalculator
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(284, 262);
          this.Controls.Add(this.txtResult);
          this.Controls.Add(this.updYear);
          this.Controls.Add(this.btnCalculate);
          this.Controls.Add(this.txtRate);
          this.Controls.Add(this.txtPrincipal);
          this.Controls.Add(this.lblYearlyAccount);
          this.Controls.Add(this.lblYears);
          this.Controls.Add(this.lblRate);
          this.Controls.Add(this.lblPrincipal);
          this.Name = "InterestCalculator";
          this.Text = "Interest Calculator";
          ((System.ComponentModel.ISupportInitialize)(this.updYear)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtResult;
      private System.Windows.Forms.NumericUpDown updYear;
      private System.Windows.Forms.Button btnCalculate;
      private System.Windows.Forms.TextBox txtRate;
      private System.Windows.Forms.TextBox txtPrincipal;
      private System.Windows.Forms.Label lblYearlyAccount;
      private System.Windows.Forms.Label lblYears;
      private System.Windows.Forms.Label lblRate;
      private System.Windows.Forms.Label lblPrincipal;
   }
}

