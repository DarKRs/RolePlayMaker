namespace RolePlay_Maker.Forms
{
    partial class NPCGeneratorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Faction = new System.Windows.Forms.ComboBox();
            this.PlayerLevel = new System.Windows.Forms.NumericUpDown();
            this.PlayerCount = new System.Windows.Forms.NumericUpDown();
            this.Generate = new System.Windows.Forms.Button();
            this.GeneratedField = new System.Windows.Forms.Panel();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Уровень игроков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во игроков";
            // 
            // Faction
            // 
            this.Faction.FormattingEnabled = true;
            this.Faction.Items.AddRange(new object[] {
            "Анклав",
            "Черти"});
            this.Faction.Location = new System.Drawing.Point(12, 25);
            this.Faction.Name = "Faction";
            this.Faction.Size = new System.Drawing.Size(121, 21);
            this.Faction.TabIndex = 3;
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.Location = new System.Drawing.Point(139, 25);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(120, 20);
            this.PlayerLevel.TabIndex = 4;
            // 
            // PlayerCount
            // 
            this.PlayerCount.Location = new System.Drawing.Point(265, 26);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(120, 20);
            this.PlayerCount.TabIndex = 5;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(407, 17);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(125, 33);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // GeneratedField
            // 
            this.GeneratedField.Location = new System.Drawing.Point(2, 51);
            this.GeneratedField.Name = "GeneratedField";
            this.GeneratedField.Size = new System.Drawing.Size(530, 273);
            this.GeneratedField.TabIndex = 8;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(RolePlay_Maker.Person);
            // 
            // NPCGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 337);
            this.Controls.Add(this.GeneratedField);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.PlayerCount);
            this.Controls.Add(this.PlayerLevel);
            this.Controls.Add(this.Faction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NPCGeneratorForm";
            this.Text = "NPCGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Faction;
        private System.Windows.Forms.NumericUpDown PlayerLevel;
        private System.Windows.Forms.NumericUpDown PlayerCount;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Panel GeneratedField;
    }
}