namespace ClassAverage
{
   partial class ClassAverage
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstGrades = new System.Windows.Forms.ListBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblDescribeOutput = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.lblGradeList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(132, 38);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(72, 20);
            this.txtInput.TabIndex = 15;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(132, 174);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(72, 21);
            this.btnAverage.TabIndex = 14;
            this.btnAverage.Text = "Average";
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(132, 70);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 21);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add Grade";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstGrades
            // 
            this.lstGrades.Location = new System.Drawing.Point(20, 38);
            this.lstGrades.Name = "lstGrades";
            this.lstGrades.Size = new System.Drawing.Size(88, 160);
            this.lstGrades.TabIndex = 12;
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(132, 142);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(72, 21);
            this.lblOutput.TabIndex = 11;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescribeOutput
            // 
            this.lblDescribeOutput.Location = new System.Drawing.Point(132, 118);
            this.lblDescribeOutput.Name = "lblDescribeOutput";
            this.lblDescribeOutput.Size = new System.Drawing.Size(80, 23);
            this.lblDescribeOutput.TabIndex = 10;
            this.lblDescribeOutput.Text = "Class average:";
            this.lblDescribeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrompt
            // 
            this.lblPrompt.Location = new System.Drawing.Point(132, 14);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(80, 23);
            this.lblPrompt.TabIndex = 9;
            this.lblPrompt.Text = "Enter grade:";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGradeList
            // 
            this.lblGradeList.Location = new System.Drawing.Point(20, 14);
            this.lblGradeList.Name = "lblGradeList";
            this.lblGradeList.Size = new System.Drawing.Size(56, 23);
            this.lblGradeList.TabIndex = 8;
            this.lblGradeList.Text = "Grade list:";
            this.lblGradeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClassAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 256);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstGrades);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblDescribeOutput);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblGradeList);
            this.Name = "ClassAverage";
            this.Text = "Class Average";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtInput;
      private System.Windows.Forms.Button btnAverage;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.ListBox lstGrades;
      private System.Windows.Forms.Label lblOutput;
      private System.Windows.Forms.Label lblDescribeOutput;
      private System.Windows.Forms.Label lblPrompt;
      private System.Windows.Forms.Label lblGradeList;
   }
}

