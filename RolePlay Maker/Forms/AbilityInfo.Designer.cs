namespace RolePlay_Maker
{
    partial class AbilityInfo
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
            this.label2 = new System.Windows.Forms.Label();
            this.AbilityTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.RangText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReqText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Описание";
            // 
            // AbilityTree
            // 
            this.AbilityTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AbilityTree.Location = new System.Drawing.Point(12, 6);
            this.AbilityTree.Name = "AbilityTree";
            this.AbilityTree.Size = new System.Drawing.Size(208, 303);
            this.AbilityTree.TabIndex = 22;
            this.AbilityTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AbilityTree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Имя";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(229, 88);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(283, 221);
            this.DescriptionText.TabIndex = 20;
            this.DescriptionText.Text = "";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(263, 6);
            this.NameText.Name = "NameText";
            this.NameText.ReadOnly = true;
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 19;
            // 
            // RangText
            // 
            this.RangText.Location = new System.Drawing.Point(412, 6);
            this.RangText.Name = "RangText";
            this.RangText.ReadOnly = true;
            this.RangText.Size = new System.Drawing.Size(100, 20);
            this.RangText.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ранги";
            // 
            // ReqText
            // 
            this.ReqText.Location = new System.Drawing.Point(229, 49);
            this.ReqText.Name = "ReqText";
            this.ReqText.ReadOnly = true;
            this.ReqText.Size = new System.Drawing.Size(283, 20);
            this.ReqText.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Требования";
            // 
            // AbilityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReqText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RangText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AbilityTree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NameText);
            this.Name = "AbilityInfo";
            this.Text = "AbilityInfo";
            this.Load += new System.EventHandler(this.AbilityInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView AbilityTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox RangText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReqText;
        private System.Windows.Forms.Label label4;
    }
}