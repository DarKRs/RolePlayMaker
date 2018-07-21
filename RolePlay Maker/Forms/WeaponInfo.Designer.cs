namespace RolePlay_Maker
{
    partial class WeaponInfo
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
            this.label4 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.DamageText = new System.Windows.Forms.TextBox();
            this.WeaponTree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmmoText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Описание";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Средняя стоимость";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(330, 95);
            this.PriceText.Name = "PriceText";
            this.PriceText.ReadOnly = true;
            this.PriceText.Size = new System.Drawing.Size(100, 20);
            this.PriceText.TabIndex = 15;
            // 
            // DamageText
            // 
            this.DamageText.Location = new System.Drawing.Point(409, 19);
            this.DamageText.Name = "DamageText";
            this.DamageText.ReadOnly = true;
            this.DamageText.Size = new System.Drawing.Size(100, 20);
            this.DamageText.TabIndex = 14;
            // 
            // WeaponTree
            // 
            this.WeaponTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeaponTree.Location = new System.Drawing.Point(12, 12);
            this.WeaponTree.Name = "WeaponTree";
            this.WeaponTree.Size = new System.Drawing.Size(187, 310);
            this.WeaponTree.TabIndex = 13;
            this.WeaponTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ArmorTree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(205, 123);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ReadOnly = true;
            this.DescriptionText.Size = new System.Drawing.Size(304, 199);
            this.DescriptionText.TabIndex = 11;
            this.DescriptionText.Text = "";
            this.DescriptionText.TextChanged += new System.EventHandler(this.DescriptionText_TextChanged);
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(240, 19);
            this.NameText.Name = "NameText";
            this.NameText.ReadOnly = true;
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 10;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Урон";
            // 
            // AmmoText
            // 
            this.AmmoText.Location = new System.Drawing.Point(208, 69);
            this.AmmoText.Name = "AmmoText";
            this.AmmoText.ReadOnly = true;
            this.AmmoText.Size = new System.Drawing.Size(302, 20);
            this.AmmoText.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Тип патронов";
            // 
            // WeaponInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 334);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmmoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.DamageText);
            this.Controls.Add(this.WeaponTree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NameText);
            this.Name = "WeaponInfo";
            this.Text = "WeaponInfo";
            this.Load += new System.EventHandler(this.WeaponInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox DamageText;
        private System.Windows.Forms.TreeView WeaponTree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmmoText;
        private System.Windows.Forms.Label label5;
    }
}