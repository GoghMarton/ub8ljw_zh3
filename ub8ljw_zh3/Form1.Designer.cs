﻿namespace ub8ljw_zh3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUC1 = new System.Windows.Forms.Button();
            this.buttonUC2 = new System.Windows.Forms.Button();
            this.buttonUC3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonUC1
            // 
            this.buttonUC1.Location = new System.Drawing.Point(93, 36);
            this.buttonUC1.Name = "buttonUC1";
            this.buttonUC1.Size = new System.Drawing.Size(153, 70);
            this.buttonUC1.TabIndex = 0;
            this.buttonUC1.Text = "UserControl1";
            this.buttonUC1.UseVisualStyleBackColor = true;
            this.buttonUC1.Click += new System.EventHandler(this.buttonUC1_Click);
            // 
            // buttonUC2
            // 
            this.buttonUC2.Location = new System.Drawing.Point(441, 36);
            this.buttonUC2.Name = "buttonUC2";
            this.buttonUC2.Size = new System.Drawing.Size(153, 70);
            this.buttonUC2.TabIndex = 1;
            this.buttonUC2.Text = "UserControl2";
            this.buttonUC2.UseVisualStyleBackColor = true;
            this.buttonUC2.Click += new System.EventHandler(this.buttonUC2_Click);
            // 
            // buttonUC3
            // 
            this.buttonUC3.Location = new System.Drawing.Point(796, 36);
            this.buttonUC3.Name = "buttonUC3";
            this.buttonUC3.Size = new System.Drawing.Size(153, 70);
            this.buttonUC3.TabIndex = 2;
            this.buttonUC3.Text = "UserControl3";
            this.buttonUC3.UseVisualStyleBackColor = true;
            this.buttonUC3.Click += new System.EventHandler(this.buttonUC3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(100, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 385);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 577);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonUC3);
            this.Controls.Add(this.buttonUC2);
            this.Controls.Add(this.buttonUC1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonUC1;
        private Button buttonUC2;
        private Button buttonUC3;
        private Panel panel1;
    }
}