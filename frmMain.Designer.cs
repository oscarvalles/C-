namespace File_Merge
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
            this.txtSelectedFiles = new System.Windows.Forms.TextBox();
            this.btnSelectFiles = new System.Windows.Forms.Button();
            this.txtOutputName = new System.Windows.Forms.TextBox();
            this.btnMerge = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSaveFileTo = new System.Windows.Forms.Button();
            this.ckRmNonPrintAscii = new System.Windows.Forms.CheckBox();
            this.ckReplaceFieldSep = new System.Windows.Forms.CheckBox();
            this.txtFieldSep = new System.Windows.Forms.TextBox();
            this.btnCountRecords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSelectedFiles
            // 
            this.txtSelectedFiles.BackColor = System.Drawing.SystemColors.Window;
            this.txtSelectedFiles.Location = new System.Drawing.Point(108, 25);
            this.txtSelectedFiles.Multiline = true;
            this.txtSelectedFiles.Name = "txtSelectedFiles";
            this.txtSelectedFiles.ReadOnly = true;
            this.txtSelectedFiles.Size = new System.Drawing.Size(210, 58);
            this.txtSelectedFiles.TabIndex = 0;
            this.txtSelectedFiles.TabStop = false;
            this.txtSelectedFiles.WordWrap = false;
            // 
            // btnSelectFiles
            // 
            this.btnSelectFiles.Location = new System.Drawing.Point(12, 25);
            this.btnSelectFiles.Name = "btnSelectFiles";
            this.btnSelectFiles.Size = new System.Drawing.Size(82, 23);
            this.btnSelectFiles.TabIndex = 0;
            this.btnSelectFiles.Text = "Select Files";
            this.btnSelectFiles.UseVisualStyleBackColor = true;
            this.btnSelectFiles.Click += new System.EventHandler(this.btnSelectFiles_Click);
            // 
            // txtOutputName
            // 
            this.txtOutputName.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutputName.Location = new System.Drawing.Point(108, 106);
            this.txtOutputName.Name = "txtOutputName";
            this.txtOutputName.ReadOnly = true;
            this.txtOutputName.Size = new System.Drawing.Size(210, 20);
            this.txtOutputName.TabIndex = 0;
            this.txtOutputName.TabStop = false;
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(108, 231);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(87, 23);
            this.btnMerge.TabIndex = 5;
            this.btnMerge.Text = "Merge Files";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 268);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // btnSaveFileTo
            // 
            this.btnSaveFileTo.Location = new System.Drawing.Point(12, 106);
            this.btnSaveFileTo.Name = "btnSaveFileTo";
            this.btnSaveFileTo.Size = new System.Drawing.Size(82, 23);
            this.btnSaveFileTo.TabIndex = 1;
            this.btnSaveFileTo.Text = "Output File";
            this.btnSaveFileTo.UseVisualStyleBackColor = true;
            this.btnSaveFileTo.Click += new System.EventHandler(this.btnSaveFileTo_Click);
            // 
            // ckRmNonPrintAscii
            // 
            this.ckRmNonPrintAscii.AutoSize = true;
            this.ckRmNonPrintAscii.Location = new System.Drawing.Point(108, 147);
            this.ckRmNonPrintAscii.Name = "ckRmNonPrintAscii";
            this.ckRmNonPrintAscii.Size = new System.Drawing.Size(187, 17);
            this.ckRmNonPrintAscii.TabIndex = 2;
            this.ckRmNonPrintAscii.Text = "Remove Non Printable Characters";
            this.ckRmNonPrintAscii.UseVisualStyleBackColor = true;
            this.ckRmNonPrintAscii.CheckedChanged += new System.EventHandler(this.ckRmNonPrintAscii_CheckedChanged);
            // 
            // ckReplaceFieldSep
            // 
            this.ckReplaceFieldSep.AutoSize = true;
            this.ckReplaceFieldSep.Location = new System.Drawing.Point(108, 180);
            this.ckReplaceFieldSep.Name = "ckReplaceFieldSep";
            this.ckReplaceFieldSep.Size = new System.Drawing.Size(150, 17);
            this.ckReplaceFieldSep.TabIndex = 3;
            this.ckReplaceFieldSep.Text = "Replace Unicode FS with:";
            this.ckReplaceFieldSep.UseVisualStyleBackColor = true;
            this.ckReplaceFieldSep.CheckedChanged += new System.EventHandler(this.ckReplaceFieldSep_CheckedChanged);
            // 
            // txtFieldSep
            // 
            this.txtFieldSep.Location = new System.Drawing.Point(264, 177);
            this.txtFieldSep.MaxLength = 1;
            this.txtFieldSep.Name = "txtFieldSep";
            this.txtFieldSep.Size = new System.Drawing.Size(23, 20);
            this.txtFieldSep.TabIndex = 4;
            this.txtFieldSep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCountRecords
            // 
            this.btnCountRecords.Location = new System.Drawing.Point(226, 231);
            this.btnCountRecords.Name = "btnCountRecords";
            this.btnCountRecords.Size = new System.Drawing.Size(92, 23);
            this.btnCountRecords.TabIndex = 7;
            this.btnCountRecords.Text = "Count Records";
            this.btnCountRecords.UseVisualStyleBackColor = true;
            this.btnCountRecords.Click += new System.EventHandler(this.btnCountRecords_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 305);
            this.Controls.Add(this.btnCountRecords);
            this.Controls.Add(this.txtFieldSep);
            this.Controls.Add(this.ckReplaceFieldSep);
            this.Controls.Add(this.ckRmNonPrintAscii);
            this.Controls.Add(this.btnSaveFileTo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.txtOutputName);
            this.Controls.Add(this.btnSelectFiles);
            this.Controls.Add(this.txtSelectedFiles);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Merge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectedFiles;
        private System.Windows.Forms.Button btnSelectFiles;
        private System.Windows.Forms.TextBox txtOutputName;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSaveFileTo;
        private System.Windows.Forms.CheckBox ckRmNonPrintAscii;
        private System.Windows.Forms.CheckBox ckReplaceFieldSep;
        private System.Windows.Forms.TextBox txtFieldSep;
        private System.Windows.Forms.Button btnCountRecords;
    }
}

