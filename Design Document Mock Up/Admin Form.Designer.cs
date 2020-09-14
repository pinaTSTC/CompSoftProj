namespace Design_Document_Mock_Up
{
    partial class Admin_Form
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
            this.btn_createAcc = new System.Windows.Forms.Button();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.grp_donorDB = new System.Windows.Forms.GroupBox();
            this.grp_Worker = new System.Windows.Forms.GroupBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createAcc
            // 
            this.btn_createAcc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAcc.Location = new System.Drawing.Point(338, 444);
            this.btn_createAcc.Name = "btn_createAcc";
            this.btn_createAcc.Size = new System.Drawing.Size(320, 152);
            this.btn_createAcc.TabIndex = 5;
            this.btn_createAcc.Text = "Create Account";
            this.btn_createAcc.UseVisualStyleBackColor = false;
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendEmail.Location = new System.Drawing.Point(12, 444);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(320, 152);
            this.btn_sendEmail.TabIndex = 4;
            this.btn_sendEmail.Text = "Send Email";
            this.btn_sendEmail.UseVisualStyleBackColor = false;
            // 
            // grp_donorDB
            // 
            this.grp_donorDB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_donorDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_donorDB.Location = new System.Drawing.Point(12, 12);
            this.grp_donorDB.Name = "grp_donorDB";
            this.grp_donorDB.Size = new System.Drawing.Size(487, 426);
            this.grp_donorDB.TabIndex = 3;
            this.grp_donorDB.TabStop = false;
            this.grp_donorDB.Text = "Donor Database";
            // 
            // grp_Worker
            // 
            this.grp_Worker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Worker.Location = new System.Drawing.Point(505, 12);
            this.grp_Worker.Name = "grp_Worker";
            this.grp_Worker.Size = new System.Drawing.Size(480, 426);
            this.grp_Worker.TabIndex = 4;
            this.grp_Worker.TabStop = false;
            this.grp_Worker.Text = "Worker Database";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(664, 444);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(320, 152);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(997, 602);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.grp_Worker);
            this.Controls.Add(this.btn_createAcc);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.grp_donorDB);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createAcc;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.GroupBox grp_donorDB;
        private System.Windows.Forms.GroupBox grp_Worker;
        private System.Windows.Forms.Button btn_Cancel;
    }
}