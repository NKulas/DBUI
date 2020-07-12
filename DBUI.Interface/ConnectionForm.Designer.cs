namespace DBUI.Interface
{
    partial class ConnectionForm
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
            this.gbxServer = new System.Windows.Forms.GroupBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbxDatabase = new System.Windows.Forms.GroupBox();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.cbxSchema = new System.Windows.Forms.ComboBox();
            this.cbxDatabase = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblSchema = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.prbProgress = new System.Windows.Forms.ProgressBar();
            this.gbxAuthentication = new System.Windows.Forms.GroupBox();
            this.btnConnect = new DBUI.CustomControls.DbuiButton();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnViewObject = new DBUI.CustomControls.DbuiButton();
            this.gbxServer.SuspendLayout();
            this.gbxDatabase.SuspendLayout();
            this.gbxAuthentication.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxServer
            // 
            this.gbxServer.Controls.Add(this.lblServer);
            this.gbxServer.Controls.Add(this.txtServer);
            this.gbxServer.Location = new System.Drawing.Point(15, 13);
            this.gbxServer.Name = "gbxServer";
            this.gbxServer.Size = new System.Drawing.Size(362, 82);
            this.gbxServer.TabIndex = 0;
            this.gbxServer.TabStop = false;
            this.gbxServer.Text = "Server";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(6, 40);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(120, 20);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server address:";
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(132, 40);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(224, 26);
            this.txtServer.TabIndex = 1;
            this.txtServer.Tag = "Server";
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            this.txtServer.Leave += new System.EventHandler(this.edit_Complete);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(104, 117);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(104, 76);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 26);
            this.txtUsername.TabIndex = 2;
            // 
            // chkWindowsAuthentication
            // 
            this.chkWindowsAuthentication.AutoSize = true;
            this.chkWindowsAuthentication.Checked = true;
            this.chkWindowsAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWindowsAuthentication.Location = new System.Drawing.Point(6, 34);
            this.chkWindowsAuthentication.Name = "chkWindowsAuthentication";
            this.chkWindowsAuthentication.Size = new System.Drawing.Size(194, 24);
            this.chkWindowsAuthentication.TabIndex = 0;
            this.chkWindowsAuthentication.Text = "Windows Authenication";
            this.chkWindowsAuthentication.UseVisualStyleBackColor = true;
            this.chkWindowsAuthentication.CheckedChanged += new System.EventHandler(this.chkWindowsAuthentication_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(6, 76);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 117);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // gbxDatabase
            // 
            this.gbxDatabase.Controls.Add(this.cbxTable);
            this.gbxDatabase.Controls.Add(this.cbxSchema);
            this.gbxDatabase.Controls.Add(this.cbxDatabase);
            this.gbxDatabase.Controls.Add(this.lblTable);
            this.gbxDatabase.Controls.Add(this.lblSchema);
            this.gbxDatabase.Controls.Add(this.lblDatabase);
            this.gbxDatabase.Location = new System.Drawing.Point(15, 304);
            this.gbxDatabase.Name = "gbxDatabase";
            this.gbxDatabase.Size = new System.Drawing.Size(362, 196);
            this.gbxDatabase.TabIndex = 2;
            this.gbxDatabase.TabStop = false;
            this.gbxDatabase.Text = "Database";
            // 
            // cbxTable
            // 
            this.cbxTable.DisplayMember = "InternalName";
            this.cbxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.Location = new System.Drawing.Point(104, 147);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(200, 28);
            this.cbxTable.TabIndex = 5;
            this.cbxTable.Tag = "Table";
            this.cbxTable.ValueMember = "InternalName";
            this.cbxTable.DropDown += new System.EventHandler(this.cbx_DropDown);
            this.cbxTable.SelectedValueChanged += new System.EventHandler(this.edit_Complete);
            // 
            // cbxSchema
            // 
            this.cbxSchema.DisplayMember = "InternalName";
            this.cbxSchema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSchema.FormattingEnabled = true;
            this.cbxSchema.Location = new System.Drawing.Point(104, 90);
            this.cbxSchema.Name = "cbxSchema";
            this.cbxSchema.Size = new System.Drawing.Size(200, 28);
            this.cbxSchema.TabIndex = 3;
            this.cbxSchema.Tag = "Schema";
            this.cbxSchema.ValueMember = "InternalName";
            this.cbxSchema.DropDown += new System.EventHandler(this.cbx_DropDown);
            this.cbxSchema.SelectedValueChanged += new System.EventHandler(this.edit_Complete);
            // 
            // cbxDatabase
            // 
            this.cbxDatabase.DisplayMember = "InternalName";
            this.cbxDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDatabase.FormattingEnabled = true;
            this.cbxDatabase.Location = new System.Drawing.Point(104, 35);
            this.cbxDatabase.Name = "cbxDatabase";
            this.cbxDatabase.Size = new System.Drawing.Size(200, 28);
            this.cbxDatabase.TabIndex = 1;
            this.cbxDatabase.Tag = "Database";
            this.cbxDatabase.ValueMember = "InternalName";
            this.cbxDatabase.DropDown += new System.EventHandler(this.cbx_DropDown);
            this.cbxDatabase.SelectedValueChanged += new System.EventHandler(this.edit_Complete);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(7, 147);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(52, 20);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Table:";
            // 
            // lblSchema
            // 
            this.lblSchema.AutoSize = true;
            this.lblSchema.Location = new System.Drawing.Point(7, 90);
            this.lblSchema.Name = "lblSchema";
            this.lblSchema.Size = new System.Drawing.Size(72, 20);
            this.lblSchema.TabIndex = 2;
            this.lblSchema.Text = "Schema:";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(7, 35);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(83, 20);
            this.lblDatabase.TabIndex = 0;
            this.lblDatabase.Text = "Database:";
            // 
            // prbProgress
            // 
            this.prbProgress.Location = new System.Drawing.Point(15, 288);
            this.prbProgress.Name = "prbProgress";
            this.prbProgress.Size = new System.Drawing.Size(362, 10);
            this.prbProgress.Step = 1;
            this.prbProgress.TabIndex = 6;
            // 
            // gbxAuthentication
            // 
            this.gbxAuthentication.Controls.Add(this.txtPassword);
            this.gbxAuthentication.Controls.Add(this.chkWindowsAuthentication);
            this.gbxAuthentication.Controls.Add(this.lblPassword);
            this.gbxAuthentication.Controls.Add(this.lblUsername);
            this.gbxAuthentication.Controls.Add(this.txtUsername);
            this.gbxAuthentication.Location = new System.Drawing.Point(15, 101);
            this.gbxAuthentication.Name = "gbxAuthentication";
            this.gbxAuthentication.Size = new System.Drawing.Size(363, 173);
            this.gbxAuthentication.TabIndex = 1;
            this.gbxAuthentication.TabStop = false;
            this.gbxAuthentication.Text = "Authentication";
            this.gbxAuthentication.Leave += new System.EventHandler(this.gbxAuthentication_Leave);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(68, 506);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(103, 31);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblVersion.Location = new System.Drawing.Point(5, 545);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(133, 13);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "Noah Kulas - Version 1.2.1";
            // 
            // btnViewObject
            // 
            this.btnViewObject.Location = new System.Drawing.Point(203, 506);
            this.btnViewObject.Name = "btnViewObject";
            this.btnViewObject.Size = new System.Drawing.Size(103, 31);
            this.btnViewObject.TabIndex = 8;
            this.btnViewObject.Text = "View object";
            this.btnViewObject.UseVisualStyleBackColor = true;
            this.btnViewObject.Click += new System.EventHandler(this.btnViewObject_Click);
            // 
            // ConnectionForm
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(392, 565);
            this.Controls.Add(this.btnViewObject);
            this.Controls.Add(this.prbProgress);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.gbxAuthentication);
            this.Controls.Add(this.gbxDatabase);
            this.Controls.Add(this.gbxServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "ConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to database";
            this.gbxServer.ResumeLayout(false);
            this.gbxServer.PerformLayout();
            this.gbxDatabase.ResumeLayout(false);
            this.gbxDatabase.PerformLayout();
            this.gbxAuthentication.ResumeLayout(false);
            this.gbxAuthentication.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxServer;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkWindowsAuthentication;
        private System.Windows.Forms.GroupBox gbxDatabase;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblSchema;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.GroupBox gbxAuthentication;
        private CustomControls.DbuiButton btnConnect;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.ComboBox cbxSchema;
        private System.Windows.Forms.ComboBox cbxDatabase;
        private System.Windows.Forms.ProgressBar prbProgress;
        private System.Windows.Forms.Label lblVersion;
        private CustomControls.DbuiButton btnViewObject;
    }
}