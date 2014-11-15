namespace PriestGuy.Settings
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopOnHighThreatCheckBox = new System.Windows.Forms.CheckBox();
            this.rezPlayersCheckBox = new System.Windows.Forms.CheckBox();
            this.healMyselfNumeric = new System.Windows.Forms.NumericUpDown();
            this.useShieldNumeric = new System.Windows.Forms.NumericUpDown();
            this.healMyselfCheckBox = new System.Windows.Forms.CheckBox();
            this.useShieldCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aoeCheckBox = new System.Windows.Forms.CheckBox();
            this.aoeStartNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healMyselfNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.useShieldNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoeStartNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aoeStartNumeric);
            this.groupBox1.Controls.Add(this.aoeCheckBox);
            this.groupBox1.Controls.Add(this.stopOnHighThreatCheckBox);
            this.groupBox1.Controls.Add(this.rezPlayersCheckBox);
            this.groupBox1.Controls.Add(this.healMyselfNumeric);
            this.groupBox1.Controls.Add(this.useShieldNumeric);
            this.groupBox1.Controls.Add(this.healMyselfCheckBox);
            this.groupBox1.Controls.Add(this.useShieldCheckBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuration";
            // 
            // stopOnHighThreatCheckBox
            // 
            this.stopOnHighThreatCheckBox.AutoSize = true;
            this.stopOnHighThreatCheckBox.Location = new System.Drawing.Point(6, 81);
            this.stopOnHighThreatCheckBox.Name = "stopOnHighThreatCheckBox";
            this.stopOnHighThreatCheckBox.Size = new System.Drawing.Size(153, 17);
            this.stopOnHighThreatCheckBox.TabIndex = 5;
            this.stopOnHighThreatCheckBox.Text = "Stop casting on high threat";
            this.stopOnHighThreatCheckBox.UseVisualStyleBackColor = true;
            // 
            // rezPlayersCheckBox
            // 
            this.rezPlayersCheckBox.AutoSize = true;
            this.rezPlayersCheckBox.Location = new System.Drawing.Point(6, 104);
            this.rezPlayersCheckBox.Name = "rezPlayersCheckBox";
            this.rezPlayersCheckBox.Size = new System.Drawing.Size(143, 17);
            this.rezPlayersCheckBox.TabIndex = 4;
            this.rezPlayersCheckBox.Text = "Resurrect nearby players";
            this.rezPlayersCheckBox.UseVisualStyleBackColor = true;
            // 
            // healMyselfNumeric
            // 
            this.healMyselfNumeric.Location = new System.Drawing.Point(138, 40);
            this.healMyselfNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.healMyselfNumeric.Name = "healMyselfNumeric";
            this.healMyselfNumeric.Size = new System.Drawing.Size(68, 20);
            this.healMyselfNumeric.TabIndex = 3;
            this.healMyselfNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // useShieldNumeric
            // 
            this.useShieldNumeric.Location = new System.Drawing.Point(138, 17);
            this.useShieldNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.useShieldNumeric.Name = "useShieldNumeric";
            this.useShieldNumeric.Size = new System.Drawing.Size(68, 20);
            this.useShieldNumeric.TabIndex = 2;
            this.useShieldNumeric.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // healMyselfCheckBox
            // 
            this.healMyselfCheckBox.AutoSize = true;
            this.healMyselfCheckBox.Location = new System.Drawing.Point(6, 43);
            this.healMyselfCheckBox.Name = "healMyselfCheckBox";
            this.healMyselfCheckBox.Size = new System.Drawing.Size(80, 17);
            this.healMyselfCheckBox.TabIndex = 1;
            this.healMyselfCheckBox.Text = "Heal myself";
            this.healMyselfCheckBox.UseVisualStyleBackColor = true;
            // 
            // useShieldCheckBox
            // 
            this.useShieldCheckBox.AutoSize = true;
            this.useShieldCheckBox.Location = new System.Drawing.Point(6, 20);
            this.useShieldCheckBox.Name = "useShieldCheckBox";
            this.useShieldCheckBox.Size = new System.Drawing.Size(77, 17);
            this.useShieldCheckBox.TabIndex = 0;
            this.useShieldCheckBox.Text = "Use Shield";
            this.useShieldCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PriestGuy.Properties.Resources.Banner;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 200);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // aoeCheckBox
            // 
            this.aoeCheckBox.AutoSize = true;
            this.aoeCheckBox.Location = new System.Drawing.Point(6, 127);
            this.aoeCheckBox.Name = "aoeCheckBox";
            this.aoeCheckBox.Size = new System.Drawing.Size(154, 17);
            this.aoeCheckBox.TabIndex = 6;
            this.aoeCheckBox.Text = "AOE (Mind Sear).  Start at :";
            this.aoeCheckBox.UseVisualStyleBackColor = true;
            // 
            // aoeStartNumeric
            // 
            this.aoeStartNumeric.Location = new System.Drawing.Point(163, 126);
            this.aoeStartNumeric.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.aoeStartNumeric.Name = "aoeStartNumeric";
            this.aoeStartNumeric.Size = new System.Drawing.Size(43, 20);
            this.aoeStartNumeric.TabIndex = 7;
            this.aoeStartNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PriestGuy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSettings_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healMyselfNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.useShieldNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoeStartNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox healMyselfCheckBox;
        private System.Windows.Forms.CheckBox useShieldCheckBox;
        private System.Windows.Forms.NumericUpDown useShieldNumeric;
        private System.Windows.Forms.NumericUpDown healMyselfNumeric;
        private System.Windows.Forms.CheckBox rezPlayersCheckBox;
        private System.Windows.Forms.CheckBox stopOnHighThreatCheckBox;
        private System.Windows.Forms.CheckBox aoeCheckBox;
        private System.Windows.Forms.NumericUpDown aoeStartNumeric;
    }
}