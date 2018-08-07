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
            this.label7 = new System.Windows.Forms.Label();
            this.MagazineText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FractionText = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SubClassText = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Тип боеприпасов";
            // 
            // AmmoText
            // 
            this.AmmoText.Location = new System.Drawing.Point(109, 69);
            this.AmmoText.Name = "AmmoText";
            this.AmmoText.Size = new System.Drawing.Size(225, 20);
            this.AmmoText.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Урон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "СТО";
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(213, 39);
            this.PriceText.Name = "PriceText";
            this.PriceText.Size = new System.Drawing.Size(121, 20);
            this.PriceText.TabIndex = 27;
            // 
            // DamageText
            // 
            this.DamageText.Location = new System.Drawing.Point(75, 39);
            this.DamageText.Name = "DamageText";
            this.DamageText.Size = new System.Drawing.Size(100, 20);
            this.DamageText.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(15, 191);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(311, 180);
            this.DescriptionText.TabIndex = 23;
            this.DescriptionText.Text = "";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(75, 13);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(100, 20);
            this.NameText.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 377);
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
            "Холодное оружие",
            "Легкое оружие",
            "Тяжелое оружие",
            "Энергетическое оружие"});
            this.ClassCombo.Location = new System.Drawing.Point(213, 12);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(121, 21);
            this.ClassCombo.TabIndex = 34;
            this.ClassCombo.SelectedIndexChanged += new System.EventHandler(this.ClassCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Тип";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Размер обоймы";
            // 
            // MagazineText
            // 
            this.MagazineText.Location = new System.Drawing.Point(109, 95);
            this.MagazineText.Name = "MagazineText";
            this.MagazineText.Size = new System.Drawing.Size(121, 20);
            this.MagazineText.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Фракция";
            // 
            // FractionText
            // 
            this.FractionText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FractionText.FormattingEnabled = true;
            this.FractionText.Items.AddRange(new object[] {
            "Нет",
            "Путник",
            "НКР",
            "Легион",
            "Братсво Стали",
            "Анклав",
            "Черти",
            "Рейдеры",
            "Подрывники",
            "Дети атома",
            "Последователи апокалипса",
            "Хабологи",
            "Великие ханы",
            "Дикарь",
            "Выходец из Убежища"});
            this.FractionText.Location = new System.Drawing.Point(109, 121);
            this.FractionText.Name = "FractionText";
            this.FractionText.Size = new System.Drawing.Size(121, 21);
            this.FractionText.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Подтип";
            // 
            // SubClassText
            // 
            this.SubClassText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubClassText.FormattingEnabled = true;
            this.SubClassText.Items.AddRange(new object[] {
            "Нет",
            "Путник",
            "НКР",
            "Легион",
            "Братсво Стали",
            "Анклав",
            "Черти",
            "Рейдеры",
            "Подрывники",
            "Дети атома",
            "Последователи апокалипса",
            "Хабологи",
            "Великие ханы",
            "Дикарь",
            "Выходец из Убежища"});
            this.SubClassText.Location = new System.Drawing.Point(109, 148);
            this.SubClassText.Name = "SubClassText";
            this.SubClassText.Size = new System.Drawing.Size(121, 21);
            this.SubClassText.TabIndex = 41;
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 419);
            this.status.Name = "status";
            this.status.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.status.Size = new System.Drawing.Size(341, 22);
            this.status.TabIndex = 42;
            this.status.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // AddWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 441);
            this.Controls.Add(this.status);
            this.Controls.Add(this.SubClassText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FractionText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MagazineText);
            this.Controls.Add(this.label7);
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
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MagazineText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox FractionText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SubClassText;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}