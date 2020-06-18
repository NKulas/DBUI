namespace DBUI.Interface
{
    partial class SearchForm
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
            this.gbxSearch = new DBUI.CustomControls.FlowGroupbox();
            this.btnSearch = new DBUI.CustomControls.DbuiButton();
            this.btnReset = new DBUI.CustomControls.DbuiButton();
            this.gbxConnection = new System.Windows.Forms.GroupBox();
            this.btnManageConnection = new DBUI.CustomControls.DbuiButton();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblConnectedTo = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.gbxConnection.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Location = new System.Drawing.Point(309, 20);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(308, 418);
            this.gbxSearch.TabIndex = 1;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(648, 174);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(648, 218);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gbxConnection
            // 
            this.gbxConnection.Controls.Add(this.btnManageConnection);
            this.gbxConnection.Controls.Add(this.lblTable);
            this.gbxConnection.Controls.Add(this.lblConnectedTo);
            this.gbxConnection.Location = new System.Drawing.Point(13, 20);
            this.gbxConnection.Name = "gbxConnection";
            this.gbxConnection.Size = new System.Drawing.Size(261, 181);
            this.gbxConnection.TabIndex = 0;
            this.gbxConnection.TabStop = false;
            this.gbxConnection.Text = "Connection";
            // 
            // btnManageConnection
            // 
            this.btnManageConnection.Location = new System.Drawing.Point(41, 117);
            this.btnManageConnection.Name = "btnManageConnection";
            this.btnManageConnection.Size = new System.Drawing.Size(165, 37);
            this.btnManageConnection.TabIndex = 2;
            this.btnManageConnection.Text = "Manage Connection";
            this.btnManageConnection.UseVisualStyleBackColor = true;
            this.btnManageConnection.Click += new System.EventHandler(this.btnManageConnection_Click);
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(7, 72);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(113, 20);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Not connected";
            // 
            // lblConnectedTo
            // 
            this.lblConnectedTo.AutoSize = true;
            this.lblConnectedTo.Location = new System.Drawing.Point(7, 38);
            this.lblConnectedTo.Name = "lblConnectedTo";
            this.lblConnectedTo.Size = new System.Drawing.Size(109, 20);
            this.lblConnectedTo.TabIndex = 0;
            this.lblConnectedTo.Text = "Connected to:";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(9, 398);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(171, 20);
            this.lblCreatedBy.TabIndex = 4;
            this.lblCreatedBy.Text = "Created by Noah Kulas";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(9, 418);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(102, 20);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version 1.1.0";
            // 
            // SearchForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.gbxConnection);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbxSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.gbxConnection.ResumeLayout(false);
            this.gbxConnection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.FlowGroupbox gbxSearch;
        private CustomControls.DbuiButton btnSearch;
        private CustomControls.DbuiButton btnReset;
        private System.Windows.Forms.GroupBox gbxConnection;
        private CustomControls.DbuiButton btnManageConnection;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblConnectedTo;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblVersion;
    }
}