namespace DBUI.Interface
{
    partial class TableForm
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
            this.DataTableView = new System.Windows.Forms.DataGridView();
            this.CloseButton = new DBUI.Business.AppButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableView
            // 
            this.DataTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTableView.Location = new System.Drawing.Point(12, 12);
            this.DataTableView.Name = "DataTableView";
            this.DataTableView.Size = new System.Drawing.Size(776, 374);
            this.DataTableView.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(712, 404);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(76, 34);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DataTableView);
            this.Name = "TableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result table";
            ((System.ComponentModel.ISupportInitialize)(this.DataTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataTableView;
        private Business.AppButton CloseButton;
    }
}