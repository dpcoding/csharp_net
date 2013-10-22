using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace MilesPerGallon
{
   /// <summary>
   /// Summary description for FrmMilesPerGallon.
   /// </summary>
   public class FrmMilesPerGallon : System.Windows.Forms.Form
   {
      // Label and TextBox to input miles driven
      private System.Windows.Forms.Label lblMilesDriven;
      private System.Windows.Forms.TextBox txtMilesDriven;

      // Label and TextBox to input gallons used
      private System.Windows.Forms.Label lblGallonsUsed;
      private System.Windows.Forms.TextBox txtGallonsUsed;

      // Labels to output miles per gallon
      private System.Windows.Forms.Label lblMilesPerGallon;
      private System.Windows.Forms.Label lblOutputValue;

      // Button to calculate miles per gallon
      private System.Windows.Forms.Button btnCalculateMPG;

      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.Container components = null;

      public FrmMilesPerGallon()
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
         this.lblMilesDriven = new System.Windows.Forms.Label();
         this.txtMilesDriven = new System.Windows.Forms.TextBox();
         this.lblGallonsUsed = new System.Windows.Forms.Label();
         this.txtGallonsUsed = new System.Windows.Forms.TextBox();
         this.lblMilesPerGallon = new System.Windows.Forms.Label();
         this.lblOutputValue = new System.Windows.Forms.Label();
         this.btnCalculateMPG = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblMilesDriven
         // 
         this.lblMilesDriven.Location = new System.Drawing.Point(16, 16);
         this.lblMilesDriven.Name = "lblMilesDriven";
         this.lblMilesDriven.Size = new System.Drawing.Size(81, 21);
         this.lblMilesDriven.TabIndex = 2;
         this.lblMilesDriven.Text = "Miles driven:";
         this.lblMilesDriven.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtMilesDriven
         // 
         this.txtMilesDriven.Location = new System.Drawing.Point(128, 16);
         this.txtMilesDriven.Name = "txtMilesDriven";
         this.txtMilesDriven.Size = new System.Drawing.Size(64, 21);
         this.txtMilesDriven.TabIndex = 4;
         this.txtMilesDriven.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblGallonsUsed
         // 
         this.lblGallonsUsed.Location = new System.Drawing.Point(16, 56);
         this.lblGallonsUsed.Name = "lblGallonsUsed";
         this.lblGallonsUsed.Size = new System.Drawing.Size(81, 21);
         this.lblGallonsUsed.TabIndex = 5;
         this.lblGallonsUsed.Text = "Gallons used:";
         this.lblGallonsUsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // txtGallonsUsed
         // 
         this.txtGallonsUsed.Location = new System.Drawing.Point(128, 56);
         this.txtGallonsUsed.Name = "txtGallonsUsed";
         this.txtGallonsUsed.Size = new System.Drawing.Size(64, 21);
         this.txtGallonsUsed.TabIndex = 6;
         this.txtGallonsUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblMilesPerGallon
         // 
         this.lblMilesPerGallon.Location = new System.Drawing.Point(16, 104);
         this.lblMilesPerGallon.Name = "lblMilesPerGallon";
         this.lblMilesPerGallon.Size = new System.Drawing.Size(88, 21);
         this.lblMilesPerGallon.TabIndex = 7;
         this.lblMilesPerGallon.Text = "Miles per gallon:";
         this.lblMilesPerGallon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // lblOutputValue
         // 
         this.lblOutputValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblOutputValue.Location = new System.Drawing.Point(128, 104);
         this.lblOutputValue.Name = "lblOutputValue";
         this.lblOutputValue.Size = new System.Drawing.Size(64, 23);
         this.lblOutputValue.TabIndex = 8;
         this.lblOutputValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnCalculateMPG
         // 
         this.btnCalculateMPG.Location = new System.Drawing.Point(104, 144);
         this.btnCalculateMPG.Name = "btnCalculateMPG";
         this.btnCalculateMPG.Size = new System.Drawing.Size(92, 23);
         this.btnCalculateMPG.TabIndex = 9;
         this.btnCalculateMPG.Text = "Calculate MPG";
         this.btnCalculateMPG.Click += new System.EventHandler(this.btnCalculateMPG_Click);
         // 
         // FrmMilesPerGallon
         // 
         this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
         this.ClientSize = new System.Drawing.Size(216, 181);
         this.Controls.Add(this.btnCalculateMPG);
         this.Controls.Add(this.lblOutputValue);
         this.Controls.Add(this.lblMilesPerGallon);
         this.Controls.Add(this.txtGallonsUsed);
         this.Controls.Add(this.lblGallonsUsed);
         this.Controls.Add(this.txtMilesDriven);
         this.Controls.Add(this.lblMilesDriven);
         this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Name = "FrmMilesPerGallon";
         this.Text = "Miles Per Gallon";
         this.ResumeLayout(false);
         this.PerformLayout();

      }
      #endregion

      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main() 
      {
         Application.Run( new FrmMilesPerGallon() );
      }

      double CalculateMpg(double milesDriven, double gallonsUsed)
      {
         return milesDriven / gallonsUsed;
      }

      private void btnCalculateMPG_Click(object sender, EventArgs e)
      {
         double milesDriven = double.Parse(txtMilesDriven.Text);
         double gallonsUsed = double.Parse(txtGallonsUsed.Text);
         double mpg;

         mpg = CalculateMpg(milesDriven, gallonsUsed);
         lblOutputValue.Text = String.Format("{0:F}", mpg);
      }

   } // end class FrmMilesPerGallon
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