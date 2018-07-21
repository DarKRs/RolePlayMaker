namespace RolePlay_Maker
{
    partial class MobForm
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
            this.NameText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HpText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KBText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DamageText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.MobTree = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(151, 21);
            this.NameText.Name = "NameText";
            this.NameText.ReadOnly = true;
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // HpText
            // 
            this.HpText.Location = new System.Drawing.Point(151, 62);
            this.HpText.Name = "HpText";
            this.HpText.ReadOnly = true;
            this.HpText.Size = new System.Drawing.Size(100, 20);
            this.HpText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP";
            // 
            // KBText
            // 
            this.KBText.Location = new System.Drawing.Point(266, 21);
            this.KBText.Name = "KBText";
            this.KBText.ReadOnly = true;
            this.KBText.Size = new System.Drawing.Size(100, 20);
            this.KBText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "KB";
            // 
            // DamageText
            // 
            this.DamageText.Location = new System.Drawing.Point(266, 62);
            this.DamageText.Name = "DamageText";
            this.DamageText.ReadOnly = true;
            this.DamageText.Size = new System.Drawing.Size(100, 20);
            this.DamageText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Damage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Описание";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(148, 101);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(215, 146);
            this.DescriptionText.TabIndex = 10;
            this.DescriptionText.Text = "";
            // 
            // MobTree
            // 
            this.MobTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MobTree.Location = new System.Drawing.Point(11, 21);
            this.MobTree.Name = "MobTree";
            this.MobTree.Size = new System.Drawing.Size(131, 226);
            this.MobTree.TabIndex = 12;
            this.MobTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MobTree_AfterSelect);
            // 
            // MobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 259);
            this.Controls.Add(this.MobTree);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DamageText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KBText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HpText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameText);
            this.Name = "MobForm";
            this.Text = "MobForm";
            this.Load += new System.EventHandler(this.MobForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox HpText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KBText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DamageText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.TreeView MobTree;
    }
}