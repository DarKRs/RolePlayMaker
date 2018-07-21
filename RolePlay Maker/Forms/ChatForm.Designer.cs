namespace RolePlay_Maker
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            this.nameData = new System.Windows.Forms.Label();
            this.messageData = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.ListBox();
            this.chatBox = new System.Windows.Forms.RichTextBox();
            this.nicknameData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.enterChat = new System.Windows.Forms.Button();
            this.userMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // nameData
            // 
            this.nameData.AutoSize = true;
            this.nameData.Location = new System.Drawing.Point(-88, -32);
            this.nameData.Name = "nameData";
            this.nameData.Size = new System.Drawing.Size(35, 13);
            this.nameData.TabIndex = 18;
            this.nameData.Text = "label4";
            // 
            // messageData
            // 
            this.messageData.Enabled = false;
            this.messageData.Location = new System.Drawing.Point(15, 351);
            this.messageData.Name = "messageData";
            this.messageData.Size = new System.Drawing.Size(376, 20);
            this.messageData.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Список пользователей: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-121, -20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Чат: ";
            // 
            // userList
            // 
            this.userList.Enabled = false;
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(397, 54);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(156, 316);
            this.userList.TabIndex = 14;
            // 
            // chatBox
            // 
            this.chatBox.Enabled = false;
            this.chatBox.Location = new System.Drawing.Point(15, 54);
            this.chatBox.Name = "chatBox";
            this.chatBox.ReadOnly = true;
            this.chatBox.Size = new System.Drawing.Size(376, 291);
            this.chatBox.TabIndex = 13;
            this.chatBox.Text = "";
            // 
            // nicknameData
            // 
            this.nicknameData.Enabled = false;
            this.nicknameData.Location = new System.Drawing.Point(238, 6);
            this.nicknameData.Name = "nicknameData";
            this.nicknameData.Size = new System.Drawing.Size(206, 20);
            this.nicknameData.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Для подключении к чату введите свой ник: ";
            // 
            // enterChat
            // 
            this.enterChat.Enabled = false;
            this.enterChat.Location = new System.Drawing.Point(446, 5);
            this.enterChat.Name = "enterChat";
            this.enterChat.Size = new System.Drawing.Size(107, 23);
            this.enterChat.TabIndex = 10;
            this.enterChat.Text = "Подключится";
            this.enterChat.UseVisualStyleBackColor = true;
            this.enterChat.Click += new System.EventHandler(this.enterChat_Click);
            // 
            // userMenu
            // 
            this.userMenu.Name = "userMenu";
            this.userMenu.Size = new System.Drawing.Size(153, 26);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 401);
            this.Controls.Add(this.nameData);
            this.Controls.Add(this.messageData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.nicknameData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enterChat);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameData;
        private System.Windows.Forms.TextBox messageData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.RichTextBox chatBox;
        private System.Windows.Forms.TextBox nicknameData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterChat;
        private System.Windows.Forms.ContextMenuStrip userMenu;
    }
}