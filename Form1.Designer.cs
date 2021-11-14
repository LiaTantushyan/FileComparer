
namespace FileComparer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xmlPath = new System.Windows.Forms.TextBox();
            this.excelPath = new System.Windows.Forms.TextBox();
            this.xmlUploadButton = new System.Windows.Forms.Button();
            this.excelUploadButton = new System.Windows.Forms.Button();
            this.validateButton = new System.Windows.Forms.Button();
            this.uniqueColumns = new System.Windows.Forms.ComboBox();
            this.compareAndDownloadDownload = new System.Windows.Forms.Button();
            this.infoText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // xmlPath
            // 
            this.xmlPath.Location = new System.Drawing.Point(60, 24);
            this.xmlPath.Name = "xmlPath";
            this.xmlPath.Size = new System.Drawing.Size(356, 27);
            this.xmlPath.TabIndex = 0;
            // 
            // excelPath
            // 
            this.excelPath.Location = new System.Drawing.Point(60, 88);
            this.excelPath.Name = "excelPath";
            this.excelPath.Size = new System.Drawing.Size(356, 27);
            this.excelPath.TabIndex = 1;
            // 
            // xmlUploadButton
            // 
            this.xmlUploadButton.Location = new System.Drawing.Point(435, 22);
            this.xmlUploadButton.Name = "xmlUploadButton";
            this.xmlUploadButton.Size = new System.Drawing.Size(151, 29);
            this.xmlUploadButton.TabIndex = 2;
            this.xmlUploadButton.Text = "Choose XML";
            this.xmlUploadButton.UseVisualStyleBackColor = true;
            this.xmlUploadButton.Click += new System.EventHandler(this.xmlUploadButtonClick);
            // 
            // excelUploadButton
            // 
            this.excelUploadButton.Location = new System.Drawing.Point(435, 86);
            this.excelUploadButton.Name = "excelUploadButton";
            this.excelUploadButton.Size = new System.Drawing.Size(151, 29);
            this.excelUploadButton.TabIndex = 3;
            this.excelUploadButton.Text = "Choose Excel";
            this.excelUploadButton.UseVisualStyleBackColor = true;
            this.excelUploadButton.Click += new System.EventHandler(this.excelUploadButtonClick);
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(179, 135);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(253, 53);
            this.validateButton.TabIndex = 4;
            this.validateButton.Text = "Check If Files Are Valid";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // uniqueColumns
            // 
            this.uniqueColumns.AllowDrop = true;
            this.uniqueColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uniqueColumns.Enabled = false;
            this.uniqueColumns.FormattingEnabled = true;
            this.uniqueColumns.Items.AddRange(new object[] {
            "PassportNum",
            "SocCardNum",
            "LAccountNumber",
            "ANTPType"});
            this.uniqueColumns.Location = new System.Drawing.Point(237, 108);
            this.uniqueColumns.Name = "uniqueColumns";
            this.uniqueColumns.Size = new System.Drawing.Size(151, 28);
            this.uniqueColumns.TabIndex = 5;
            this.uniqueColumns.Visible = false;
            // 
            // compareAndDownloadDownload
            // 
            this.compareAndDownloadDownload.Enabled = false;
            this.compareAndDownloadDownload.Location = new System.Drawing.Point(269, 154);
            this.compareAndDownloadDownload.Name = "compareAndDownloadDownload";
            this.compareAndDownloadDownload.Size = new System.Drawing.Size(94, 29);
            this.compareAndDownloadDownload.TabIndex = 6;
            this.compareAndDownloadDownload.Text = "Compare and Download";
            this.compareAndDownloadDownload.UseVisualStyleBackColor = true;
            this.compareAndDownloadDownload.Visible = false;
            this.compareAndDownloadDownload.Click += new System.EventHandler(this.compareAndDownloadDownload_Click);
            // 
            // infoText
            // 
            this.infoText.AutoSize = true;
            this.infoText.Enabled = false;
            this.infoText.Location = new System.Drawing.Point(179, 85);
            this.infoText.Name = "infoText";
            this.infoText.Size = new System.Drawing.Size(279, 20);
            this.infoText.TabIndex = 7;
            this.infoText.Text = "Select column from dropdown list below";
            this.infoText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 343);
            this.Controls.Add(this.infoText);
            this.Controls.Add(this.compareAndDownloadDownload);
            this.Controls.Add(this.uniqueColumns);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.excelUploadButton);
            this.Controls.Add(this.xmlUploadButton);
            this.Controls.Add(this.excelPath);
            this.Controls.Add(this.xmlPath);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Comparer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xmlPath;
        private System.Windows.Forms.TextBox excelPath;
        private System.Windows.Forms.Button xmlUploadButton;
        private System.Windows.Forms.Button excelUploadButton;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.ComboBox uniqueColumns;
        private System.Windows.Forms.Button compareAndDownloadDownload;
        private System.Windows.Forms.Label infoText;
    }
}

