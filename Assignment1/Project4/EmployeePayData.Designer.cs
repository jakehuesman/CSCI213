﻿namespace Project4
{
    partial class EmployeePayData
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
            this.employeePayDataDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // employeePayDataDisplay
            // 
            this.employeePayDataDisplay.Location = new System.Drawing.Point(12, 12);
            this.employeePayDataDisplay.Name = "employeePayDataDisplay";
            this.employeePayDataDisplay.ReadOnly = true;
            this.employeePayDataDisplay.Size = new System.Drawing.Size(374, 445);
            this.employeePayDataDisplay.TabIndex = 0;
            this.employeePayDataDisplay.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 469);
            this.Controls.Add(this.employeePayDataDisplay);
            this.Name = "Form2";
            this.Text = "Employee Pay Data";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox employeePayDataDisplay;
    }
}