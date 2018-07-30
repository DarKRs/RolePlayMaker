namespace RolePlay_Maker.Forms.Information
{
    partial class TraitInfo
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
            this.TraitTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.AdvantageText = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.DisadvantageText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Преимущество";
            // 
            // TraitTree
            // 
            this.TraitTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TraitTree.Location = new System.Drawing.Point(12, 12);
            this.TraitTree.Name = "TraitTree";
            this.TraitTree.Size = new System.Drawing.Size(208, 277);
            this.TraitTree.TabIndex = 27;
            this.TraitTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TraitTree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Имя";
            // 
            // AdvantageText
            // 
            this.AdvantageText.Location = new System.Drawing.Point(227, 46);
            this.AdvantageText.Name = "AdvantageText";
            this.AdvantageText.ReadOnly = true;
            this.AdvantageText.Size = new System.Drawing.Size(375, 113);
            this.AdvantageText.TabIndex = 25;
            this.AdvantageText.Text = "";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(259, 9);
            this.NameText.Name = "NameText";
            this.NameText.ReadOnly = true;
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 24;
            // 
            // DisadvantageText
            // 
            this.DisadvantageText.Location = new System.Drawing.Point(227, 176);
            this.DisadvantageText.Name = "DisadvantageText";
            this.DisadvantageText.ReadOnly = true;
            this.DisadvantageText.Size = new System.Drawing.Size(375, 113);
            this.DisadvantageText.TabIndex = 29;
            this.DisadvantageText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Недостаток";
            // 
            // TraitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DisadvantageText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TraitTree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdvantageText);
            this.Controls.Add(this.NameText);
            this.Name = "TraitInfo";
            this.Text = "TraitInfo";
            this.Load += new System.EventHandler(this.TraitInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView TraitTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox AdvantageText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.RichTextBox DisadvantageText;
        private System.Windows.Forms.Label label3;
    }
}