using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureConversion
{
   public partial class TemperatureConversion : Form
   {
      public TemperatureConversion()
      {
         InitializeComponent();
      }

      double c = 0;
      double f = 0;

      double ConvertToCelsius(double f)
      {
         return c = (5.0 / 9) * (f - 32);
      }

      double ConvertToFahrenheit(double c)
      {
         return f = (9.0 / 5) * c + 32;
      }

      private void btnConvertCelsius_Click(object sender, EventArgs e)
      {
         double f = double.Parse(txtDegrees.Text);
         double c;

         c = ConvertToCelsius(f);
         lblOutput.Text = String.Format(
            "{0:F}", f + " degrees Fahrenheit is equal to " + c + " degrees Celsius.");
      }

      private void btnConvertFahrenheit_Click(object sender, EventArgs e)
      {
         double c = double.Parse(txtDegrees.Text);
         double f;

         f = ConvertToFahrenheit(c);
         lblOutput.Text = String.Format(
            "{0:F}", c + " degrees Celsius is equal to " + f + " degrees Fahrenheit.");
      }      
   }
}
