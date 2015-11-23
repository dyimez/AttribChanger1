namespace AttribChanger
{
    partial class Form1
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
            this.btnOK = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblCreation = new System.Windows.Forms.Label();
            this.lblModified = new System.Windows.Forms.Label();
            this.lblAccessed = new System.Windows.Forms.Label();
            this.groupInformation = new System.Windows.Forms.GroupBox();
            this.checkBoxCreation = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxModified = new System.Windows.Forms.CheckBox();
            this.checkBoxAccessed = new System.Windows.Forms.CheckBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupInformation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(290, 178);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(6, 22);
            this.tbResults.Name = "tbResults";
            this.tbResults.ReadOnly = true;
            this.tbResults.Size = new System.Drawing.Size(292, 20);
            this.tbResults.TabIndex = 1;
            this.tbResults.ModifiedChanged += new System.EventHandler(this.tbResults_ModifiedChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(304, 19);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(28, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblCreation
            // 
            this.lblCreation.AutoSize = true;
            this.lblCreation.Location = new System.Drawing.Point(17, 54);
            this.lblCreation.Name = "lblCreation";
            this.lblCreation.Size = new System.Drawing.Size(75, 13);
            this.lblCreation.TabIndex = 3;
            this.lblCreation.Text = "Creation Date:";
            // 
            // lblModified
            // 
            this.lblModified.AutoSize = true;
            this.lblModified.Location = new System.Drawing.Point(17, 76);
            this.lblModified.Name = "lblModified";
            this.lblModified.Size = new System.Drawing.Size(76, 13);
            this.lblModified.TabIndex = 4;
            this.lblModified.Text = "Modified Date:";
            // 
            // lblAccessed
            // 
            this.lblAccessed.AutoSize = true;
            this.lblAccessed.Location = new System.Drawing.Point(17, 98);
            this.lblAccessed.Name = "lblAccessed";
            this.lblAccessed.Size = new System.Drawing.Size(83, 13);
            this.lblAccessed.TabIndex = 5;
            this.lblAccessed.Text = "Accessed Date:";
            // 
            // groupInformation
            // 
            this.groupInformation.Controls.Add(this.tbResults);
            this.groupInformation.Controls.Add(this.lblAccessed);
            this.groupInformation.Controls.Add(this.btnBrowse);
            this.groupInformation.Controls.Add(this.lblModified);
            this.groupInformation.Controls.Add(this.lblCreation);
            this.groupInformation.Location = new System.Drawing.Point(4, 2);
            this.groupInformation.Name = "groupInformation";
            this.groupInformation.Size = new System.Drawing.Size(361, 120);
            this.groupInformation.TabIndex = 6;
            this.groupInformation.TabStop = false;
            this.groupInformation.Text = "Information";
            // 
            // checkBoxCreation
            // 
            this.checkBoxCreation.AutoSize = true;
            this.checkBoxCreation.Location = new System.Drawing.Point(20, 20);
            this.checkBoxCreation.Name = "checkBoxCreation";
            this.checkBoxCreation.Size = new System.Drawing.Size(65, 17);
            this.checkBoxCreation.TabIndex = 7;
            this.checkBoxCreation.Text = "Creation";
            this.checkBoxCreation.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAccessed);
            this.groupBox2.Controls.Add(this.checkBoxModified);
            this.groupBox2.Controls.Add(this.checkBoxCreation);
            this.groupBox2.Location = new System.Drawing.Point(5, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(361, 46);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Change to Current Timestamp";
            // 
            // checkBoxModified
            // 
            this.checkBoxModified.AutoSize = true;
            this.checkBoxModified.Location = new System.Drawing.Point(136, 20);
            this.checkBoxModified.Name = "checkBoxModified";
            this.checkBoxModified.Size = new System.Drawing.Size(66, 17);
            this.checkBoxModified.TabIndex = 8;
            this.checkBoxModified.Text = "Modified";
            this.checkBoxModified.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessed
            // 
            this.checkBoxAccessed.AutoSize = true;
            this.checkBoxAccessed.Location = new System.Drawing.Point(252, 20);
            this.checkBoxAccessed.Name = "checkBoxAccessed";
            this.checkBoxAccessed.Size = new System.Drawing.Size(73, 17);
            this.checkBoxAccessed.TabIndex = 9;
            this.checkBoxAccessed.Text = "Accessed";
            this.checkBoxAccessed.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(12, 182);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 9;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 210);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupInformation);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Attrib Changer v 0.1";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.Form1_HelpButtonClicked);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupInformation.ResumeLayout(false);
            this.groupInformation.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblCreation;
        private System.Windows.Forms.Label lblModified;
        private System.Windows.Forms.Label lblAccessed;
        private System.Windows.Forms.GroupBox groupInformation;
        private System.Windows.Forms.CheckBox checkBoxCreation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAccessed;
        private System.Windows.Forms.CheckBox checkBoxModified;
        private System.Windows.Forms.Label lblStatus;
    }
}

