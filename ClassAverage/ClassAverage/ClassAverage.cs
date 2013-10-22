using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassAverage
{
   public partial class ClassAverage : Form
   {
      public ClassAverage()
      {
         InitializeComponent();
      }

      // set the limit of 10 grades
      const int LIMIT = 10;

      // handles btnAdd_Click event
      private void btnAdd_Click(object sender, EventArgs e)
      {
          try
          {
              // Clear the average and the list of grades
              if (lblOutput.Text != "")
              {
                  lblOutput.Text = "";
                  lstGrades.Items.Clear();
              }
            /*  else //adding this to show messagebox. more to fix
              {
                  
              } */

              // declare the value from user input
              int grade = Int32.Parse(txtInput.Text);

              lstGrades.Items.Add(Int32.Parse(txtInput.Text));
              txtInput.Text = "";
              txtInput.Focus();

              // if there are 10 grades entered
              if (lstGrades.Items.Count == LIMIT)
              {
                  // disable the textbox and set the focus back to the average button
                  btnAdd.Enabled = false;
                  btnAverage.Focus();
              } // end if
          }// end try
          catch
          {
              MessageBox.Show("Please enter a grade.", "Danger!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
      } // end btnAdd_Click event

      // handles btnAverage_Click event
      private void btnAverage_Click(object sender, EventArgs e)
      {
         // declare variables
         int total = 0;
         int gradeCounter = 0;
         int grade;
         double average;

         /* this is do-whie loop 
         do
         {
            grade = (int)(lstGrades.Items[gradeCounter]);
            total += grade;
            gradeCounter++;
         } while (gradeCounter < lstGrades.Items.Count); 
        */

         //this uses for loop either way
         for (gradeCounter = 0; gradeCounter < lstGrades.Items.Count; gradeCounter++)
         {
             grade = (int)(lstGrades.Items[gradeCounter]);
             total += grade;
         }

         // calculate and display the output
         average = (double)total / lstGrades.Items.Count;
         lblOutput.Text = String.Format("{0:F}", average);

         // enable and set the focus back to the input section of the form
         btnAdd.Enabled = true;
         txtInput.Focus();

      } // end method btnAverage_Click event

   } // end class FrmClassAverage

}

