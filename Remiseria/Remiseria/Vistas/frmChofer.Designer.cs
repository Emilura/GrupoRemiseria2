﻿namespace Remiseria.Vistas
{
    partial class frmChofer
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
            this.dgvChofer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChofer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChofer
            // 
            this.dgvChofer.AllowUserToAddRows = false;
            this.dgvChofer.AllowUserToDeleteRows = false;
            this.dgvChofer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChofer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChofer.Location = new System.Drawing.Point(0, 300);
            this.dgvChofer.Name = "dgvChofer";
            this.dgvChofer.ReadOnly = true;
            this.dgvChofer.Size = new System.Drawing.Size(800, 150);
            this.dgvChofer.TabIndex = 0;
            // 
            // frmChofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvChofer);
            this.Name = "frmChofer";
            this.Text = "frmChofer";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChofer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChofer;
    }
}