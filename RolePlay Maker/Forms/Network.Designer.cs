namespace RolePlay_Maker
{
    partial class Network
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
            this.Connect = new System.Windows.Forms.Button();
            this.CreateServer = new System.Windows.Forms.Button();
            this.IpHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(202, 284);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(135, 53);
            this.Connect.TabIndex = 0;
            this.Connect.Text = "Подключится";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // CreateServer
            // 
            this.CreateServer.Location = new System.Drawing.Point(12, 284);
            this.CreateServer.Name = "CreateServer";
            this.CreateServer.Size = new System.Drawing.Size(135, 55);
            this.CreateServer.TabIndex = 1;
            this.CreateServer.Text = "Создать сервер";
            this.CreateServer.UseVisualStyleBackColor = true;
            this.CreateServer.Click += new System.EventHandler(this.CreateServer_Click);
            // 
            // IpHost
            // 
            this.IpHost.Location = new System.Drawing.Point(12, 24);
            this.IpHost.Name = "IpHost";
            this.IpHost.Size = new System.Drawing.Size(100, 20);
            this.IpHost.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP";
            // 
            // Nick
            // 
            this.Nick.Location = new System.Drawing.Point(12, 71);
            this.Nick.Name = "Nick";
            this.Nick.Size = new System.Drawing.Size(100, 20);
            this.Nick.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ник";
            // 
            // Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 351);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nick);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IpHost);
            this.Controls.Add(this.CreateServer);
            this.Controls.Add(this.Connect);
            this.Name = "Network";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Network";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button CreateServer;
        private System.Windows.Forms.TextBox IpHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox Nick;
    }
}