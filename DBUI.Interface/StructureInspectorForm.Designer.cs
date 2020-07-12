namespace DBUI.Interface
{
    partial class StructureInspectorForm
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
            this.lblObjectName = new System.Windows.Forms.Label();
            this.lblFriendlyName = new System.Windows.Forms.Label();
            this.txtFriendlyName = new System.Windows.Forms.TextBox();
            this.lblObjectType = new System.Windows.Forms.Label();
            this.lblObjectTypeOutput = new System.Windows.Forms.Label();
            this.lblChildType = new System.Windows.Forms.Label();
            this.lblChildTypeOutput = new System.Windows.Forms.Label();
            this.btnClose = new DBUI.CustomControls.DbuiButton();
            this.lblChildren = new System.Windows.Forms.Label();
            this.lstChildren = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblObjectName
            // 
            this.lblObjectName.AutoSize = true;
            this.lblObjectName.Location = new System.Drawing.Point(13, 13);
            this.lblObjectName.Name = "lblObjectName";
            this.lblObjectName.Size = new System.Drawing.Size(103, 20);
            this.lblObjectName.TabIndex = 0;
            this.lblObjectName.Text = "Object name:";
            // 
            // lblFriendlyName
            // 
            this.lblFriendlyName.AutoSize = true;
            this.lblFriendlyName.Location = new System.Drawing.Point(13, 52);
            this.lblFriendlyName.Name = "lblFriendlyName";
            this.lblFriendlyName.Size = new System.Drawing.Size(112, 20);
            this.lblFriendlyName.TabIndex = 2;
            this.lblFriendlyName.Text = "Friendly name:";
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.Enabled = false;
            this.txtFriendlyName.Location = new System.Drawing.Point(135, 49);
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.Size = new System.Drawing.Size(146, 26);
            this.txtFriendlyName.TabIndex = 3;
            // 
            // lblObjectType
            // 
            this.lblObjectType.AutoSize = true;
            this.lblObjectType.Location = new System.Drawing.Point(13, 97);
            this.lblObjectType.Name = "lblObjectType";
            this.lblObjectType.Size = new System.Drawing.Size(93, 20);
            this.lblObjectType.TabIndex = 4;
            this.lblObjectType.Text = "Object type:";
            // 
            // lblObjectTypeOutput
            // 
            this.lblObjectTypeOutput.AutoSize = true;
            this.lblObjectTypeOutput.Location = new System.Drawing.Point(112, 97);
            this.lblObjectTypeOutput.Name = "lblObjectTypeOutput";
            this.lblObjectTypeOutput.Size = new System.Drawing.Size(99, 20);
            this.lblObjectTypeOutput.TabIndex = 5;
            this.lblObjectTypeOutput.Text = "(ObjectType)";
            // 
            // lblChildType
            // 
            this.lblChildType.AutoSize = true;
            this.lblChildType.Location = new System.Drawing.Point(13, 138);
            this.lblChildType.Name = "lblChildType";
            this.lblChildType.Size = new System.Drawing.Size(82, 20);
            this.lblChildType.TabIndex = 6;
            this.lblChildType.Text = "Child type:";
            // 
            // lblChildTypeOutput
            // 
            this.lblChildTypeOutput.AutoSize = true;
            this.lblChildTypeOutput.Location = new System.Drawing.Point(101, 138);
            this.lblChildTypeOutput.Name = "lblChildTypeOutput";
            this.lblChildTypeOutput.Size = new System.Drawing.Size(88, 20);
            this.lblChildTypeOutput.TabIndex = 7;
            this.lblChildTypeOutput.Text = "(ChildType)";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(84, 189);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(287, 13);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(71, 20);
            this.lblChildren.TabIndex = 9;
            this.lblChildren.Text = "Children:";
            // 
            // lstChildren
            // 
            this.lstChildren.DisplayMember = "InternalName";
            this.lstChildren.FormattingEnabled = true;
            this.lstChildren.ItemHeight = 20;
            this.lstChildren.Location = new System.Drawing.Point(291, 37);
            this.lstChildren.Name = "lstChildren";
            this.lstChildren.Size = new System.Drawing.Size(169, 184);
            this.lstChildren.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(146, 26);
            this.txtName.TabIndex = 11;
            // 
            // StructureInspectorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(481, 242);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lstChildren);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblChildTypeOutput);
            this.Controls.Add(this.lblChildType);
            this.Controls.Add(this.lblObjectTypeOutput);
            this.Controls.Add(this.lblObjectType);
            this.Controls.Add(this.txtFriendlyName);
            this.Controls.Add(this.lblFriendlyName);
            this.Controls.Add(this.lblObjectName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Name = "StructureInspectorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Structure inspector";
            this.Load += new System.EventHandler(this.StructureInspectorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjectName;
        private System.Windows.Forms.Label lblFriendlyName;
        private System.Windows.Forms.TextBox txtFriendlyName;
        private System.Windows.Forms.Label lblObjectType;
        private System.Windows.Forms.Label lblObjectTypeOutput;
        private System.Windows.Forms.Label lblChildType;
        private System.Windows.Forms.Label lblChildTypeOutput;
        private CustomControls.DbuiButton btnClose;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.ListBox lstChildren;
        private System.Windows.Forms.TextBox txtName;
    }
}