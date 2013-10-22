namespace CashRegister
{
   partial class FrmCashRegister
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
         this.lblTotalValue = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.lblTaxValue = new System.Windows.Forms.Label();
         this.lblTax = new System.Windows.Forms.Label();
         this.lblSubTotalValue = new System.Windows.Forms.Label();
         this.lblSubtotal = new System.Windows.Forms.Label();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnTotal = new System.Windows.Forms.Button();
         this.btnEnter = new System.Windows.Forms.Button();
         this.btnPoint = new System.Windows.Forms.Button();
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
         this.txtCurrentPrice = new System.Windows.Forms.TextBox();
         this.lblDollarSign = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblTotalValue
         // 
         this.lblTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblTotalValue.Location = new System.Drawing.Point(91, 252);
         this.lblTotalValue.Name = "lblTotalValue";
         this.lblTotalValue.Size = new System.Drawing.Size(100, 23);
         this.lblTotalValue.TabIndex = 101;
         this.lblTotalValue.Text = "$0.00";
         this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblTotal
         // 
         this.lblTotal.Location = new System.Drawing.Point(19, 252);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(56, 23);
         this.lblTotal.TabIndex = 100;
         this.lblTotal.Text = "Total:";
         this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblTaxValue
         // 
         this.lblTaxValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblTaxValue.Location = new System.Drawing.Point(91, 212);
         this.lblTaxValue.Name = "lblTaxValue";
         this.lblTaxValue.Size = new System.Drawing.Size(100, 23);
         this.lblTaxValue.TabIndex = 99;
         this.lblTaxValue.Text = "$0.00";
         this.lblTaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblTax
         // 
         this.lblTax.Location = new System.Drawing.Point(19, 212);
         this.lblTax.Name = "lblTax";
         this.lblTax.Size = new System.Drawing.Size(56, 23);
         this.lblTax.TabIndex = 98;
         this.lblTax.Text = "Tax:";
         this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblSubTotalValue
         // 
         this.lblSubTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblSubTotalValue.Location = new System.Drawing.Point(91, 172);
         this.lblSubTotalValue.Name = "lblSubTotalValue";
         this.lblSubTotalValue.Size = new System.Drawing.Size(100, 23);
         this.lblSubTotalValue.TabIndex = 97;
         this.lblSubTotalValue.Text = "$0.00";
         this.lblSubTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
         // 
         // lblSubtotal
         // 
         this.lblSubtotal.Location = new System.Drawing.Point(19, 172);
         this.lblSubtotal.Name = "lblSubtotal";
         this.lblSubtotal.Size = new System.Drawing.Size(56, 23);
         this.lblSubtotal.TabIndex = 96;
         this.lblSubtotal.Text = "Subtotal:";
         this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(123, 124);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(48, 24);
         this.btnClear.TabIndex = 95;
         this.btnClear.Text = "Clear";
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(123, 100);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(48, 24);
         this.btnDelete.TabIndex = 94;
         this.btnDelete.Text = "Delete";
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnTotal
         // 
         this.btnTotal.Location = new System.Drawing.Point(123, 76);
         this.btnTotal.Name = "btnTotal";
         this.btnTotal.Size = new System.Drawing.Size(48, 24);
         this.btnTotal.TabIndex = 93;
         this.btnTotal.Text = "Total";
         this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
         // 
         // btnEnter
         // 
         this.btnEnter.Location = new System.Drawing.Point(123, 52);
         this.btnEnter.Name = "btnEnter";
         this.btnEnter.Size = new System.Drawing.Size(48, 24);
         this.btnEnter.TabIndex = 92;
         this.btnEnter.Text = "Enter";
         this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
         // 
         // btnPoint
         // 
         this.btnPoint.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnPoint.Location = new System.Drawing.Point(83, 124);
         this.btnPoint.Name = "btnPoint";
         this.btnPoint.Size = new System.Drawing.Size(24, 24);
         this.btnPoint.TabIndex = 91;
         this.btnPoint.Text = ".";
         this.btnPoint.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnZero
         // 
         this.btnZero.Location = new System.Drawing.Point(59, 124);
         this.btnZero.Name = "btnZero";
         this.btnZero.Size = new System.Drawing.Size(24, 24);
         this.btnZero.TabIndex = 90;
         this.btnZero.Text = "0";
         this.btnZero.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnNine
         // 
         this.btnNine.Location = new System.Drawing.Point(83, 100);
         this.btnNine.Name = "btnNine";
         this.btnNine.Size = new System.Drawing.Size(24, 24);
         this.btnNine.TabIndex = 89;
         this.btnNine.Text = "9";
         this.btnNine.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnEight
         // 
         this.btnEight.Location = new System.Drawing.Point(59, 100);
         this.btnEight.Name = "btnEight";
         this.btnEight.Size = new System.Drawing.Size(24, 24);
         this.btnEight.TabIndex = 88;
         this.btnEight.Text = "8";
         this.btnEight.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnSeven
         // 
         this.btnSeven.Location = new System.Drawing.Point(35, 100);
         this.btnSeven.Name = "btnSeven";
         this.btnSeven.Size = new System.Drawing.Size(24, 24);
         this.btnSeven.TabIndex = 87;
         this.btnSeven.Text = "7";
         this.btnSeven.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnSix
         // 
         this.btnSix.Location = new System.Drawing.Point(83, 76);
         this.btnSix.Name = "btnSix";
         this.btnSix.Size = new System.Drawing.Size(24, 24);
         this.btnSix.TabIndex = 86;
         this.btnSix.Text = "6";
         this.btnSix.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnFive
         // 
         this.btnFive.Location = new System.Drawing.Point(59, 76);
         this.btnFive.Name = "btnFive";
         this.btnFive.Size = new System.Drawing.Size(24, 24);
         this.btnFive.TabIndex = 85;
         this.btnFive.Text = "5";
         this.btnFive.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnFour
         // 
         this.btnFour.Location = new System.Drawing.Point(35, 76);
         this.btnFour.Name = "btnFour";
         this.btnFour.Size = new System.Drawing.Size(24, 24);
         this.btnFour.TabIndex = 84;
         this.btnFour.Text = "4";
         this.btnFour.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnThree
         // 
         this.btnThree.Location = new System.Drawing.Point(83, 52);
         this.btnThree.Name = "btnThree";
         this.btnThree.Size = new System.Drawing.Size(24, 24);
         this.btnThree.TabIndex = 83;
         this.btnThree.Text = "3";
         this.btnThree.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnTwo
         // 
         this.btnTwo.Location = new System.Drawing.Point(59, 52);
         this.btnTwo.Name = "btnTwo";
         this.btnTwo.Size = new System.Drawing.Size(24, 24);
         this.btnTwo.TabIndex = 82;
         this.btnTwo.Text = "2";
         this.btnTwo.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // btnOne
         // 
         this.btnOne.Location = new System.Drawing.Point(35, 52);
         this.btnOne.Name = "btnOne";
         this.btnOne.Size = new System.Drawing.Size(24, 24);
         this.btnOne.TabIndex = 81;
         this.btnOne.Text = "1";
         this.btnOne.Click += new System.EventHandler(this.btnNumberKey_Click);
         // 
         // txtCurrentPrice
         // 
         this.txtCurrentPrice.Location = new System.Drawing.Point(33, 12);
         this.txtCurrentPrice.Name = "txtCurrentPrice";
         this.txtCurrentPrice.ReadOnly = true;
         this.txtCurrentPrice.Size = new System.Drawing.Size(162, 20);
         this.txtCurrentPrice.TabIndex = 80;
         // 
         // lblDollarSign
         // 
         this.lblDollarSign.Location = new System.Drawing.Point(19, 12);
         this.lblDollarSign.Name = "lblDollarSign";
         this.lblDollarSign.Size = new System.Drawing.Size(8, 21);
         this.lblDollarSign.TabIndex = 79;
         this.lblDollarSign.Text = "$";
         this.lblDollarSign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // FrmCashRegister
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(225, 319);
         this.Controls.Add(this.lblTotalValue);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.lblTaxValue);
         this.Controls.Add(this.lblTax);
         this.Controls.Add(this.lblSubTotalValue);
         this.Controls.Add(this.lblSubtotal);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnTotal);
         this.Controls.Add(this.btnEnter);
         this.Controls.Add(this.btnPoint);
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
         this.Controls.Add(this.txtCurrentPrice);
         this.Controls.Add(this.lblDollarSign);
         this.Name = "FrmCashRegister";
         this.Text = "Cash Register";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTotalValue;
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.Label lblTaxValue;
      private System.Windows.Forms.Label lblTax;
      private System.Windows.Forms.Label lblSubTotalValue;
      private System.Windows.Forms.Label lblSubtotal;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnTotal;
      private System.Windows.Forms.Button btnEnter;
      private System.Windows.Forms.Button btnPoint;
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
      private System.Windows.Forms.TextBox txtCurrentPrice;
      private System.Windows.Forms.Label lblDollarSign;
   }
}

