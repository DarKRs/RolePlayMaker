namespace RolePlay_Maker
{
    partial class Logs
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
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogText
            // 
            this.LogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogText.Location = new System.Drawing.Point(12, 12);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(505, 194);
            this.LogText.TabIndex = 11;
            this.LogText.Text = "";
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Clear.Location = new System.Drawing.Point(114, 217);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(301, 23);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 252);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.LogText);
            this.Name = "Logs";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.Logs_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.Button Clear;
    }
}