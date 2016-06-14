using System.Collections.Generic;
namespace TormentaDB
{
    partial class UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private List<System.Windows.Forms.CheckBox> schoolCheckBoxList;

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
            this.nameLabel = new System.Windows.Forms.Label();
            this.levelRangeLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.arcaneCheckBox = new System.Windows.Forms.CheckBox();
            this.divineCheckBox = new System.Windows.Forms.CheckBox();
            this.levelRangeMinNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.levelRangeAuxLabel = new System.Windows.Forms.Label();
            this.levelRangeMaxNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.searchButton = new System.Windows.Forms.Button();
            this.illusionCheckBox = new System.Windows.Forms.CheckBox();
            this.enchantmentCheckBox = new System.Windows.Forms.CheckBox();
            this.divinationCheckBox = new System.Windows.Forms.CheckBox();
            this.abjurationCheckBox = new System.Windows.Forms.CheckBox();
            this.schoolLabel = new System.Windows.Forms.Label();
            this.conjurationCheckBox = new System.Windows.Forms.CheckBox();
            this.necromancyCheckBox = new System.Windows.Forms.CheckBox();
            this.healCheckBox = new System.Windows.Forms.CheckBox();
            this.transmutationCheckBox = new System.Windows.Forms.CheckBox();
            this.fireCheckBox = new System.Windows.Forms.CheckBox();
            this.waterCheckBox = new System.Windows.Forms.CheckBox();
            this.airCheckBox = new System.Windows.Forms.CheckBox();
            this.earthcheckBox = new System.Windows.Forms.CheckBox();
            this.electricityCheckBox = new System.Windows.Forms.CheckBox();
            this.coldCheckBox = new System.Windows.Forms.CheckBox();
            this.acidCheckBox = new System.Windows.Forms.CheckBox();
            this.sourcesLabel = new System.Windows.Forms.Label();
            this.manualBasCheckBox = new System.Windows.Forms.CheckBox();
            this.manualArcCheckBox = new System.Windows.Forms.CheckBox();
            this.manualDevCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.levelRangeMinNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelRangeMaxNumUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(38, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nome";
            // 
            // levelRangeLabel
            // 
            this.levelRangeLabel.AutoSize = true;
            this.levelRangeLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelRangeLabel.Location = new System.Drawing.Point(38, 60);
            this.levelRangeLabel.Name = "levelRangeLabel";
            this.levelRangeLabel.Size = new System.Drawing.Size(33, 13);
            this.levelRangeLabel.TabIndex = 1;
            this.levelRangeLabel.Text = "Nível";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Location = new System.Drawing.Point(38, 90);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(28, 13);
            this.typeLabel.TabIndex = 2;
            this.typeLabel.Text = "Tipo";
            // 
            // arcaneCheckBox
            // 
            this.arcaneCheckBox.AutoSize = true;
            this.arcaneCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.arcaneCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.arcaneCheckBox.Location = new System.Drawing.Point(96, 90);
            this.arcaneCheckBox.Name = "arcaneCheckBox";
            this.arcaneCheckBox.Size = new System.Drawing.Size(59, 17);
            this.arcaneCheckBox.TabIndex = 3;
            this.arcaneCheckBox.Text = "arcana";
            this.arcaneCheckBox.UseVisualStyleBackColor = false;
            // 
            // divineCheckBox
            // 
            this.divineCheckBox.AutoSize = true;
            this.divineCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.divineCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divineCheckBox.Location = new System.Drawing.Point(183, 90);
            this.divineCheckBox.Name = "divineCheckBox";
            this.divineCheckBox.Size = new System.Drawing.Size(54, 17);
            this.divineCheckBox.TabIndex = 4;
            this.divineCheckBox.Text = "divina";
            this.divineCheckBox.UseVisualStyleBackColor = false;
            // 
            // levelRangeMinNumUpDown
            // 
            this.levelRangeMinNumUpDown.Location = new System.Drawing.Point(96, 58);
            this.levelRangeMinNumUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.levelRangeMinNumUpDown.Name = "levelRangeMinNumUpDown";
            this.levelRangeMinNumUpDown.Size = new System.Drawing.Size(30, 20);
            this.levelRangeMinNumUpDown.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(96, 30);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(169, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // levelRangeAuxLabel
            // 
            this.levelRangeAuxLabel.AutoSize = true;
            this.levelRangeAuxLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelRangeAuxLabel.Location = new System.Drawing.Point(133, 64);
            this.levelRangeAuxLabel.Name = "levelRangeAuxLabel";
            this.levelRangeAuxLabel.Size = new System.Drawing.Size(22, 13);
            this.levelRangeAuxLabel.TabIndex = 7;
            this.levelRangeAuxLabel.Text = "até";
            // 
            // levelRangeMaxNumUpDown
            // 
            this.levelRangeMaxNumUpDown.Location = new System.Drawing.Point(161, 58);
            this.levelRangeMaxNumUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.levelRangeMaxNumUpDown.Name = "levelRangeMaxNumUpDown";
            this.levelRangeMaxNumUpDown.Size = new System.Drawing.Size(29, 20);
            this.levelRangeMaxNumUpDown.TabIndex = 8;
            this.levelRangeMaxNumUpDown.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(208, 276);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Bora!";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // illusionCheckBox
            // 
            this.illusionCheckBox.AutoSize = true;
            this.illusionCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.illusionCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.illusionCheckBox.Location = new System.Drawing.Point(389, 120);
            this.illusionCheckBox.Name = "illusionCheckBox";
            this.illusionCheckBox.Size = new System.Drawing.Size(53, 17);
            this.illusionCheckBox.TabIndex = 15;
            this.illusionCheckBox.Text = "ilusão";
            this.illusionCheckBox.UseVisualStyleBackColor = false;
            // 
            // enchantmentCheckBox
            // 
            this.enchantmentCheckBox.AutoSize = true;
            this.enchantmentCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.enchantmentCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enchantmentCheckBox.Location = new System.Drawing.Point(289, 120);
            this.enchantmentCheckBox.Name = "enchantmentCheckBox";
            this.enchantmentCheckBox.Size = new System.Drawing.Size(94, 17);
            this.enchantmentCheckBox.TabIndex = 14;
            this.enchantmentCheckBox.Text = "encantamento";
            this.enchantmentCheckBox.UseVisualStyleBackColor = false;
            // 
            // divinationCheckBox
            // 
            this.divinationCheckBox.AutoSize = true;
            this.divinationCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.divinationCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.divinationCheckBox.Location = new System.Drawing.Point(199, 120);
            this.divinationCheckBox.Name = "divinationCheckBox";
            this.divinationCheckBox.Size = new System.Drawing.Size(84, 17);
            this.divinationCheckBox.TabIndex = 13;
            this.divinationCheckBox.Text = "adivinhação";
            this.divinationCheckBox.UseVisualStyleBackColor = false;
            // 
            // abjurationCheckBox
            // 
            this.abjurationCheckBox.AutoSize = true;
            this.abjurationCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.abjurationCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.abjurationCheckBox.Location = new System.Drawing.Point(96, 120);
            this.abjurationCheckBox.Name = "abjurationCheckBox";
            this.abjurationCheckBox.Size = new System.Drawing.Size(73, 17);
            this.abjurationCheckBox.TabIndex = 12;
            this.abjurationCheckBox.Text = "abjuração";
            this.abjurationCheckBox.UseVisualStyleBackColor = false;
            // 
            // schoolLabel
            // 
            this.schoolLabel.AutoSize = true;
            this.schoolLabel.BackColor = System.Drawing.Color.Transparent;
            this.schoolLabel.Location = new System.Drawing.Point(38, 120);
            this.schoolLabel.Name = "schoolLabel";
            this.schoolLabel.Size = new System.Drawing.Size(39, 13);
            this.schoolLabel.TabIndex = 16;
            this.schoolLabel.Text = "Escola";
            // 
            // conjurationCheckBox
            // 
            this.conjurationCheckBox.AutoSize = true;
            this.conjurationCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.conjurationCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.conjurationCheckBox.Location = new System.Drawing.Point(389, 143);
            this.conjurationCheckBox.Name = "conjurationCheckBox";
            this.conjurationCheckBox.Size = new System.Drawing.Size(76, 17);
            this.conjurationCheckBox.TabIndex = 20;
            this.conjurationCheckBox.Text = "invocação";
            this.conjurationCheckBox.UseVisualStyleBackColor = false;
            // 
            // necromancyCheckBox
            // 
            this.necromancyCheckBox.AutoSize = true;
            this.necromancyCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.necromancyCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.necromancyCheckBox.Location = new System.Drawing.Point(289, 143);
            this.necromancyCheckBox.Name = "necromancyCheckBox";
            this.necromancyCheckBox.Size = new System.Drawing.Size(87, 17);
            this.necromancyCheckBox.TabIndex = 19;
            this.necromancyCheckBox.Text = "necromancia";
            this.necromancyCheckBox.UseVisualStyleBackColor = false;
            // 
            // healCheckBox
            // 
            this.healCheckBox.AutoSize = true;
            this.healCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.healCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.healCheckBox.Location = new System.Drawing.Point(199, 143);
            this.healCheckBox.Name = "healCheckBox";
            this.healCheckBox.Size = new System.Drawing.Size(47, 17);
            this.healCheckBox.TabIndex = 18;
            this.healCheckBox.Text = "cura";
            this.healCheckBox.UseVisualStyleBackColor = false;
            // 
            // transmutationCheckBox
            // 
            this.transmutationCheckBox.AutoSize = true;
            this.transmutationCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.transmutationCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.transmutationCheckBox.Location = new System.Drawing.Point(96, 143);
            this.transmutationCheckBox.Name = "transmutationCheckBox";
            this.transmutationCheckBox.Size = new System.Drawing.Size(90, 17);
            this.transmutationCheckBox.TabIndex = 17;
            this.transmutationCheckBox.Text = "transmutação";
            this.transmutationCheckBox.UseVisualStyleBackColor = false;
            // 
            // fireCheckBox
            // 
            this.fireCheckBox.AutoSize = true;
            this.fireCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.fireCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fireCheckBox.Location = new System.Drawing.Point(96, 167);
            this.fireCheckBox.Name = "fireCheckBox";
            this.fireCheckBox.Size = new System.Drawing.Size(47, 17);
            this.fireCheckBox.TabIndex = 21;
            this.fireCheckBox.Text = "fogo";
            this.fireCheckBox.UseVisualStyleBackColor = false;
            // 
            // waterCheckBox
            // 
            this.waterCheckBox.AutoSize = true;
            this.waterCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.waterCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.waterCheckBox.Location = new System.Drawing.Point(199, 167);
            this.waterCheckBox.Name = "waterCheckBox";
            this.waterCheckBox.Size = new System.Drawing.Size(50, 17);
            this.waterCheckBox.TabIndex = 22;
            this.waterCheckBox.Text = "água";
            this.waterCheckBox.UseVisualStyleBackColor = false;
            // 
            // airCheckBox
            // 
            this.airCheckBox.AutoSize = true;
            this.airCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.airCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.airCheckBox.Location = new System.Drawing.Point(289, 167);
            this.airCheckBox.Name = "airCheckBox";
            this.airCheckBox.Size = new System.Drawing.Size(35, 17);
            this.airCheckBox.TabIndex = 23;
            this.airCheckBox.Text = "ar";
            this.airCheckBox.UseVisualStyleBackColor = false;
            // 
            // earthcheckBox
            // 
            this.earthcheckBox.AutoSize = true;
            this.earthcheckBox.BackColor = System.Drawing.Color.Transparent;
            this.earthcheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.earthcheckBox.Location = new System.Drawing.Point(389, 167);
            this.earthcheckBox.Name = "earthcheckBox";
            this.earthcheckBox.Size = new System.Drawing.Size(47, 17);
            this.earthcheckBox.TabIndex = 24;
            this.earthcheckBox.Text = "terra";
            this.earthcheckBox.UseVisualStyleBackColor = false;
            // 
            // electricityCheckBox
            // 
            this.electricityCheckBox.AutoSize = true;
            this.electricityCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.electricityCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.electricityCheckBox.Location = new System.Drawing.Point(96, 191);
            this.electricityCheckBox.Name = "electricityCheckBox";
            this.electricityCheckBox.Size = new System.Drawing.Size(80, 17);
            this.electricityCheckBox.TabIndex = 25;
            this.electricityCheckBox.Text = "eletricidade";
            this.electricityCheckBox.UseVisualStyleBackColor = false;
            // 
            // coldCheckBox
            // 
            this.coldCheckBox.AutoSize = true;
            this.coldCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.coldCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.coldCheckBox.Location = new System.Drawing.Point(199, 191);
            this.coldCheckBox.Name = "coldCheckBox";
            this.coldCheckBox.Size = new System.Drawing.Size(40, 17);
            this.coldCheckBox.TabIndex = 26;
            this.coldCheckBox.Text = "frio";
            this.coldCheckBox.UseVisualStyleBackColor = false;
            // 
            // acidCheckBox
            // 
            this.acidCheckBox.AutoSize = true;
            this.acidCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.acidCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.acidCheckBox.Location = new System.Drawing.Point(289, 191);
            this.acidCheckBox.Name = "acidCheckBox";
            this.acidCheckBox.Size = new System.Drawing.Size(52, 17);
            this.acidCheckBox.TabIndex = 27;
            this.acidCheckBox.Text = "ácido";
            this.acidCheckBox.UseVisualStyleBackColor = false;
            // 
            // sourcesLabel
            // 
            this.sourcesLabel.AutoSize = true;
            this.sourcesLabel.BackColor = System.Drawing.Color.Transparent;
            this.sourcesLabel.Location = new System.Drawing.Point(41, 234);
            this.sourcesLabel.Name = "sourcesLabel";
            this.sourcesLabel.Size = new System.Drawing.Size(39, 13);
            this.sourcesLabel.TabIndex = 28;
            this.sourcesLabel.Text = "Fontes";
            // 
            // manualBasCheckBox
            // 
            this.manualBasCheckBox.AutoSize = true;
            this.manualBasCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.manualBasCheckBox.Enabled = false;
            this.manualBasCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualBasCheckBox.Location = new System.Drawing.Point(96, 234);
            this.manualBasCheckBox.Name = "manualBasCheckBox";
            this.manualBasCheckBox.Size = new System.Drawing.Size(96, 17);
            this.manualBasCheckBox.TabIndex = 29;
            this.manualBasCheckBox.Text = "Manual Básico";
            this.manualBasCheckBox.UseVisualStyleBackColor = false;
            // 
            // manualArcCheckBox
            // 
            this.manualArcCheckBox.AutoSize = true;
            this.manualArcCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.manualArcCheckBox.Enabled = false;
            this.manualArcCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualArcCheckBox.Location = new System.Drawing.Point(228, 234);
            this.manualArcCheckBox.Name = "manualArcCheckBox";
            this.manualArcCheckBox.Size = new System.Drawing.Size(113, 17);
            this.manualArcCheckBox.TabIndex = 30;
            this.manualArcCheckBox.Text = "Manual do Arcano";
            this.manualArcCheckBox.UseVisualStyleBackColor = false;
            // 
            // manualDevCheckBox
            // 
            this.manualDevCheckBox.AutoSize = true;
            this.manualDevCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.manualDevCheckBox.Enabled = false;
            this.manualDevCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manualDevCheckBox.Location = new System.Drawing.Point(362, 234);
            this.manualDevCheckBox.Name = "manualDevCheckBox";
            this.manualDevCheckBox.Size = new System.Drawing.Size(114, 17);
            this.manualDevCheckBox.TabIndex = 31;
            this.manualDevCheckBox.Text = "Manual do Devoto";
            this.manualDevCheckBox.UseVisualStyleBackColor = false;
            // 
            // UI
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 324);
            this.Controls.Add(this.manualDevCheckBox);
            this.Controls.Add(this.manualArcCheckBox);
            this.Controls.Add(this.manualBasCheckBox);
            this.Controls.Add(this.sourcesLabel);
            this.Controls.Add(this.acidCheckBox);
            this.Controls.Add(this.coldCheckBox);
            this.Controls.Add(this.electricityCheckBox);
            this.Controls.Add(this.earthcheckBox);
            this.Controls.Add(this.airCheckBox);
            this.Controls.Add(this.waterCheckBox);
            this.Controls.Add(this.fireCheckBox);
            this.Controls.Add(this.conjurationCheckBox);
            this.Controls.Add(this.necromancyCheckBox);
            this.Controls.Add(this.healCheckBox);
            this.Controls.Add(this.transmutationCheckBox);
            this.Controls.Add(this.schoolLabel);
            this.Controls.Add(this.illusionCheckBox);
            this.Controls.Add(this.enchantmentCheckBox);
            this.Controls.Add(this.divinationCheckBox);
            this.Controls.Add(this.abjurationCheckBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.levelRangeMaxNumUpDown);
            this.Controls.Add(this.levelRangeAuxLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.levelRangeMinNumUpDown);
            this.Controls.Add(this.divineCheckBox);
            this.Controls.Add(this.arcaneCheckBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.levelRangeLabel);
            this.Controls.Add(this.nameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Text = "Tormenta DB (beta)";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.levelRangeMinNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.levelRangeMaxNumUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label levelRangeLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.CheckBox arcaneCheckBox;
        private System.Windows.Forms.CheckBox divineCheckBox;
        private System.Windows.Forms.NumericUpDown levelRangeMinNumUpDown;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label levelRangeAuxLabel;
        private System.Windows.Forms.NumericUpDown levelRangeMaxNumUpDown;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.CheckBox illusionCheckBox;
        private System.Windows.Forms.CheckBox enchantmentCheckBox;
        private System.Windows.Forms.CheckBox divinationCheckBox;
        private System.Windows.Forms.CheckBox abjurationCheckBox;
        private System.Windows.Forms.Label schoolLabel;
        private System.Windows.Forms.CheckBox conjurationCheckBox;
        private System.Windows.Forms.CheckBox necromancyCheckBox;
        private System.Windows.Forms.CheckBox healCheckBox;
        private System.Windows.Forms.CheckBox transmutationCheckBox;
        private System.Windows.Forms.CheckBox fireCheckBox;
        private System.Windows.Forms.CheckBox waterCheckBox;
        private System.Windows.Forms.CheckBox airCheckBox;
        private System.Windows.Forms.CheckBox earthcheckBox;
        private System.Windows.Forms.CheckBox electricityCheckBox;
        private System.Windows.Forms.CheckBox coldCheckBox;
        private System.Windows.Forms.CheckBox acidCheckBox;
        private System.Windows.Forms.Label sourcesLabel;
        private System.Windows.Forms.CheckBox manualBasCheckBox;
        private System.Windows.Forms.CheckBox manualArcCheckBox;
        private System.Windows.Forms.CheckBox manualDevCheckBox;
    }
}

