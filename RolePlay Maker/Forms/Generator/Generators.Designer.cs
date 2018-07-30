namespace RolePlay_Maker.Forms
{
    partial class Generators
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
            this.NPCGenerator = new System.Windows.Forms.Button();
            this.QuestGeneraor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NPCGenerator
            // 
            this.NPCGenerator.Location = new System.Drawing.Point(90, 42);
            this.NPCGenerator.Name = "NPCGenerator";
            this.NPCGenerator.Size = new System.Drawing.Size(108, 43);
            this.NPCGenerator.TabIndex = 0;
            this.NPCGenerator.Text = "Генератор снаряжения NPC";
            this.NPCGenerator.UseVisualStyleBackColor = true;
            this.NPCGenerator.Click += new System.EventHandler(this.NPCGenerator_Click);
            // 
            // QuestGeneraor
            // 
            this.QuestGeneraor.Location = new System.Drawing.Point(90, 118);
            this.QuestGeneraor.Name = "QuestGeneraor";
            this.QuestGeneraor.Size = new System.Drawing.Size(108, 42);
            this.QuestGeneraor.TabIndex = 1;
            this.QuestGeneraor.Text = "Генератор квестов";
            this.QuestGeneraor.UseVisualStyleBackColor = true;
            this.QuestGeneraor.Click += new System.EventHandler(this.QuestGeneraor_Click);
            // 
            // Generators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 207);
            this.Controls.Add(this.QuestGeneraor);
            this.Controls.Add(this.NPCGenerator);
            this.Name = "Generators";
            this.Text = "Generators";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NPCGenerator;
        private System.Windows.Forms.Button QuestGeneraor;
    }
}