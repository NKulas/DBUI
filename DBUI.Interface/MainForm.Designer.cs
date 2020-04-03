namespace DBUI.Interface
{
    partial class MainForm
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
            this.NoahLabel = new System.Windows.Forms.Label();
            this.DatabasePanel = new System.Windows.Forms.GroupBox();
            this.DatabaseConnectButton = new DBUI.CustomControls.DbuiButton();
            this.SchemaTextbox = new System.Windows.Forms.ComboBox();
            this.SchemaLabel = new System.Windows.Forms.Label();
            this.TableTextbox = new System.Windows.Forms.ComboBox();
            this.DatabaseTextbox = new System.Windows.Forms.ComboBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerTextbox = new System.Windows.Forms.TextBox();
            this.AuthenticationCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ServerPanel = new System.Windows.Forms.GroupBox();
            this.ServerConnectionButton = new DBUI.CustomControls.DbuiButton();
            this.ExitButton = new DBUI.CustomControls.DbuiButton();
            this.ResetButton = new DBUI.CustomControls.DbuiButton();
            this.SearchButton = new DBUI.CustomControls.DbuiButton();
            this.SearchPanel = new DBUI.CustomControls.FlowGroupbox();
            this.ClearButton = new DBUI.CustomControls.DbuiButton();
            this.DatabasePanel.SuspendLayout();
            this.ServerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoahLabel
            // 
            this.NoahLabel.AutoSize = true;
            this.NoahLabel.Location = new System.Drawing.Point(12, 577);
            this.NoahLabel.Name = "NoahLabel";
            this.NoahLabel.Size = new System.Drawing.Size(171, 20);
            this.NoahLabel.TabIndex = 7;
            this.NoahLabel.Text = "Created by Noah Kulas";
            // 
            // DatabasePanel
            // 
            this.DatabasePanel.Controls.Add(this.DatabaseConnectButton);
            this.DatabasePanel.Controls.Add(this.SchemaTextbox);
            this.DatabasePanel.Controls.Add(this.SchemaLabel);
            this.DatabasePanel.Controls.Add(this.TableTextbox);
            this.DatabasePanel.Controls.Add(this.DatabaseTextbox);
            this.DatabasePanel.Controls.Add(this.TableLabel);
            this.DatabasePanel.Controls.Add(this.DatabaseLabel);
            this.DatabasePanel.Location = new System.Drawing.Point(19, 306);
            this.DatabasePanel.Name = "DatabasePanel";
            this.DatabasePanel.Size = new System.Drawing.Size(365, 239);
            this.DatabasePanel.TabIndex = 1;
            this.DatabasePanel.TabStop = false;
            this.DatabasePanel.Text = "Database";
            // 
            // DatabaseConnectButton
            // 
            this.DatabaseConnectButton.Location = new System.Drawing.Point(23, 192);
            this.DatabaseConnectButton.Name = "DatabaseConnectButton";
            this.DatabaseConnectButton.Size = new System.Drawing.Size(156, 32);
            this.DatabaseConnectButton.TabIndex = 6;
            this.DatabaseConnectButton.Text = "Connect database";
            this.DatabaseConnectButton.UseVisualStyleBackColor = true;
            this.DatabaseConnectButton.Click += new System.EventHandler(this.DatabaseConnectButton_Click);
            // 
            // SchemaTextbox
            // 
            this.SchemaTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchemaTextbox.FormattingEnabled = true;
            this.SchemaTextbox.Location = new System.Drawing.Point(152, 99);
            this.SchemaTextbox.Name = "SchemaTextbox";
            this.SchemaTextbox.Size = new System.Drawing.Size(192, 28);
            this.SchemaTextbox.TabIndex = 3;
            this.SchemaTextbox.DropDown += new System.EventHandler(this.SchemaTextbox_DropDown);
            // 
            // SchemaLabel
            // 
            this.SchemaLabel.AutoSize = true;
            this.SchemaLabel.Location = new System.Drawing.Point(6, 102);
            this.SchemaLabel.Name = "SchemaLabel";
            this.SchemaLabel.Size = new System.Drawing.Size(72, 20);
            this.SchemaLabel.TabIndex = 2;
            this.SchemaLabel.Text = "Schema:";
            // 
            // TableTextbox
            // 
            this.TableTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableTextbox.FormattingEnabled = true;
            this.TableTextbox.Location = new System.Drawing.Point(152, 148);
            this.TableTextbox.Name = "TableTextbox";
            this.TableTextbox.Size = new System.Drawing.Size(192, 28);
            this.TableTextbox.TabIndex = 5;
            this.TableTextbox.DropDown += new System.EventHandler(this.TableTextbox_DropDown);
            // 
            // DatabaseTextbox
            // 
            this.DatabaseTextbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DatabaseTextbox.FormattingEnabled = true;
            this.DatabaseTextbox.Location = new System.Drawing.Point(152, 46);
            this.DatabaseTextbox.Name = "DatabaseTextbox";
            this.DatabaseTextbox.Size = new System.Drawing.Size(192, 28);
            this.DatabaseTextbox.TabIndex = 1;
            this.DatabaseTextbox.DropDown += new System.EventHandler(this.DatabaseTextbox_DropDown);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(6, 151);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(52, 20);
            this.TableLabel.TabIndex = 4;
            this.TableLabel.Text = "Table:";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(6, 49);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(83, 20);
            this.DatabaseLabel.TabIndex = 0;
            this.DatabaseLabel.Text = "Database:";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(7, 39);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(59, 20);
            this.ServerLabel.TabIndex = 0;
            this.ServerLabel.Text = "Server:";
            // 
            // ServerTextbox
            // 
            this.ServerTextbox.Location = new System.Drawing.Point(152, 39);
            this.ServerTextbox.Name = "ServerTextbox";
            this.ServerTextbox.Size = new System.Drawing.Size(192, 26);
            this.ServerTextbox.TabIndex = 1;
            // 
            // AuthenticationCheckbox
            // 
            this.AuthenticationCheckbox.AutoSize = true;
            this.AuthenticationCheckbox.Checked = true;
            this.AuthenticationCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AuthenticationCheckbox.Location = new System.Drawing.Point(10, 91);
            this.AuthenticationCheckbox.Name = "AuthenticationCheckbox";
            this.AuthenticationCheckbox.Size = new System.Drawing.Size(199, 24);
            this.AuthenticationCheckbox.TabIndex = 2;
            this.AuthenticationCheckbox.Text = "Windows Authentication";
            this.AuthenticationCheckbox.UseVisualStyleBackColor = true;
            this.AuthenticationCheckbox.CheckedChanged += new System.EventHandler(this.AuthenticationCheckbox_CheckedChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(7, 186);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 141);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 3;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Enabled = false;
            this.PasswordTextbox.Location = new System.Drawing.Point(152, 186);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(192, 26);
            this.PasswordTextbox.TabIndex = 6;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Enabled = false;
            this.UsernameTextbox.Location = new System.Drawing.Point(152, 138);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(192, 26);
            this.UsernameTextbox.TabIndex = 4;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(758, 577);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(102, 20);
            this.VersionLabel.TabIndex = 8;
            this.VersionLabel.Text = "Version 1.0.0";
            // 
            // ServerPanel
            // 
            this.ServerPanel.Controls.Add(this.ServerConnectionButton);
            this.ServerPanel.Controls.Add(this.AuthenticationCheckbox);
            this.ServerPanel.Controls.Add(this.UsernameLabel);
            this.ServerPanel.Controls.Add(this.UsernameTextbox);
            this.ServerPanel.Controls.Add(this.PasswordLabel);
            this.ServerPanel.Controls.Add(this.PasswordTextbox);
            this.ServerPanel.Controls.Add(this.ServerLabel);
            this.ServerPanel.Controls.Add(this.ServerTextbox);
            this.ServerPanel.Location = new System.Drawing.Point(19, 23);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(365, 277);
            this.ServerPanel.TabIndex = 0;
            this.ServerPanel.TabStop = false;
            this.ServerPanel.Text = "Server";
            // 
            // ServerConnectionButton
            // 
            this.ServerConnectionButton.Location = new System.Drawing.Point(23, 227);
            this.ServerConnectionButton.Name = "ServerConnectionButton";
            this.ServerConnectionButton.Size = new System.Drawing.Size(130, 32);
            this.ServerConnectionButton.TabIndex = 7;
            this.ServerConnectionButton.Text = "Connect server";
            this.ServerConnectionButton.UseVisualStyleBackColor = true;
            this.ServerConnectionButton.Click += new System.EventHandler(this.ServerConnectionButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(737, 330);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 48);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(737, 242);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(109, 48);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(737, 150);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 48);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(406, 23);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(304, 522);
            this.SearchPanel.TabIndex = 2;
            this.SearchPanel.TabStop = false;
            this.SearchPanel.Text = "Search";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(341, 561);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(115, 33);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear all";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 606);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ServerPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.DatabasePanel);
            this.Controls.Add(this.NoahLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Base User Interface";
            this.DatabasePanel.ResumeLayout(false);
            this.DatabasePanel.PerformLayout();
            this.ServerPanel.ResumeLayout(false);
            this.ServerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoahLabel;
        private System.Windows.Forms.GroupBox DatabasePanel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox ServerTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.CheckBox AuthenticationCheckbox;
        private System.Windows.Forms.Label VersionLabel;
        private CustomControls.DbuiButton SearchButton;
        private CustomControls.DbuiButton ResetButton;
        private CustomControls.DbuiButton ExitButton;
        private System.Windows.Forms.ComboBox TableTextbox;
        private System.Windows.Forms.ComboBox DatabaseTextbox;
        private System.Windows.Forms.GroupBox ServerPanel;
        private System.Windows.Forms.ComboBox SchemaTextbox;
        private System.Windows.Forms.Label SchemaLabel;
        private CustomControls.FlowGroupbox SearchPanel;
        private CustomControls.DbuiButton DatabaseConnectButton;
        private CustomControls.DbuiButton ServerConnectionButton;
        private CustomControls.DbuiButton ClearButton;
    }
}

