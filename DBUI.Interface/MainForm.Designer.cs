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
            this.SearchPanel = new DBUI.Interface.FlowGroupbox();
            this.ExitButton = new DBUI.Interface.AppButton();
            this.ResetSearchButton = new DBUI.Interface.AppButton();
            this.ConnectButton = new DBUI.Interface.AppButton();
            this.ClearConnectionButton = new DBUI.Interface.AppButton();
            this.SearchButton = new DBUI.Interface.AppButton();
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
            this.NoahLabel.TabIndex = 6;
            this.NoahLabel.Text = "Created by Noah Kulas";
            // 
            // DatabasePanel
            // 
            this.DatabasePanel.Controls.Add(this.SchemaTextbox);
            this.DatabasePanel.Controls.Add(this.SchemaLabel);
            this.DatabasePanel.Controls.Add(this.TableTextbox);
            this.DatabasePanel.Controls.Add(this.DatabaseTextbox);
            this.DatabasePanel.Controls.Add(this.TableLabel);
            this.DatabasePanel.Controls.Add(this.DatabaseLabel);
            this.DatabasePanel.Location = new System.Drawing.Point(19, 280);
            this.DatabasePanel.Name = "DatabasePanel";
            this.DatabasePanel.Size = new System.Drawing.Size(365, 199);
            this.DatabasePanel.TabIndex = 0;
            this.DatabasePanel.TabStop = false;
            this.DatabasePanel.Text = "Database";
            // 
            // SchemaTextbox
            // 
            this.SchemaTextbox.FormattingEnabled = true;
            this.SchemaTextbox.Location = new System.Drawing.Point(152, 99);
            this.SchemaTextbox.Name = "SchemaTextbox";
            this.SchemaTextbox.Size = new System.Drawing.Size(192, 28);
            this.SchemaTextbox.TabIndex = 16;
            this.SchemaTextbox.DropDown += new System.EventHandler(this.SchemaTextbox_DropDown);
            // 
            // SchemaLabel
            // 
            this.SchemaLabel.AutoSize = true;
            this.SchemaLabel.Location = new System.Drawing.Point(6, 102);
            this.SchemaLabel.Name = "SchemaLabel";
            this.SchemaLabel.Size = new System.Drawing.Size(72, 20);
            this.SchemaLabel.TabIndex = 15;
            this.SchemaLabel.Text = "Schema:";
            // 
            // TableTextbox
            // 
            this.TableTextbox.FormattingEnabled = true;
            this.TableTextbox.Location = new System.Drawing.Point(152, 148);
            this.TableTextbox.Name = "TableTextbox";
            this.TableTextbox.Size = new System.Drawing.Size(192, 28);
            this.TableTextbox.TabIndex = 14;
            this.TableTextbox.DropDown += new System.EventHandler(this.TableTextbox_DropDown);
            // 
            // DatabaseTextbox
            // 
            this.DatabaseTextbox.FormattingEnabled = true;
            this.DatabaseTextbox.Location = new System.Drawing.Point(152, 46);
            this.DatabaseTextbox.Name = "DatabaseTextbox";
            this.DatabaseTextbox.Size = new System.Drawing.Size(192, 28);
            this.DatabaseTextbox.TabIndex = 13;
            this.DatabaseTextbox.DropDown += new System.EventHandler(this.DatabaseTextbox_DropDown);
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(6, 151);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(52, 20);
            this.TableLabel.TabIndex = 5;
            this.TableLabel.Text = "Table:";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(6, 49);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(83, 20);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "Database:";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(19, 39);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(59, 20);
            this.ServerLabel.TabIndex = 1;
            this.ServerLabel.Text = "Server:";
            // 
            // ServerTextbox
            // 
            this.ServerTextbox.Location = new System.Drawing.Point(132, 39);
            this.ServerTextbox.Name = "ServerTextbox";
            this.ServerTextbox.Size = new System.Drawing.Size(192, 26);
            this.ServerTextbox.TabIndex = 0;
            // 
            // AuthenticationCheckbox
            // 
            this.AuthenticationCheckbox.AutoSize = true;
            this.AuthenticationCheckbox.Checked = true;
            this.AuthenticationCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AuthenticationCheckbox.Location = new System.Drawing.Point(23, 91);
            this.AuthenticationCheckbox.Name = "AuthenticationCheckbox";
            this.AuthenticationCheckbox.Size = new System.Drawing.Size(199, 24);
            this.AuthenticationCheckbox.TabIndex = 6;
            this.AuthenticationCheckbox.Text = "Windows Authentication";
            this.AuthenticationCheckbox.UseVisualStyleBackColor = true;
            this.AuthenticationCheckbox.CheckedChanged += new System.EventHandler(this.AuthenticationCheckbox_CheckedChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(19, 186);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 10;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(19, 141);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Enabled = false;
            this.PasswordTextbox.Location = new System.Drawing.Point(152, 186);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(192, 26);
            this.PasswordTextbox.TabIndex = 9;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Enabled = false;
            this.UsernameTextbox.Location = new System.Drawing.Point(152, 138);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(192, 26);
            this.UsernameTextbox.TabIndex = 7;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(758, 577);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(102, 20);
            this.VersionLabel.TabIndex = 7;
            this.VersionLabel.Text = "Version 0.4.0";
            // 
            // ServerPanel
            // 
            this.ServerPanel.Controls.Add(this.AuthenticationCheckbox);
            this.ServerPanel.Controls.Add(this.UsernameLabel);
            this.ServerPanel.Controls.Add(this.UsernameTextbox);
            this.ServerPanel.Controls.Add(this.PasswordLabel);
            this.ServerPanel.Controls.Add(this.PasswordTextbox);
            this.ServerPanel.Controls.Add(this.ServerLabel);
            this.ServerPanel.Controls.Add(this.ServerTextbox);
            this.ServerPanel.Location = new System.Drawing.Point(19, 23);
            this.ServerPanel.Name = "ServerPanel";
            this.ServerPanel.Size = new System.Drawing.Size(365, 242);
            this.ServerPanel.TabIndex = 13;
            this.ServerPanel.TabStop = false;
            this.ServerPanel.Text = "Server";
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(412, 23);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(304, 522);
            this.SearchPanel.Spacing = 5;
            this.SearchPanel.TabIndex = 14;
            this.SearchPanel.TabStop = false;
            this.SearchPanel.Text = "Search";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(737, 330);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(109, 48);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ResetSearchButton
            // 
            this.ResetSearchButton.Location = new System.Drawing.Point(737, 242);
            this.ResetSearchButton.Name = "ResetSearchButton";
            this.ResetSearchButton.Size = new System.Drawing.Size(109, 48);
            this.ResetSearchButton.TabIndex = 9;
            this.ResetSearchButton.Text = "Reset";
            this.ResetSearchButton.UseVisualStyleBackColor = true;
            this.ResetSearchButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(71, 501);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(112, 44);
            this.ConnectButton.TabIndex = 11;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // ClearConnectionButton
            // 
            this.ClearConnectionButton.Location = new System.Drawing.Point(217, 501);
            this.ClearConnectionButton.Name = "ClearConnectionButton";
            this.ClearConnectionButton.Size = new System.Drawing.Size(112, 44);
            this.ClearConnectionButton.TabIndex = 12;
            this.ClearConnectionButton.Text = "Clear";
            this.ClearConnectionButton.UseVisualStyleBackColor = true;
            this.ClearConnectionButton.Click += new System.EventHandler(this.ClearConnectionButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(737, 150);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(109, 48);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 606);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.ServerPanel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ResetSearchButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.ClearConnectionButton);
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
        private AppButton ClearConnectionButton;
        private AppButton ConnectButton;
        private AppButton SearchButton;
        private AppButton ResetSearchButton;
        private AppButton ExitButton;
        private System.Windows.Forms.ComboBox TableTextbox;
        private System.Windows.Forms.ComboBox DatabaseTextbox;
        private System.Windows.Forms.GroupBox ServerPanel;
        private FlowGroupbox SearchPanel;
        private System.Windows.Forms.ComboBox SchemaTextbox;
        private System.Windows.Forms.Label SchemaLabel;
    }
}

