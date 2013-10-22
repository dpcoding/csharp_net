using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace HypotenuseCalculator
{
   /// <summary>
   /// Summary description for FrmHypotenuseCalculator.
   /// </summary>
   public class FrmHypotenuseCalculator : System.Windows.Forms.Form
   {
      // Label and TextBox to input side A
      private System.Windows.Forms.Label lblSideA;
      private System.Windows.Forms.TextBox txtSideA;

      // Label and TextBox to input side B
      private System.Windows.Forms.Label lblSideB;
      private System.Windows.Forms.TextBox txtSideB;

      // Label and TextBox to display hypotenuse
      private System.Windows.Forms.Label lblSideC;
      private System.Windows.Forms.Label lblOutput;

      // Button to calculate hypotenuse
      private System.Windows.Forms.Button btnCalculate;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public FrmHypotenuseCalculator()
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
      }

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      protected override void Dispose( bool disposing )
      {
         if( disposing )
         {
            if (components != null) 
            {
               components.Dispose();
            }
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code
      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblSideA = new System.Windows.Forms.Label();
         this.lblSideB = new System.Windows.Forms.Label();
         this.lblSideC = new System.Windows.Forms.Label();
         this.lblOutput = new System.Windows.Forms.Label();
         this.txtSideA = new System.Windows.Forms.TextBox();
         this.txtSideB = new System.Windows.Forms.TextBox();
         this.btnCalculate = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblSideA
         // 
         this.lblSideA.Location = new System.Drawing.Point(16, 13);
         this.lblSideA.Name = "lblSideA";
         this.lblSideA.Size = new System.Drawing.Size(96, 21);
         this.lblSideA.TabIndex = 0;
         this.lblSideA.Text = "Length of side A:";
         this.lblSideA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblSideB
         // 
         this.lblSideB.Location = new System.Drawing.Point(16, 45);
         this.lblSideB.Name = "lblSideB";
         this.lblSideB.Size = new System.Drawing.Size(96, 21);
         this.lblSideB.TabIndex = 1;
         this.lblSideB.Text = "Length of side B:";
         this.lblSideB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblSideC
         // 
         this.lblSideC.Location = new System.Drawing.Point(16, 89);
         this.lblSideC.Name = "lblSideC";
         this.lblSideC.Size = new System.Drawing.Size(128, 21);
         this.lblSideC.TabIndex = 2;
         this.lblSideC.Text = "Length of hypotenuse:";
         this.lblSideC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblOutput
         // 
         this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblOutput.Location = new System.Drawing.Point(144, 89);
         this.lblOutput.Name = "lblOutput";
         this.lblOutput.Size = new System.Drawing.Size(64, 21);
         this.lblOutput.TabIndex = 3;
         this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtSideA
         // 
         this.txtSideA.Location = new System.Drawing.Point(144, 13);
         this.txtSideA.Name = "txtSideA";
         this.txtSideA.Size = new System.Drawing.Size(64, 21);
         this.txtSideA.TabIndex = 4;
         this.txtSideA.Text = "";
         this.txtSideA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // txtSideB
         // 
         this.txtSideB.Location = new System.Drawing.Point(144, 45);
         this.txtSideB.Name = "txtSideB";
         this.txtSideB.Size = new System.Drawing.Size(64, 21);
         this.txtSideB.TabIndex = 5;
         this.txtSideB.Text = "";
         this.txtSideB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnCalculate
         // 
         this.btnCalculate.Location = new System.Drawing.Point(64, 129);
         this.btnCalculate.Name = "btnCalculate";
         this.btnCalculate.Size = new System.Drawing.Size(144, 23);
         this.btnCalculate.TabIndex = 6;
         this.btnCalculate.Text = "Calculate Hypotenuse";
         this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
         // 
         // FrmHypotenuseCalculator
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
         this.ClientSize = new System.Drawing.Size(224, 165);
         this.Controls.Add(this.btnCalculate);
         this.Controls.Add(this.txtSideB);
         this.Controls.Add(this.txtSideA);
         this.Controls.Add(this.lblOutput);
         this.Controls.Add(this.lblSideC);
         this.Controls.Add(this.lblSideB);
         this.Controls.Add(this.lblSideA);
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
         this.Name = "FrmHypotenuseCalculator";
         this.Text = "Hypotenuse Calculator";
         this.ResumeLayout(false);

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new FrmHypotenuseCalculator() );
      }

      double Square(double dblInput)
      {
         return dblInput * dblInput;
      }

      //Definition of CalculateHypotenuse
      double CalcHypotenuse(double a, double b)
      {
         double squareSideA = Square(a);
         double squareSideB = Square(b);
         double hypotenuse = 
            Math.Sqrt(squareSideA + squareSideB);
         return hypotenuse;
      }

      // handles Calculate button's Click event
      private void btnCalculate_Click(
         object sender, System.EventArgs e )
      {
         double dblSideA;            // length of side A
         double dblSideB;            // length of side B
         double dblHypotenuse;       // length of hypotenuse
         double dblSquareSideA;      // length of side A squared
         double dblSquareSideB;      // length of side B squared
         double dblSquareHypotenuse; // length of hypotenuse squared

         dblSideA = Double.Parse( txtSideA.Text );
         dblSideB = Double.Parse( txtSideB.Text );

         // if input received is less than or equal to zero
         if ( dblSideA <= 0 || dblSideB <= 0 )
         {
            MessageBox.Show( "You must enter a non-negative number",
               "Invalid Input Entered", MessageBoxButtons.OK,
               MessageBoxIcon.Exclamation );
         }
         else
         {
            // Call 
            dblHypotenuse = CalcHypotenuse (dblSideA, dblSideB);
            lblOutput.Text = String.Format("{0:F}", dblHypotenuse);
         }

      } // end method btnCalculate_Click

   } // end class FrmHypotenuseCalculator
}

/**************************************************************************
 * (C) Copyright 1992-2004 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
