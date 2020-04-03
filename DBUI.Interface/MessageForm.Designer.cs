namespace DBUI.Interface
{
    partial class MessageForm
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
            this.CloseButton = new DBUI.CustomControls.DbuiButton();
            this.MessageTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(345, 288);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(87, 45);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MessageTextbox
            // 
            this.MessageTextbox.Location = new System.Drawing.Point(13, 13);
            this.MessageTextbox.Multiline = true;
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.ReadOnly = true;
            this.MessageTextbox.Size = new System.Drawing.Size(419, 269);
            this.MessageTextbox.TabIndex = 1;
            // 
            // MessageForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(444, 345);
            this.Controls.Add(this.MessageTextbox);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(Title)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.DbuiButton CloseButton;
        private System.Windows.Forms.TextBox MessageTextbox;
    }
}