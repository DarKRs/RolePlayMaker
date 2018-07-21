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
            this.Fraction = new System.Windows.Forms.ComboBox();
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
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Группировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Уровень игроков";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кол-во игроков";
            // 
            // Fraction
            // 
            this.Fraction.FormattingEnabled = true;
            this.Fraction.Items.AddRange(new object[] {
            "Анклав",
            "Черти"});
            this.Fraction.Location = new System.Drawing.Point(16, 31);
            this.Fraction.Margin = new System.Windows.Forms.Padding(4);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(160, 24);
            this.Fraction.TabIndex = 3;
            // 
            // PlayerLevel
            // 
            this.PlayerLevel.Location = new System.Drawing.Point(185, 31);
            this.PlayerLevel.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerLevel.Name = "PlayerLevel";
            this.PlayerLevel.Size = new System.Drawing.Size(160, 22);
            this.PlayerLevel.TabIndex = 4;
            // 
            // PlayerCount
            // 
            this.PlayerCount.Location = new System.Drawing.Point(353, 32);
            this.PlayerCount.Margin = new System.Windows.Forms.Padding(4);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(160, 22);
            this.PlayerCount.TabIndex = 5;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(543, 21);
            this.Generate.Margin = new System.Windows.Forms.Padding(4);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(167, 41);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // GeneratedField
            // 
            this.GeneratedField.Location = new System.Drawing.Point(3, 63);
            this.GeneratedField.Margin = new System.Windows.Forms.Padding(4);
            this.GeneratedField.Name = "GeneratedField";
            this.GeneratedField.Size = new System.Drawing.Size(707, 336);
            this.GeneratedField.TabIndex = 8;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(RolePlay_Maker.Person);
            // 
            // NPCGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 415);
            this.Controls.Add(this.GeneratedField);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.PlayerCount);
            this.Controls.Add(this.PlayerLevel);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NPCGeneratorForm";
            this.Text = "NPCGenerator";
            this.Load += new System.EventHandler(this.NPCGeneratorForm_Load);
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
        private System.Windows.Forms.ComboBox Fraction;
        private System.Windows.Forms.NumericUpDown PlayerLevel;
        private System.Windows.Forms.NumericUpDown PlayerCount;
        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Panel GeneratedField;
    }
}