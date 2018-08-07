namespace RolePlay_Maker
{
    partial class MainForm
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
            this.CreatePerson = new System.Windows.Forms.Button();
            this.LoadPerson = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиПрофиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиСетиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.существаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСуществоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оружиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОружиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.способностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСпособностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.броняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чертыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧертуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Generator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePerson
            // 
            this.CreatePerson.Location = new System.Drawing.Point(16, 118);
            this.CreatePerson.Margin = new System.Windows.Forms.Padding(4);
            this.CreatePerson.Name = "CreatePerson";
            this.CreatePerson.Size = new System.Drawing.Size(263, 63);
            this.CreatePerson.TabIndex = 0;
            this.CreatePerson.Text = "Создать персонажа";
            this.CreatePerson.UseVisualStyleBackColor = true;
            this.CreatePerson.Click += new System.EventHandler(this.CreatePerson_Click);
            // 
            // LoadPerson
            // 
            this.LoadPerson.Location = new System.Drawing.Point(16, 47);
            this.LoadPerson.Margin = new System.Windows.Forms.Padding(4);
            this.LoadPerson.Name = "LoadPerson";
            this.LoadPerson.Size = new System.Drawing.Size(263, 64);
            this.LoadPerson.TabIndex = 1;
            this.LoadPerson.Text = "Загрузить персонажа";
            this.LoadPerson.UseVisualStyleBackColor = true;
            this.LoadPerson.Click += new System.EventHandler(this.LoadPerson_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 188);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(263, 66);
            this.button3.TabIndex = 2;
            this.button3.Text = "Сеть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(299, 262);
            this.Close.Margin = new System.Windows.Forms.Padding(4);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(263, 59);
            this.Close.TabIndex = 3;
            this.Close.Text = "Выход";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.справочникToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиПрофиляToolStripMenuItem,
            this.настройкиСетиToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкиПрофиляToolStripMenuItem
            // 
            this.настройкиПрофиляToolStripMenuItem.Name = "настройкиПрофиляToolStripMenuItem";
            this.настройкиПрофиляToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.настройкиПрофиляToolStripMenuItem.Text = "Настройки профиля";
            this.настройкиПрофиляToolStripMenuItem.Click += new System.EventHandler(this.настройкиПрофиляToolStripMenuItem_Click);
            // 
            // настройкиСетиToolStripMenuItem
            // 
            this.настройкиСетиToolStripMenuItem.Name = "настройкиСетиToolStripMenuItem";
            this.настройкиСетиToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.настройкиСетиToolStripMenuItem.Text = "Настройки сети";
            this.настройкиСетиToolStripMenuItem.Click += new System.EventHandler(this.настройкиСетиToolStripMenuItem_Click);
            // 
            // справочникToolStripMenuItem
            // 
            this.справочникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.существаToolStripMenuItem,
            this.оружиеToolStripMenuItem,
            this.способностиToolStripMenuItem,
            this.броняToolStripMenuItem,
            this.чертыToolStripMenuItem});
            this.справочникToolStripMenuItem.Name = "справочникToolStripMenuItem";
            this.справочникToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.справочникToolStripMenuItem.Text = "Справочник";
            // 
            // существаToolStripMenuItem
            // 
            this.существаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem1,
            this.добавитьСуществоToolStripMenuItem});
            this.существаToolStripMenuItem.Image = global::RolePlay_Maker.Properties.Resources.qsRvmB6cOw4;
            this.существаToolStripMenuItem.Name = "существаToolStripMenuItem";
            this.существаToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.существаToolStripMenuItem.Text = "Существа";
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.справкаToolStripMenuItem1.Text = "Справка";
            this.справкаToolStripMenuItem1.Click += new System.EventHandler(this.справкаToolStripMenuItem1_Click);
            // 
            // добавитьСуществоToolStripMenuItem
            // 
            this.добавитьСуществоToolStripMenuItem.Name = "добавитьСуществоToolStripMenuItem";
            this.добавитьСуществоToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.добавитьСуществоToolStripMenuItem.Text = "Добавить существо";
            this.добавитьСуществоToolStripMenuItem.Click += new System.EventHandler(this.добавитьСуществоToolStripMenuItem_Click);
            // 
            // оружиеToolStripMenuItem
            // 
            this.оружиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem2,
            this.добавитьОружиеToolStripMenuItem});
            this.оружиеToolStripMenuItem.Name = "оружиеToolStripMenuItem";
            this.оружиеToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.оружиеToolStripMenuItem.Text = "Оружие";
            // 
            // справкаToolStripMenuItem2
            // 
            this.справкаToolStripMenuItem2.Name = "справкаToolStripMenuItem2";
            this.справкаToolStripMenuItem2.Size = new System.Drawing.Size(208, 26);
            this.справкаToolStripMenuItem2.Text = "Справка";
            this.справкаToolStripMenuItem2.Click += new System.EventHandler(this.справкаToolStripMenuItem2_Click_1);
            // 
            // добавитьОружиеToolStripMenuItem
            // 
            this.добавитьОружиеToolStripMenuItem.Name = "добавитьОружиеToolStripMenuItem";
            this.добавитьОружиеToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.добавитьОружиеToolStripMenuItem.Text = "Добавить оружие";
            this.добавитьОружиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьОружиеToolStripMenuItem_Click_1);
            // 
            // способностиToolStripMenuItem
            // 
            this.способностиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem3,
            this.добавитьСпособностьToolStripMenuItem});
            this.способностиToolStripMenuItem.Name = "способностиToolStripMenuItem";
            this.способностиToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.способностиToolStripMenuItem.Text = "Способности";
            // 
            // справкаToolStripMenuItem3
            // 
            this.справкаToolStripMenuItem3.Name = "справкаToolStripMenuItem3";
            this.справкаToolStripMenuItem3.Size = new System.Drawing.Size(244, 26);
            this.справкаToolStripMenuItem3.Text = "Справка";
            this.справкаToolStripMenuItem3.Click += new System.EventHandler(this.справкаToolStripMenuItem3_Click);
            // 
            // добавитьСпособностьToolStripMenuItem
            // 
            this.добавитьСпособностьToolStripMenuItem.Name = "добавитьСпособностьToolStripMenuItem";
            this.добавитьСпособностьToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.добавитьСпособностьToolStripMenuItem.Text = "Добавить способность";
            this.добавитьСпособностьToolStripMenuItem.Click += new System.EventHandler(this.добавитьСпособностьToolStripMenuItem_Click);
            // 
            // броняToolStripMenuItem
            // 
            this.броняToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.добавитьToolStripMenuItem});
            this.броняToolStripMenuItem.Name = "броняToolStripMenuItem";
            this.броняToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.броняToolStripMenuItem.Text = "Броня";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.добавитьToolStripMenuItem.Text = "Добавить броню";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // чертыToolStripMenuItem
            // 
            this.чертыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem4,
            this.добавитьЧертуToolStripMenuItem});
            this.чертыToolStripMenuItem.Name = "чертыToolStripMenuItem";
            this.чертыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.чертыToolStripMenuItem.Text = "Черты";
            // 
            // справкаToolStripMenuItem4
            // 
            this.справкаToolStripMenuItem4.Name = "справкаToolStripMenuItem4";
            this.справкаToolStripMenuItem4.Size = new System.Drawing.Size(160, 22);
            this.справкаToolStripMenuItem4.Text = "Справка";
            this.справкаToolStripMenuItem4.Click += new System.EventHandler(this.справкаToolStripMenuItem4_Click);
            // 
            // добавитьЧертуToolStripMenuItem
            // 
            this.добавитьЧертуToolStripMenuItem.Name = "добавитьЧертуToolStripMenuItem";
            this.добавитьЧертуToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.добавитьЧертуToolStripMenuItem.Text = "Добавить черту";
            this.добавитьЧертуToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧертуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(126, 26);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // Generator
            // 
            this.Generator.Location = new System.Drawing.Point(581, 47);
            this.Generator.Margin = new System.Windows.Forms.Padding(4);
            this.Generator.Name = "Generator";
            this.Generator.Size = new System.Drawing.Size(263, 66);
            this.Generator.TabIndex = 5;
            this.Generator.Text = "Генерация";
            this.Generator.UseVisualStyleBackColor = true;
            this.Generator.Click += new System.EventHandler(this.Generator_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(860, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Generator);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LoadPerson);
            this.Controls.Add(this.CreatePerson);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RolePlay Maker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePerson;
        private System.Windows.Forms.Button LoadPerson;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиПрофиляToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиСетиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оружиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem способностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem броняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem добавитьСпособностьToolStripMenuItem;
        private System.Windows.Forms.Button Generator;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьОружиеToolStripMenuItem;
<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
=======
        private System.Windows.Forms.ToolStripMenuItem существаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСуществоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чертыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧертуToolStripMenuItem;
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630
    }
}