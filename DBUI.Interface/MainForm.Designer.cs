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
            this.SearchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.ConnectionPanel = new System.Windows.Forms.GroupBox();
            this.ConnectButton = new DBUI.Business.AppButton();
            this.AuthenticationCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UsernameTextbox = new System.Windows.Forms.TextBox();
            this.TableLabel = new System.Windows.Forms.Label();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.TableTextbox = new System.Windows.Forms.TextBox();
            this.DatabaseTextbox = new System.Windows.Forms.TextBox();
            this.ServerTextbox = new System.Windows.Forms.TextBox();
            this.ExitButton = new DBUI.Business.AppButton();
            this.ClearButton = new DBUI.Business.AppButton();
            this.SearchButton = new DBUI.Business.AppButton();
            this.ConnectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoahLabel
            // 
            this.NoahLabel.AutoSize = true;
            this.NoahLabel.Location = new System.Drawing.Point(12, 577);
            this.NoahLabel.Name = "NoahLabel";
            this.NoahLabel.Size = new System.Drawing.Size(171, 20);
            this.NoahLabel.TabIndex = 0;
            this.NoahLabel.Text = "Created by Noah Kulas";
            // 
            // SearchPanel
            // 
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SearchPanel.Location = new System.Drawing.Point(426, 66);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(278, 488);
            this.SearchPanel.TabIndex = 1;
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(422, 43);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(84, 20);
            this.SearchLabel.TabIndex = 2;
            this.SearchLabel.Text = "Search by:";
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Controls.Add(this.ConnectButton);
            this.ConnectionPanel.Controls.Add(this.AuthenticationCheckbox);
            this.ConnectionPanel.Controls.Add(this.PasswordLabel);
            this.ConnectionPanel.Controls.Add(this.UsernameLabel);
            this.ConnectionPanel.Controls.Add(this.PasswordTextbox);
            this.ConnectionPanel.Controls.Add(this.UsernameTextbox);
            this.ConnectionPanel.Controls.Add(this.TableLabel);
            this.ConnectionPanel.Controls.Add(this.DatabaseLabel);
            this.ConnectionPanel.Controls.Add(this.ServerLabel);
            this.ConnectionPanel.Controls.Add(this.TableTextbox);
            this.ConnectionPanel.Controls.Add(this.DatabaseTextbox);
            this.ConnectionPanel.Controls.Add(this.ServerTextbox);
            this.ConnectionPanel.Location = new System.Drawing.Point(19, 37);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(365, 517);
            this.ConnectionPanel.TabIndex = 3;
            this.ConnectionPanel.TabStop = false;
            this.ConnectionPanel.Text = "Connect";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(113, 435);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(114, 49);
            this.ConnectButton.TabIndex = 11;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // AuthenticationCheckbox
            // 
            this.AuthenticationCheckbox.AutoSize = true;
            this.AuthenticationCheckbox.Checked = true;
            this.AuthenticationCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AuthenticationCheckbox.Location = new System.Drawing.Point(10, 255);
            this.AuthenticationCheckbox.Name = "AuthenticationCheckbox";
            this.AuthenticationCheckbox.Size = new System.Drawing.Size(199, 24);
            this.AuthenticationCheckbox.TabIndex = 10;
            this.AuthenticationCheckbox.Text = "Windows Authentication";
            this.AuthenticationCheckbox.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(6, 367);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(82, 20);
            this.PasswordLabel.TabIndex = 9;
            this.PasswordLabel.Text = "Password:";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(6, 307);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 8;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(152, 361);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(192, 26);
            this.PasswordTextbox.TabIndex = 7;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.Location = new System.Drawing.Point(152, 304);
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.Size = new System.Drawing.Size(192, 26);
            this.UsernameTextbox.TabIndex = 6;
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(6, 179);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(52, 20);
            this.TableLabel.TabIndex = 5;
            this.TableLabel.Text = "Table:";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(6, 122);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(83, 20);
            this.DatabaseLabel.TabIndex = 4;
            this.DatabaseLabel.Text = "Database:";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(6, 68);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(59, 20);
            this.ServerLabel.TabIndex = 3;
            this.ServerLabel.Text = "Server:";
            // 
            // TableTextbox
            // 
            this.TableTextbox.Location = new System.Drawing.Point(152, 173);
            this.TableTextbox.Name = "TableTextbox";
            this.TableTextbox.Size = new System.Drawing.Size(192, 26);
            this.TableTextbox.TabIndex = 2;
            // 
            // DatabaseTextbox
            // 
            this.DatabaseTextbox.Location = new System.Drawing.Point(152, 122);
            this.DatabaseTextbox.Name = "DatabaseTextbox";
            this.DatabaseTextbox.Size = new System.Drawing.Size(192, 26);
            this.DatabaseTextbox.TabIndex = 1;
            // 
            // ServerTextbox
            // 
            this.ServerTextbox.Location = new System.Drawing.Point(152, 68);
            this.ServerTextbox.Name = "ServerTextbox";
            this.ServerTextbox.Size = new System.Drawing.Size(192, 26);
            this.ServerTextbox.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(734, 318);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(114, 49);
            this.ExitButton.TabIndex = 14;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(734, 239);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(114, 49);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(734, 159);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(114, 49);
            this.SearchButton.TabIndex = 12;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(872, 606);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ConnectionPanel);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.NoahLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "MainForm";
            this.Text = "Data Base User Interface";
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoahLabel;
        private System.Windows.Forms.FlowLayoutPanel SearchPanel;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.GroupBox ConnectionPanel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox TableTextbox;
        private System.Windows.Forms.TextBox DatabaseTextbox;
        private System.Windows.Forms.TextBox ServerTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UsernameTextbox;
        private System.Windows.Forms.CheckBox AuthenticationCheckbox;
        private Business.AppButton ConnectButton;
        private Business.AppButton SearchButton;
        private Business.AppButton ClearButton;
        private Business.AppButton ExitButton;
    }
}

