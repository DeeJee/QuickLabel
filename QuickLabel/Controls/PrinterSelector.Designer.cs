﻿namespace QuickLabel.Controls
{
    partial class PrinterSelector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLandscape = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AlwaysShowPrintDialog = new System.Windows.Forms.CheckBox();
            this.Paper = new System.Windows.Forms.ComboBox();
            this.Printer = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbxLandscape);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.AlwaysShowPrintDialog);
            this.groupBox2.Controls.Add(this.Paper);
            this.groupBox2.Controls.Add(this.Printer);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(348, 338);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 266);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Afdrukrichting";
            // 
            // cbxLandscape
            // 
            this.cbxLandscape.AutoSize = true;
            this.cbxLandscape.Location = new System.Drawing.Point(24, 295);
            this.cbxLandscape.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbxLandscape.Name = "cbxLandscape";
            this.cbxLandscape.Size = new System.Drawing.Size(135, 29);
            this.cbxLandscape.TabIndex = 17;
            this.cbxLandscape.Text = "Landscape";
            this.cbxLandscape.UseVisualStyleBackColor = true;
            this.cbxLandscape.CheckedChanged += new System.EventHandler(this.cbxLandscape_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Standaard papier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Standaard printer";
            // 
            // AlwaysShowPrintDialog
            // 
            this.AlwaysShowPrintDialog.AutoSize = true;
            this.AlwaysShowPrintDialog.Location = new System.Drawing.Point(11, 37);
            this.AlwaysShowPrintDialog.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AlwaysShowPrintDialog.Name = "AlwaysShowPrintDialog";
            this.AlwaysShowPrintDialog.Size = new System.Drawing.Size(261, 29);
            this.AlwaysShowPrintDialog.TabIndex = 14;
            this.AlwaysShowPrintDialog.Text = "Altijd printer dialoog tonen";
            this.AlwaysShowPrintDialog.UseVisualStyleBackColor = true;
            this.AlwaysShowPrintDialog.CheckedChanged += new System.EventHandler(this.AlwaysShowPrintDialog_CheckedChanged);
            // 
            // Paper
            // 
            this.Paper.FormattingEnabled = true;
            this.Paper.Location = new System.Drawing.Point(18, 205);
            this.Paper.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Paper.Name = "Paper";
            this.Paper.Size = new System.Drawing.Size(305, 32);
            this.Paper.TabIndex = 13;
            this.Paper.SelectedIndexChanged += new System.EventHandler(this.Paper_SelectedIndexChanged);
            // 
            // Printer
            // 
            this.Printer.FormattingEnabled = true;
            this.Printer.Location = new System.Drawing.Point(18, 111);
            this.Printer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Printer.Name = "Printer";
            this.Printer.Size = new System.Drawing.Size(305, 32);
            this.Printer.TabIndex = 1;
            this.Printer.SelectedIndexChanged += new System.EventHandler(this.Printer_SelectedIndexChanged);
            // 
            // PrinterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PrinterSelector";
            this.Size = new System.Drawing.Size(363, 351);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Paper;
        private System.Windows.Forms.ComboBox Printer;
        private System.Windows.Forms.CheckBox AlwaysShowPrintDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxLandscape;
    }
}
