﻿
namespace VisualVault.ExamplesCs.Document_MetaData
{
    partial class DocumentMetaData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentMetaData));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeveloperSecret = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDeveloperKey = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.txtServerURL = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstFolderIndexFields = new System.Windows.Forms.ListBox();
            this.btnGetFolderIndexFields = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetFolders = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 492);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox11.BackColor = System.Drawing.Color.White;
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.label6);
            this.groupBox11.Controls.Add(this.txtDeveloperSecret);
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.txtDeveloperKey);
            this.groupBox11.Controls.Add(this.label8);
            this.groupBox11.Controls.Add(this.btnLogin);
            this.groupBox11.Controls.Add(this.txtPassword);
            this.groupBox11.Controls.Add(this.txtUserID);
            this.groupBox11.Controls.Add(this.txtServerURL);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.label27);
            this.groupBox11.Controls.Add(this.label29);
            this.groupBox11.Location = new System.Drawing.Point(13, 60);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(565, 346);
            this.groupBox11.TabIndex = 14;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Login to VisualVault";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(417, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Server Url example:  http://demo.visualvault.com/app/CustomerName/DatabaseName";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(7, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(552, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // txtDeveloperSecret
            // 
            this.txtDeveloperSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeveloperSecret.Location = new System.Drawing.Point(105, 179);
            this.txtDeveloperSecret.Name = "txtDeveloperSecret";
            this.txtDeveloperSecret.Size = new System.Drawing.Size(454, 20);
            this.txtDeveloperSecret.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Developer Secret:";
            // 
            // txtDeveloperKey
            // 
            this.txtDeveloperKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDeveloperKey.Location = new System.Drawing.Point(105, 153);
            this.txtDeveloperKey.Name = "txtDeveloperKey";
            this.txtDeveloperKey.Size = new System.Drawing.Size(454, 20);
            this.txtDeveloperKey.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Developer Key:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(415, 278);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLoginClick);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(105, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(454, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUserID
            // 
            this.txtUserID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserID.Location = new System.Drawing.Point(105, 79);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(454, 20);
            this.txtUserID.TabIndex = 2;
            // 
            // txtServerURL
            // 
            this.txtServerURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServerURL.Location = new System.Drawing.Point(105, 53);
            this.txtServerURL.Name = "txtServerURL";
            this.txtServerURL.Size = new System.Drawing.Size(454, 20);
            this.txtServerURL.TabIndex = 1;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 108);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 13);
            this.label26.TabIndex = 3;
            this.label26.Text = "Password:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(16, 82);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(46, 13);
            this.label27.TabIndex = 2;
            this.label27.Text = "User ID:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 56);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(57, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Server Url:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstFolderIndexFields);
            this.tabPage2.Controls.Add(this.btnGetFolderIndexFields);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnGetFolders);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Folder Index Fields";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstFolderIndexFields
            // 
            this.lstFolderIndexFields.FormattingEnabled = true;
            this.lstFolderIndexFields.Location = new System.Drawing.Point(308, 67);
            this.lstFolderIndexFields.Name = "lstFolderIndexFields";
            this.lstFolderIndexFields.Size = new System.Drawing.Size(221, 147);
            this.lstFolderIndexFields.TabIndex = 7;
            // 
            // btnGetFolderIndexFields
            // 
            this.btnGetFolderIndexFields.Location = new System.Drawing.Point(308, 37);
            this.btnGetFolderIndexFields.Name = "btnGetFolderIndexFields";
            this.btnGetFolderIndexFields.Size = new System.Drawing.Size(94, 23);
            this.btnGetFolderIndexFields.TabIndex = 6;
            this.btnGetFolderIndexFields.Text = "Get Index Fields";
            this.btnGetFolderIndexFields.UseVisualStyleBackColor = true;
            this.btnGetFolderIndexFields.Click += new System.EventHandler(this.BtnGetFolderIndexFieldsClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Display list of index fields defined for this folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select folder for new document";
            // 
            // btnGetFolders
            // 
            this.btnGetFolders.Location = new System.Drawing.Point(17, 37);
            this.btnGetFolders.Name = "btnGetFolders";
            this.btnGetFolders.Size = new System.Drawing.Size(75, 23);
            this.btnGetFolders.TabIndex = 3;
            this.btnGetFolders.Text = "Get Folders";
            this.btnGetFolders.UseVisualStyleBackColor = true;
            this.btnGetFolders.Click += new System.EventHandler(this.BtnGetFoldersClick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(14, 66);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(214, 347);
            this.treeView1.TabIndex = 2;
            // 
            // DocumentMetaData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 510);
            this.Controls.Add(this.tabControl1);
            this.Name = "DocumentMetaData";
            this.Text = "Document Meta-Data";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetFolders;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.ListBox lstFolderIndexFields;
        private System.Windows.Forms.Button btnGetFolderIndexFields;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.GroupBox groupBox11;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeveloperSecret;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDeveloperKey;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.TextBox txtServerURL;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label label29;
    }
}