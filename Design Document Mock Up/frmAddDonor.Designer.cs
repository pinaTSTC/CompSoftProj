﻿namespace Design_Document_Mock_Up
{
    partial class frmAddDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddDonor));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_PhoneNum = new System.Windows.Forms.Label();
            this.lbl_streetNum = new System.Windows.Forms.Label();
            this.lbl_Emailadd = new System.Windows.Forms.Label();
            this.lbl_streetName = new System.Windows.Forms.Label();
            this.btn_addDonor = new System.Windows.Forms.Button();
            this.txt_phNum = new System.Windows.Forms.TextBox();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.txt_streetName = new System.Windows.Forms.TextBox();
            this.txt_emailAdd = new System.Windows.Forms.TextBox();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.grp_streetInfo = new System.Windows.Forms.GroupBox();
            this.radb_Male = new System.Windows.Forms.RadioButton();
            this.radb_Female = new System.Windows.Forms.RadioButton();
            this.grp_Gender = new System.Windows.Forms.GroupBox();
            this.grp_bloodGrp = new System.Windows.Forms.GroupBox();
            this.radb_O = new System.Windows.Forms.RadioButton();
            this.radb_TypeAB = new System.Windows.Forms.RadioButton();
            this.radb_TypeB = new System.Windows.Forms.RadioButton();
            this.radb_TypeA = new System.Windows.Forms.RadioButton();
            this.grp_Disclaimer = new System.Windows.Forms.GroupBox();
            this.txt_Disclaimer = new System.Windows.Forms.TextBox();
            this.chk_Agreement = new System.Windows.Forms.CheckBox();
            this.grp_logCred = new System.Windows.Forms.GroupBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_confirmPass = new System.Windows.Forms.Label();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.grp_streetInfo.SuspendLayout();
            this.grp_Gender.SuspendLayout();
            this.grp_bloodGrp.SuspendLayout();
            this.grp_Disclaimer.SuspendLayout();
            this.grp_logCred.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(13, 13);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(60, 20);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name:";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(288, 13);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(51, 20);
            this.lbl_Age.TabIndex = 1;
            this.lbl_Age.Text = "Age: ";
            // 
            // lbl_PhoneNum
            // 
            this.lbl_PhoneNum.AutoSize = true;
            this.lbl_PhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNum.Location = new System.Drawing.Point(391, 15);
            this.lbl_PhoneNum.Name = "lbl_PhoneNum";
            this.lbl_PhoneNum.Size = new System.Drawing.Size(132, 20);
            this.lbl_PhoneNum.TabIndex = 2;
            this.lbl_PhoneNum.Text = "Phone Number:";
            // 
            // lbl_streetNum
            // 
            this.lbl_streetNum.AutoSize = true;
            this.lbl_streetNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_streetNum.Location = new System.Drawing.Point(25, 33);
            this.lbl_streetNum.Name = "lbl_streetNum";
            this.lbl_streetNum.Size = new System.Drawing.Size(76, 20);
            this.lbl_streetNum.TabIndex = 3;
            this.lbl_streetNum.Text = "Number:";
            // 
            // lbl_Emailadd
            // 
            this.lbl_Emailadd.AutoSize = true;
            this.lbl_Emailadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emailadd.Location = new System.Drawing.Point(19, 165);
            this.lbl_Emailadd.Name = "lbl_Emailadd";
            this.lbl_Emailadd.Size = new System.Drawing.Size(134, 20);
            this.lbl_Emailadd.TabIndex = 5;
            this.lbl_Emailadd.Text = "Email Address: ";
            // 
            // lbl_streetName
            // 
            this.lbl_streetName.AutoSize = true;
            this.lbl_streetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_streetName.Location = new System.Drawing.Point(25, 79);
            this.lbl_streetName.Name = "lbl_streetName";
            this.lbl_streetName.Size = new System.Drawing.Size(115, 20);
            this.lbl_streetName.TabIndex = 4;
            this.lbl_streetName.Text = "Street Name:";
            // 
            // btn_addDonor
            // 
            this.btn_addDonor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDonor.Location = new System.Drawing.Point(6, 197);
            this.btn_addDonor.Name = "btn_addDonor";
            this.btn_addDonor.Size = new System.Drawing.Size(356, 67);
            this.btn_addDonor.TabIndex = 8;
            this.btn_addDonor.Text = "Submit Info";
            this.btn_addDonor.UseVisualStyleBackColor = false;
            // 
            // txt_phNum
            // 
            this.txt_phNum.Location = new System.Drawing.Point(529, 15);
            this.txt_phNum.Name = "txt_phNum";
            this.txt_phNum.Size = new System.Drawing.Size(131, 20);
            this.txt_phNum.TabIndex = 9;
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(163, 33);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(56, 26);
            this.txt_Num.TabIndex = 10;
            // 
            // txt_streetName
            // 
            this.txt_streetName.Location = new System.Drawing.Point(163, 79);
            this.txt_streetName.Name = "txt_streetName";
            this.txt_streetName.Size = new System.Drawing.Size(186, 26);
            this.txt_streetName.TabIndex = 11;
            // 
            // txt_emailAdd
            // 
            this.txt_emailAdd.Location = new System.Drawing.Point(158, 162);
            this.txt_emailAdd.Name = "txt_emailAdd";
            this.txt_emailAdd.Size = new System.Drawing.Size(186, 26);
            this.txt_emailAdd.TabIndex = 12;
            // 
            // txt_Age
            // 
            this.txt_Age.Location = new System.Drawing.Point(339, 15);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(40, 20);
            this.txt_Age.TabIndex = 13;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(79, 15);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(203, 20);
            this.txt_Name.TabIndex = 14;
            // 
            // grp_streetInfo
            // 
            this.grp_streetInfo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_streetInfo.Controls.Add(this.lbl_streetNum);
            this.grp_streetInfo.Controls.Add(this.lbl_streetName);
            this.grp_streetInfo.Controls.Add(this.txt_Num);
            this.grp_streetInfo.Controls.Add(this.txt_streetName);
            this.grp_streetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_streetInfo.Location = new System.Drawing.Point(17, 51);
            this.grp_streetInfo.Name = "grp_streetInfo";
            this.grp_streetInfo.Size = new System.Drawing.Size(368, 129);
            this.grp_streetInfo.TabIndex = 15;
            this.grp_streetInfo.TabStop = false;
            this.grp_streetInfo.Text = "Street";
            // 
            // radb_Male
            // 
            this.radb_Male.AutoSize = true;
            this.radb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Male.Location = new System.Drawing.Point(92, 25);
            this.radb_Male.Name = "radb_Male";
            this.radb_Male.Size = new System.Drawing.Size(61, 24);
            this.radb_Male.TabIndex = 16;
            this.radb_Male.TabStop = true;
            this.radb_Male.Text = "&Male";
            this.radb_Male.UseVisualStyleBackColor = true;
            // 
            // radb_Female
            // 
            this.radb_Female.AutoSize = true;
            this.radb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_Female.Location = new System.Drawing.Point(207, 25);
            this.radb_Female.Name = "radb_Female";
            this.radb_Female.Size = new System.Drawing.Size(80, 24);
            this.radb_Female.TabIndex = 17;
            this.radb_Female.TabStop = true;
            this.radb_Female.Text = "&Female";
            this.radb_Female.UseVisualStyleBackColor = true;
            // 
            // grp_Gender
            // 
            this.grp_Gender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Gender.Controls.Add(this.radb_Male);
            this.grp_Gender.Controls.Add(this.radb_Female);
            this.grp_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Gender.Location = new System.Drawing.Point(395, 51);
            this.grp_Gender.Name = "grp_Gender";
            this.grp_Gender.Size = new System.Drawing.Size(368, 59);
            this.grp_Gender.TabIndex = 18;
            this.grp_Gender.TabStop = false;
            this.grp_Gender.Text = "Select Gender";
            // 
            // grp_bloodGrp
            // 
            this.grp_bloodGrp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_bloodGrp.Controls.Add(this.radb_O);
            this.grp_bloodGrp.Controls.Add(this.radb_TypeAB);
            this.grp_bloodGrp.Controls.Add(this.radb_TypeB);
            this.grp_bloodGrp.Controls.Add(this.radb_TypeA);
            this.grp_bloodGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_bloodGrp.Location = new System.Drawing.Point(395, 115);
            this.grp_bloodGrp.Name = "grp_bloodGrp";
            this.grp_bloodGrp.Size = new System.Drawing.Size(368, 65);
            this.grp_bloodGrp.TabIndex = 19;
            this.grp_bloodGrp.TabStop = false;
            this.grp_bloodGrp.Text = "Blood Group:";
            // 
            // radb_O
            // 
            this.radb_O.AutoSize = true;
            this.radb_O.Location = new System.Drawing.Point(305, 25);
            this.radb_O.Name = "radb_O";
            this.radb_O.Size = new System.Drawing.Size(40, 24);
            this.radb_O.TabIndex = 3;
            this.radb_O.TabStop = true;
            this.radb_O.Text = "O";
            this.radb_O.UseVisualStyleBackColor = true;
            // 
            // radb_TypeAB
            // 
            this.radb_TypeAB.AutoSize = true;
            this.radb_TypeAB.Location = new System.Drawing.Point(237, 25);
            this.radb_TypeAB.Name = "radb_TypeAB";
            this.radb_TypeAB.Size = new System.Drawing.Size(51, 24);
            this.radb_TypeAB.TabIndex = 2;
            this.radb_TypeAB.TabStop = true;
            this.radb_TypeAB.Text = "AB";
            this.radb_TypeAB.UseVisualStyleBackColor = true;
            // 
            // radb_TypeB
            // 
            this.radb_TypeB.AutoSize = true;
            this.radb_TypeB.Location = new System.Drawing.Point(180, 25);
            this.radb_TypeB.Name = "radb_TypeB";
            this.radb_TypeB.Size = new System.Drawing.Size(39, 24);
            this.radb_TypeB.TabIndex = 1;
            this.radb_TypeB.TabStop = true;
            this.radb_TypeB.Text = "B";
            this.radb_TypeB.UseVisualStyleBackColor = true;
            // 
            // radb_TypeA
            // 
            this.radb_TypeA.AutoSize = true;
            this.radb_TypeA.Location = new System.Drawing.Point(123, 25);
            this.radb_TypeA.Name = "radb_TypeA";
            this.radb_TypeA.Size = new System.Drawing.Size(39, 24);
            this.radb_TypeA.TabIndex = 0;
            this.radb_TypeA.TabStop = true;
            this.radb_TypeA.Text = "A";
            this.radb_TypeA.UseVisualStyleBackColor = true;
            // 
            // grp_Disclaimer
            // 
            this.grp_Disclaimer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Disclaimer.Controls.Add(this.chk_Agreement);
            this.grp_Disclaimer.Controls.Add(this.txt_Disclaimer);
            this.grp_Disclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Disclaimer.Location = new System.Drawing.Point(17, 187);
            this.grp_Disclaimer.Name = "grp_Disclaimer";
            this.grp_Disclaimer.Size = new System.Drawing.Size(368, 264);
            this.grp_Disclaimer.TabIndex = 20;
            this.grp_Disclaimer.TabStop = false;
            this.grp_Disclaimer.Text = "Privacy Policy";
            // 
            // txt_Disclaimer
            // 
            this.txt_Disclaimer.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Disclaimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Disclaimer.Location = new System.Drawing.Point(19, 25);
            this.txt_Disclaimer.Multiline = true;
            this.txt_Disclaimer.Name = "txt_Disclaimer";
            this.txt_Disclaimer.Size = new System.Drawing.Size(330, 191);
            this.txt_Disclaimer.TabIndex = 0;
            this.txt_Disclaimer.Text = resources.GetString("txt_Disclaimer.Text");
            // 
            // chk_Agreement
            // 
            this.chk_Agreement.AutoSize = true;
            this.chk_Agreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Agreement.Location = new System.Drawing.Point(62, 222);
            this.chk_Agreement.Name = "chk_Agreement";
            this.chk_Agreement.Size = new System.Drawing.Size(238, 21);
            this.chk_Agreement.TabIndex = 1;
            this.chk_Agreement.Text = "I agree to the following terms";
            this.chk_Agreement.UseVisualStyleBackColor = true;
            // 
            // grp_logCred
            // 
            this.grp_logCred.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_logCred.Controls.Add(this.textBox1);
            this.grp_logCred.Controls.Add(this.txt_passWord);
            this.grp_logCred.Controls.Add(this.txt_userName);
            this.grp_logCred.Controls.Add(this.lbl_confirmPass);
            this.grp_logCred.Controls.Add(this.lbl_password);
            this.grp_logCred.Controls.Add(this.lbl_userName);
            this.grp_logCred.Controls.Add(this.lbl_Emailadd);
            this.grp_logCred.Controls.Add(this.txt_emailAdd);
            this.grp_logCred.Controls.Add(this.btn_addDonor);
            this.grp_logCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_logCred.Location = new System.Drawing.Point(395, 187);
            this.grp_logCred.Name = "grp_logCred";
            this.grp_logCred.Size = new System.Drawing.Size(368, 270);
            this.grp_logCred.TabIndex = 21;
            this.grp_logCred.TabStop = false;
            this.grp_logCred.Text = "Login Credentials";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(20, 43);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(96, 20);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(20, 85);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 20);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_confirmPass
            // 
            this.lbl_confirmPass.AutoSize = true;
            this.lbl_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPass.Location = new System.Drawing.Point(25, 116);
            this.lbl_confirmPass.Name = "lbl_confirmPass";
            this.lbl_confirmPass.Size = new System.Drawing.Size(91, 40);
            this.lbl_confirmPass.TabIndex = 2;
            this.lbl_confirmPass.Text = "Confirm\r\nPassword:";
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(159, 43);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(185, 26);
            this.txt_userName.TabIndex = 13;
            // 
            // txt_passWord
            // 
            this.txt_passWord.Location = new System.Drawing.Point(123, 85);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(197, 26);
            this.txt_passWord.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 15;
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(688, 13);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(75, 25);
            this.btn_Return.TabIndex = 22;
            this.btn_Return.Text = "Cancel";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // frmAddDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 469);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.grp_logCred);
            this.Controls.Add(this.grp_Disclaimer);
            this.Controls.Add(this.grp_bloodGrp);
            this.Controls.Add(this.grp_Gender);
            this.Controls.Add(this.grp_streetInfo);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Age);
            this.Controls.Add(this.txt_phNum);
            this.Controls.Add(this.lbl_PhoneNum);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_Name);
            this.Name = "frmAddDonor";
            this.Text = "Donor Form";
            this.grp_streetInfo.ResumeLayout(false);
            this.grp_streetInfo.PerformLayout();
            this.grp_Gender.ResumeLayout(false);
            this.grp_Gender.PerformLayout();
            this.grp_bloodGrp.ResumeLayout(false);
            this.grp_bloodGrp.PerformLayout();
            this.grp_Disclaimer.ResumeLayout(false);
            this.grp_Disclaimer.PerformLayout();
            this.grp_logCred.ResumeLayout(false);
            this.grp_logCred.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_PhoneNum;
        private System.Windows.Forms.Label lbl_streetNum;
        private System.Windows.Forms.Label lbl_Emailadd;
        private System.Windows.Forms.Label lbl_streetName;
        private System.Windows.Forms.Button btn_addDonor;
        private System.Windows.Forms.TextBox txt_phNum;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.TextBox txt_streetName;
        private System.Windows.Forms.TextBox txt_emailAdd;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox grp_streetInfo;
        private System.Windows.Forms.RadioButton radb_Male;
        private System.Windows.Forms.RadioButton radb_Female;
        private System.Windows.Forms.GroupBox grp_Gender;
        private System.Windows.Forms.GroupBox grp_bloodGrp;
        private System.Windows.Forms.RadioButton radb_O;
        private System.Windows.Forms.RadioButton radb_TypeAB;
        private System.Windows.Forms.RadioButton radb_TypeB;
        private System.Windows.Forms.RadioButton radb_TypeA;
        private System.Windows.Forms.GroupBox grp_Disclaimer;
        private System.Windows.Forms.CheckBox chk_Agreement;
        private System.Windows.Forms.TextBox txt_Disclaimer;
        private System.Windows.Forms.GroupBox grp_logCred;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_confirmPass;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_Return;
    }
}