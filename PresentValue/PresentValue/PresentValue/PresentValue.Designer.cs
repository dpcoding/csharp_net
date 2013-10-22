namespace PresentValue
{
   partial class frmPresentValue
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
         this.txtRate = new System.Windows.Forms.TextBox();
         this.btnCalculate = new System.Windows.Forms.Button();
         this.lblAnnualAmount = new System.Windows.Forms.Label();
         this.lblYears = new System.Windows.Forms.Label();
         this.lblRate = new System.Windows.Forms.Label();
         this.txtFutureValue = new System.Windows.Forms.TextBox();
         this.lblPrincipal = new System.Windows.Forms.Label();
         this.updYear = new System.Windows.Forms.NumericUpDown();
         this.txtBox1 = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.updYear)).BeginInit();
         this.SuspendLayout();
         // 
         // txtRate
         // 
         this.txtRate.Location = new System.Drawing.Point(92, 49);
         this.txtRate.Name = "txtRate";
         this.txtRate.Size = new System.Drawing.Size(100, 20);
         this.txtRate.TabIndex = 21;
         this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnCalculate
         // 
         this.btnCalculate.Location = new System.Drawing.Point(212, 9);
         this.btnCalculate.Name = "btnCalculate";
         this.btnCalculate.Size = new System.Drawing.Size(75, 23);
         this.btnCalculate.TabIndex = 20;
         this.btnCalculate.Text = "Calculate";
         this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
         // 
         // lblAnnualAmount
         // 
         this.lblAnnualAmount.Location = new System.Drawing.Point(12, 129);
         this.lblAnnualAmount.Name = "lblAnnualAmount";
         this.lblAnnualAmount.Size = new System.Drawing.Size(128, 23);
         this.lblAnnualAmount.TabIndex = 19;
         this.lblAnnualAmount.Text = "Annual amount needed:";
         this.lblAnnualAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblYears
         // 
         this.lblYears.Location = new System.Drawing.Point(12, 89);
         this.lblYears.Name = "lblYears";
         this.lblYears.Size = new System.Drawing.Size(48, 24);
         this.lblYears.TabIndex = 18;
         this.lblYears.Text = "Years:";
         this.lblYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblRate
         // 
         this.lblRate.Location = new System.Drawing.Point(12, 49);
         this.lblRate.Name = "lblRate";
         this.lblRate.Size = new System.Drawing.Size(72, 24);
         this.lblRate.TabIndex = 17;
         this.lblRate.Text = "Interest rate:";
         this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtFutureValue
         // 
         this.txtFutureValue.Location = new System.Drawing.Point(92, 9);
         this.txtFutureValue.Name = "txtFutureValue";
         this.txtFutureValue.Size = new System.Drawing.Size(100, 20);
         this.txtFutureValue.TabIndex = 16;
         this.txtFutureValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblPrincipal
         // 
         this.lblPrincipal.Location = new System.Drawing.Point(12, 9);
         this.lblPrincipal.Name = "lblPrincipal";
         this.lblPrincipal.Size = new System.Drawing.Size(72, 24);
         this.lblPrincipal.TabIndex = 15;
         this.lblPrincipal.Text = "Future value:";
         this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // updYear
         // 
         this.updYear.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.updYear.Location = new System.Drawing.Point(92, 93);
         this.updYear.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
         this.updYear.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
         this.updYear.Name = "updYear";
         this.updYear.ReadOnly = true;
         this.updYear.Size = new System.Drawing.Size(100, 20);
         this.updYear.TabIndex = 22;
         this.updYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.updYear.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
         // 
         // txtBox1
         // 
         this.txtBox1.Location = new System.Drawing.Point(15, 155);
         this.txtBox1.Multiline = true;
         this.txtBox1.Name = "txtBox1";
         this.txtBox1.ReadOnly = true;
         this.txtBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.txtBox1.Size = new System.Drawing.Size(272, 88);
         this.txtBox1.TabIndex = 23;
         // 
         // frmPresentValue
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(308, 257);
         this.Controls.Add(this.txtBox1);
         this.Controls.Add(this.updYear);
         this.Controls.Add(this.txtRate);
         this.Controls.Add(this.btnCalculate);
         this.Controls.Add(this.lblAnnualAmount);
         this.Controls.Add(this.lblYears);
         this.Controls.Add(this.lblRate);
         this.Controls.Add(this.txtFutureValue);
         this.Controls.Add(this.lblPrincipal);
         this.Name = "frmPresentValue";
         this.Text = "Precent Value Calculator";
         ((System.ComponentModel.ISupportInitialize)(this.updYear)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtRate;
      private System.Windows.Forms.Button btnCalculate;
      private System.Windows.Forms.Label lblAnnualAmount;
      private System.Windows.Forms.Label lblYears;
      private System.Windows.Forms.Label lblRate;
      private System.Windows.Forms.TextBox txtFutureValue;
      private System.Windows.Forms.Label lblPrincipal;
      private System.Windows.Forms.NumericUpDown updYear;
      private System.Windows.Forms.TextBox txtBox1;
   }
}

