namespace Design_Document_Mock_Up
{
    partial class frmMain
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
            this.grp_Worker = new System.Windows.Forms.GroupBox();
            this.btn_Donor = new System.Windows.Forms.Button();
            this.btn_Worker = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.grp_Worker.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Worker
            // 
            this.grp_Worker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Worker.Controls.Add(this.btn_Donor);
            this.grp_Worker.Controls.Add(this.btn_Worker);
            this.grp_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Worker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Worker.Location = new System.Drawing.Point(12, 114);
            this.grp_Worker.Name = "grp_Worker";
            this.grp_Worker.Size = new System.Drawing.Size(776, 324);
            this.grp_Worker.TabIndex = 0;
            this.grp_Worker.TabStop = false;
            this.grp_Worker.Text = "Login Selection";
            // 
            // btn_Donor
            // 
            this.btn_Donor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Donor.Location = new System.Drawing.Point(443, 136);
            this.btn_Donor.Name = "btn_Donor";
            this.btn_Donor.Size = new System.Drawing.Size(259, 104);
            this.btn_Donor.TabIndex = 1;
            this.btn_Donor.Text = "Donor";
            this.btn_Donor.UseVisualStyleBackColor = false;
            // 
            // btn_Worker
            // 
            this.btn_Worker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Worker.Location = new System.Drawing.Point(71, 136);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(259, 104);
            this.btn_Worker.TabIndex = 0;
            this.btn_Worker.Text = "Worker";
            this.btn_Worker.UseVisualStyleBackColor = false;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(308, 41);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(167, 37);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Welcome!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.grp_Worker);
            this.Name = "frmMain";
            this.Text = "BDMS - Mock Up";
            this.grp_Worker.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Worker;
        private System.Windows.Forms.Button btn_Donor;
        private System.Windows.Forms.Button btn_Worker;
        private System.Windows.Forms.Label lbl_Welcome;
    }
}

