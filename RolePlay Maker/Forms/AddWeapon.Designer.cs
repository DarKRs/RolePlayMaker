namespace RolePlay_Maker
{
    partial class AddWeapon
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
            this.label5 = new System.Windows.Forms.Label();
            this.AmmoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.DamageText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Тип патронов";
            // 
            // AmmoText
            // 
            this.AmmoText.Location = new System.Drawing.Point(18, 104);
            this.AmmoText.Name = "AmmoText";
            this.AmmoText.Size = new System.Drawing.Size(302, 20);
            this.AmmoText.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Урон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Средняя стоимость";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(159, 130);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(100, 20);
            this.PriceText.TabIndex = 27;
            // 
            // DamageText
            // 
            this.DamageText.Location = new System.Drawing.Point(57, 46);
            this.DamageText.Name = "DamageText";
            this.DamageText.Size = new System.Drawing.Size(100, 20);
            this.DamageText.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(12, 156);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(311, 199);
            this.DescriptionText.TabIndex = 23;
            this.DescriptionText.Text = "";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(53, 12);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 44);
            this.button1.TabIndex = 33;
            this.button1.Text = "Добавить оружие";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassCombo
            // 
            this.ClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Items.AddRange(new object[] {
            "Легкое оружие",
            "Тяжелое оружие",
            "Холодное оружие",
            "Энергетическое оружие",
            "Взрывчатка"});
            this.ClassCombo.Location = new System.Drawing.Point(203, 12);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(121, 21);
            this.ClassCombo.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Тип";
            // 
            // AddWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClassCombo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmmoText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceText);
            this.Controls.Add(this.DamageText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NameText);
            this.Name = "AddWeapon";
            this.Text = "AddWeapon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmmoText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.TextBox DamageText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.Label label6;
    }
}