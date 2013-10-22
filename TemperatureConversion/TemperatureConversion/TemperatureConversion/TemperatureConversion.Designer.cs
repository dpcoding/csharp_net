namespace TemperatureConversion
{
   partial class TemperatureConversion
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
         this.btnConvertCelsius = new System.Windows.Forms.Button();
         this.btnConvertFahrenheit = new System.Windows.Forms.Button();
         this.lblOutput = new System.Windows.Forms.Label();
         this.txtDegrees = new System.Windows.Forms.TextBox();
         this.lblDegrees = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnConvertCelsius
         // 
         this.btnConvertCelsius.Location = new System.Drawing.Point(130, 105);
         this.btnConvertCelsius.Name = "btnConvertCelsius";
         this.btnConvertCelsius.Size = new System.Drawing.Size(72, 40);
         this.btnConvertCelsius.TabIndex = 21;
         this.btnConvertCelsius.Text = "Convert To Celsius";
         this.btnConvertCelsius.Click += new System.EventHandler(this.btnConvertCelsius_Click);
         // 
         // btnConvertFahrenheit
         // 
         this.btnConvertFahrenheit.Location = new System.Drawing.Point(18, 105);
         this.btnConvertFahrenheit.Name = "btnConvertFahrenheit";
         this.btnConvertFahrenheit.Size = new System.Drawing.Size(72, 40);
         this.btnConvertFahrenheit.TabIndex = 20;
         this.btnConvertFahrenheit.Text = "Convert To Fahrenheit";
         this.btnConvertFahrenheit.Click += new System.EventHandler(this.btnConvertFahrenheit_Click);
         // 
         // lblOutput
         // 
         this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.lblOutput.Location = new System.Drawing.Point(18, 57);
         this.lblOutput.Name = "lblOutput";
         this.lblOutput.Size = new System.Drawing.Size(184, 32);
         this.lblOutput.TabIndex = 19;
         this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // txtDegrees
         // 
         this.txtDegrees.Location = new System.Drawing.Point(138, 17);
         this.txtDegrees.Name = "txtDegrees";
         this.txtDegrees.Size = new System.Drawing.Size(64, 20);
         this.txtDegrees.TabIndex = 18;
         this.txtDegrees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // lblDegrees
         // 
         this.lblDegrees.Location = new System.Drawing.Point(18, 17);
         this.lblDegrees.Name = "lblDegrees";
         this.lblDegrees.Size = new System.Drawing.Size(56, 21);
         this.lblDegrees.TabIndex = 17;
         this.lblDegrees.Text = "Degrees:";
         this.lblDegrees.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // TemperatureConversion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(224, 161);
         this.Controls.Add(this.btnConvertCelsius);
         this.Controls.Add(this.btnConvertFahrenheit);
         this.Controls.Add(this.lblOutput);
         this.Controls.Add(this.txtDegrees);
         this.Controls.Add(this.lblDegrees);
         this.Name = "TemperatureConversion";
         this.Text = "Temperature Converter";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnConvertCelsius;
      private System.Windows.Forms.Button btnConvertFahrenheit;
      private System.Windows.Forms.Label lblOutput;
      private System.Windows.Forms.TextBox txtDegrees;
      private System.Windows.Forms.Label lblDegrees;
   }
}

