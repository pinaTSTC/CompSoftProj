﻿namespace Design_Document_Mock_Up
{
    partial class frmWorkLogin
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
            this.grp_Login = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_accCreate = new System.Windows.Forms.Button();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.btn_ID = new System.Windows.Forms.TextBox();
            this.grp_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Login
            // 
            this.grp_Login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Login.Controls.Add(this.lbl_ID);
            this.grp_Login.Controls.Add(this.btn_ID);
            this.grp_Login.Controls.Add(this.btn_Login);
            this.grp_Login.Controls.Add(this.lbl_Password);
            this.grp_Login.Controls.Add(this.txt_password);
            this.grp_Login.Controls.Add(this.txt_userName);
            this.grp_Login.Controls.Add(this.lbl_userName);
            this.grp_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Login.Location = new System.Drawing.Point(12, 51);
            this.grp_Login.Name = "grp_Login";
            this.grp_Login.Size = new System.Drawing.Size(411, 298);
            this.grp_Login.TabIndex = 4;
            this.grp_Login.TabStop = false;
            this.grp_Login.Text = "Login";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(133, 216);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(111, 32);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "&Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(23, 144);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(91, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(133, 141);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(221, 26);
            this.txt_password.TabIndex = 2;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(133, 92);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(199, 26);
            this.txt_userName.TabIndex = 1;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(23, 93);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(96, 20);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username:";
            // 
            // btn_accCreate
            // 
            this.btn_accCreate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_accCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accCreate.Location = new System.Drawing.Point(429, 85);
            this.btn_accCreate.Name = "btn_accCreate";
            this.btn_accCreate.Size = new System.Drawing.Size(359, 214);
            this.btn_accCreate.TabIndex = 3;
            this.btn_accCreate.Text = "Create Account";
            this.btn_accCreate.UseVisualStyleBackColor = false;
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(145, 355);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(111, 44);
            this.btn_Return.TabIndex = 5;
            this.btn_Return.Text = "R&eturn";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(237, 28);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(33, 20);
            this.lbl_ID.TabIndex = 6;
            this.lbl_ID.Text = "ID:";
            // 
            // btn_ID
            // 
            this.btn_ID.Location = new System.Drawing.Point(276, 25);
            this.btn_ID.Name = "btn_ID";
            this.btn_ID.Size = new System.Drawing.Size(114, 26);
            this.btn_ID.TabIndex = 5;
            // 
            // frmWorkLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_Login);
            this.Controls.Add(this.btn_accCreate);
            this.Controls.Add(this.btn_Return);
            this.Name = "frmWorkLogin";
            this.Text = "frmWorkLogin";
            this.grp_Login.ResumeLayout(false);
            this.grp_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_accCreate;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox btn_ID;
    }
}