﻿namespace Design_Document_Mock_Up
{
    partial class frmWorkercs
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
            this.grp_donorDB = new System.Windows.Forms.GroupBox();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.btn_createAcc = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_printReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grp_donorDB
            // 
            this.grp_donorDB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_donorDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_donorDB.Location = new System.Drawing.Point(12, 12);
            this.grp_donorDB.Name = "grp_donorDB";
            this.grp_donorDB.Size = new System.Drawing.Size(450, 426);
            this.grp_donorDB.TabIndex = 0;
            this.grp_donorDB.TabStop = false;
            this.grp_donorDB.Text = "Donor Database";
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendEmail.Location = new System.Drawing.Point(468, 197);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(320, 118);
            this.btn_sendEmail.TabIndex = 1;
            this.btn_sendEmail.Text = "Send Email";
            this.btn_sendEmail.UseVisualStyleBackColor = false;
            // 
            // btn_createAcc
            // 
            this.btn_createAcc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAcc.Location = new System.Drawing.Point(468, 321);
            this.btn_createAcc.Name = "btn_createAcc";
            this.btn_createAcc.Size = new System.Drawing.Size(320, 117);
            this.btn_createAcc.TabIndex = 2;
            this.btn_createAcc.Text = "Create Account";
            this.btn_createAcc.UseVisualStyleBackColor = false;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(713, 12);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 58);
            this.btn_Cancel.TabIndex = 35;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_printReport
            // 
            this.btn_printReport.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_printReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printReport.Location = new System.Drawing.Point(468, 76);
            this.btn_printReport.Name = "btn_printReport";
            this.btn_printReport.Size = new System.Drawing.Size(320, 118);
            this.btn_printReport.TabIndex = 36;
            this.btn_printReport.Text = "Print Report";
            this.btn_printReport.UseVisualStyleBackColor = false;
            // 
            // frmWorkercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_printReport);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_createAcc);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.grp_donorDB);
            this.Name = "frmWorkercs";
            this.Text = "Workers Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_donorDB;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.Button btn_createAcc;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_printReport;
    }
}