﻿namespace GenkinTest
{
    partial class Form1
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
            this.Btn_Click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Click
            // 
            this.Btn_Click.Location = new System.Drawing.Point(111, 87);
            this.Btn_Click.Name = "Btn_Click";
            this.Btn_Click.Size = new System.Drawing.Size(75, 23);
            this.Btn_Click.TabIndex = 0;
            this.Btn_Click.Text = "Click";
            this.Btn_Click.UseVisualStyleBackColor = true;
            this.Btn_Click.Click += new System.EventHandler(this.Btn_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Btn_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Click;
    }
}

