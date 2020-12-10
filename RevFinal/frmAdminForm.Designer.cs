namespace Design_Document_Mock_Up
{
    partial class frmAdminForm
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
            this.dgv_donorTable = new System.Windows.Forms.DataGridView();
            this.grp_Worker = new System.Windows.Forms.GroupBox();
            this.dgv_workerTable = new System.Windows.Forms.DataGridView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_reportPrint = new System.Windows.Forms.Button();
            this.prnt_Report = new System.Drawing.Printing.PrintDocument();
            this.btn_DeleteDonor = new System.Windows.Forms.Button();
            this.btn_DeleteWorker = new System.Windows.Forms.Button();
            this.btn_createWorker = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.grp_donorDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donorTable)).BeginInit();
            this.grp_Worker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createAcc
            // 
            this.btn_createAcc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAcc.Location = new System.Drawing.Point(12, 444);
            this.btn_createAcc.Name = "btn_createAcc";
            this.btn_createAcc.Size = new System.Drawing.Size(161, 81);
            this.btn_createAcc.TabIndex = 2;
            this.btn_createAcc.Text = "Create Admin";
            this.btn_createAcc.UseVisualStyleBackColor = false;
            this.btn_createAcc.Click += new System.EventHandler(this.btn_createAcc_Click);
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendEmail.Location = new System.Drawing.Point(179, 523);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(147, 73);
            this.btn_sendEmail.TabIndex = 4;
            this.btn_sendEmail.Text = "Send Email";
            this.btn_sendEmail.UseVisualStyleBackColor = false;
            this.btn_sendEmail.Click += new System.EventHandler(this.btn_sendEmail_Click);
            // 
            // grp_donorDB
            // 
            this.grp_donorDB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_donorDB.Controls.Add(this.dgv_donorTable);
            this.grp_donorDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_donorDB.Location = new System.Drawing.Point(12, 12);
            this.grp_donorDB.Name = "grp_donorDB";
            this.grp_donorDB.Size = new System.Drawing.Size(487, 426);
            this.grp_donorDB.TabIndex = 0;
            this.grp_donorDB.TabStop = false;
            this.grp_donorDB.Text = "Donor Table";
            // 
            // dgv_donorTable
            // 
            this.dgv_donorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donorTable.Location = new System.Drawing.Point(7, 26);
            this.dgv_donorTable.Name = "dgv_donorTable";
            this.dgv_donorTable.Size = new System.Drawing.Size(474, 394);
            this.dgv_donorTable.TabIndex = 0;
            this.dgv_donorTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_donorTable_CellClick);
            // 
            // grp_Worker
            // 
            this.grp_Worker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Worker.Controls.Add(this.dgv_workerTable);
            this.grp_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Worker.Location = new System.Drawing.Point(505, 12);
            this.grp_Worker.Name = "grp_Worker";
            this.grp_Worker.Size = new System.Drawing.Size(480, 426);
            this.grp_Worker.TabIndex = 1;
            this.grp_Worker.TabStop = false;
            this.grp_Worker.Text = "Worker Table";
            // 
            // dgv_workerTable
            // 
            this.dgv_workerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_workerTable.Location = new System.Drawing.Point(6, 25);
            this.dgv_workerTable.Name = "dgv_workerTable";
            this.dgv_workerTable.Size = new System.Drawing.Size(467, 394);
            this.dgv_workerTable.TabIndex = 0;
            this.dgv_workerTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_workerTable_CellClick);
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(830, 444);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(149, 152);
            this.btn_Return.TabIndex = 7;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_reportPrint
            // 
            this.btn_reportPrint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reportPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportPrint.Location = new System.Drawing.Point(179, 444);
            this.btn_reportPrint.Name = "btn_reportPrint";
            this.btn_reportPrint.Size = new System.Drawing.Size(147, 81);
            this.btn_reportPrint.TabIndex = 3;
            this.btn_reportPrint.Text = "Print Report";
            this.btn_reportPrint.UseVisualStyleBackColor = false;
            this.btn_reportPrint.Click += new System.EventHandler(this.btn_reportPrint_Click);
            // 
            // btn_DeleteDonor
            // 
            this.btn_DeleteDonor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_DeleteDonor.Enabled = false;
            this.btn_DeleteDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteDonor.Location = new System.Drawing.Point(331, 444);
            this.btn_DeleteDonor.Name = "btn_DeleteDonor";
            this.btn_DeleteDonor.Size = new System.Drawing.Size(162, 152);
            this.btn_DeleteDonor.TabIndex = 5;
            this.btn_DeleteDonor.Text = "Delete Donor";
            this.btn_DeleteDonor.UseVisualStyleBackColor = false;
            this.btn_DeleteDonor.Click += new System.EventHandler(this.btn_DeleteDonor_Click);
            // 
            // btn_DeleteWorker
            // 
            this.btn_DeleteWorker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_DeleteWorker.Enabled = false;
            this.btn_DeleteWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteWorker.Location = new System.Drawing.Point(511, 444);
            this.btn_DeleteWorker.Name = "btn_DeleteWorker";
            this.btn_DeleteWorker.Size = new System.Drawing.Size(151, 152);
            this.btn_DeleteWorker.TabIndex = 6;
            this.btn_DeleteWorker.Text = "Delete Worker";
            this.btn_DeleteWorker.UseVisualStyleBackColor = false;
            this.btn_DeleteWorker.Click += new System.EventHandler(this.btn_DeleteWorker_Click);
            // 
            // btn_createWorker
            // 
            this.btn_createWorker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_createWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createWorker.Location = new System.Drawing.Point(12, 523);
            this.btn_createWorker.Name = "btn_createWorker";
            this.btn_createWorker.Size = new System.Drawing.Size(161, 73);
            this.btn_createWorker.TabIndex = 8;
            this.btn_createWorker.Text = "Create Worker";
            this.btn_createWorker.UseVisualStyleBackColor = false;
            this.btn_createWorker.Click += new System.EventHandler(this.btn_createWorker_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(668, 444);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(156, 152);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh Tables";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frmAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(997, 602);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_createWorker);
            this.Controls.Add(this.btn_DeleteWorker);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.btn_DeleteDonor);
            this.Controls.Add(this.btn_reportPrint);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.grp_Worker);
            this.Controls.Add(this.btn_createAcc);
            this.Controls.Add(this.grp_donorDB);
            this.Name = "frmAdminForm";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.grp_donorDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donorTable)).EndInit();
            this.grp_Worker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createAcc;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.GroupBox grp_donorDB;
        private System.Windows.Forms.GroupBox grp_Worker;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_reportPrint;
        private System.Windows.Forms.DataGridView dgv_donorTable;
        private System.Windows.Forms.DataGridView dgv_workerTable;
        private System.Drawing.Printing.PrintDocument prnt_Report;
        private System.Windows.Forms.Button btn_DeleteDonor;
        private System.Windows.Forms.Button btn_DeleteWorker;
        private System.Windows.Forms.Button btn_createWorker;
        private System.Windows.Forms.Button btn_Refresh;
    }
}