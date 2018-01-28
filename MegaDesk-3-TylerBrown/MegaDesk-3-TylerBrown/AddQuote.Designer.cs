namespace MegaDesk_3_TylerBrown
{
    partial class AddQuote
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
            this.cancelAddQuote = new System.Windows.Forms.Button();
            this.AddQuoteTitleLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskSizeWidthInput = new System.Windows.Forms.NumericUpDown();
            this.DeskSizeDepthLabel = new System.Windows.Forms.Label();
            this.DeskSizeWidthLabel = new System.Windows.Forms.Label();
            this.DeskSizeDepthInput = new System.Windows.Forms.NumericUpDown();
            this.NumberOfDrawersLabel = new System.Windows.Forms.Label();
            this.DeskSizeLabel = new System.Windows.Forms.Label();
            this.NumberOfDrawersInput = new System.Windows.Forms.NumericUpDown();
            this.CustomerNameInput = new System.Windows.Forms.TextBox();
            this.SurfaceMaterialLabel = new System.Windows.Forms.Label();
            this.SurfaceMaterialLaminateOption = new System.Windows.Forms.RadioButton();
            this.SurfaceMaterialOakOption = new System.Windows.Forms.RadioButton();
            this.SurfaceMaterialRosewoodOption = new System.Windows.Forms.RadioButton();
            this.SurfaceMaterialVeneerOption = new System.Windows.Forms.RadioButton();
            this.SurfaceMaterialPineOption = new System.Windows.Forms.RadioButton();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.RushOrderNoneOption = new System.Windows.Forms.RadioButton();
            this.RushOrder3DaysOption = new System.Windows.Forms.RadioButton();
            this.RushOrder5DaysOption = new System.Windows.Forms.RadioButton();
            this.RushOrder7DaysOption = new System.Windows.Forms.RadioButton();
            this.SaveQuoteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DeskSizeWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskSizeDepthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersInput)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelAddQuote
            // 
            this.cancelAddQuote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelAddQuote.Location = new System.Drawing.Point(371, 459);
            this.cancelAddQuote.Name = "cancelAddQuote";
            this.cancelAddQuote.Size = new System.Drawing.Size(140, 40);
            this.cancelAddQuote.TabIndex = 15;
            this.cancelAddQuote.Text = "Cancel";
            this.cancelAddQuote.UseMnemonic = false;
            this.cancelAddQuote.UseVisualStyleBackColor = true;
            this.cancelAddQuote.Click += new System.EventHandler(this.cancelAddQuote_Click);
            // 
            // AddQuoteTitleLabel
            // 
            this.AddQuoteTitleLabel.AutoSize = true;
            this.AddQuoteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuoteTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.AddQuoteTitleLabel.Name = "AddQuoteTitleLabel";
            this.AddQuoteTitleLabel.Size = new System.Drawing.Size(137, 26);
            this.AddQuoteTitleLabel.TabIndex = 0;
            this.AddQuoteTitleLabel.Text = "Add A Quote";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(14, 52);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(48, 18);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Name";
            // 
            // DeskSizeWidthInput
            // 
            this.DeskSizeWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSizeWidthInput.Location = new System.Drawing.Point(141, 27);
            this.DeskSizeWidthInput.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.DeskSizeWidthInput.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.DeskSizeWidthInput.Name = "DeskSizeWidthInput";
            this.DeskSizeWidthInput.Size = new System.Drawing.Size(53, 23);
            this.DeskSizeWidthInput.TabIndex = 1;
            this.DeskSizeWidthInput.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // DeskSizeDepthLabel
            // 
            this.DeskSizeDepthLabel.AutoSize = true;
            this.DeskSizeDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSizeDepthLabel.Location = new System.Drawing.Point(10, 56);
            this.DeskSizeDepthLabel.Name = "DeskSizeDepthLabel";
            this.DeskSizeDepthLabel.Size = new System.Drawing.Size(123, 18);
            this.DeskSizeDepthLabel.TabIndex = 3;
            this.DeskSizeDepthLabel.Text = "Depth (in inches):";
            // 
            // DeskSizeWidthLabel
            // 
            this.DeskSizeWidthLabel.AutoSize = true;
            this.DeskSizeWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSizeWidthLabel.Location = new System.Drawing.Point(11, 27);
            this.DeskSizeWidthLabel.Name = "DeskSizeWidthLabel";
            this.DeskSizeWidthLabel.Size = new System.Drawing.Size(122, 18);
            this.DeskSizeWidthLabel.TabIndex = 1;
            this.DeskSizeWidthLabel.Text = "Width (in inches):";
            // 
            // DeskSizeDepthInput
            // 
            this.DeskSizeDepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSizeDepthInput.Location = new System.Drawing.Point(141, 56);
            this.DeskSizeDepthInput.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.DeskSizeDepthInput.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.DeskSizeDepthInput.Name = "DeskSizeDepthInput";
            this.DeskSizeDepthInput.Size = new System.Drawing.Size(53, 23);
            this.DeskSizeDepthInput.TabIndex = 2;
            this.DeskSizeDepthInput.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // NumberOfDrawersLabel
            // 
            this.NumberOfDrawersLabel.AutoSize = true;
            this.NumberOfDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersLabel.Location = new System.Drawing.Point(14, 168);
            this.NumberOfDrawersLabel.Name = "NumberOfDrawersLabel";
            this.NumberOfDrawersLabel.Size = new System.Drawing.Size(138, 18);
            this.NumberOfDrawersLabel.TabIndex = 3;
            this.NumberOfDrawersLabel.Text = "Number of Drawers";
            // 
            // DeskSizeLabel
            // 
            this.DeskSizeLabel.AutoSize = true;
            this.DeskSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSizeLabel.Location = new System.Drawing.Point(-3, 0);
            this.DeskSizeLabel.Name = "DeskSizeLabel";
            this.DeskSizeLabel.Size = new System.Drawing.Size(76, 18);
            this.DeskSizeLabel.TabIndex = 0;
            this.DeskSizeLabel.Text = "Desk Size";
            // 
            // NumberOfDrawersInput
            // 
            this.NumberOfDrawersInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberOfDrawersInput.Location = new System.Drawing.Point(158, 168);
            this.NumberOfDrawersInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumberOfDrawersInput.Name = "NumberOfDrawersInput";
            this.NumberOfDrawersInput.Size = new System.Drawing.Size(53, 22);
            this.NumberOfDrawersInput.TabIndex = 3;
            this.NumberOfDrawersInput.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInput.Location = new System.Drawing.Point(68, 51);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(149, 23);
            this.CustomerNameInput.TabIndex = 0;
            // 
            // SurfaceMaterialLabel
            // 
            this.SurfaceMaterialLabel.AutoSize = true;
            this.SurfaceMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLabel.Location = new System.Drawing.Point(-3, 0);
            this.SurfaceMaterialLabel.Name = "SurfaceMaterialLabel";
            this.SurfaceMaterialLabel.Size = new System.Drawing.Size(115, 18);
            this.SurfaceMaterialLabel.TabIndex = 0;
            this.SurfaceMaterialLabel.Text = "Surface Material";
            // 
            // SurfaceMaterialLaminateOption
            // 
            this.SurfaceMaterialLaminateOption.AutoSize = true;
            this.SurfaceMaterialLaminateOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialLaminateOption.Location = new System.Drawing.Point(7, 21);
            this.SurfaceMaterialLaminateOption.Name = "SurfaceMaterialLaminateOption";
            this.SurfaceMaterialLaminateOption.Size = new System.Drawing.Size(84, 21);
            this.SurfaceMaterialLaminateOption.TabIndex = 4;
            this.SurfaceMaterialLaminateOption.TabStop = true;
            this.SurfaceMaterialLaminateOption.Text = "Laminate";
            this.SurfaceMaterialLaminateOption.UseVisualStyleBackColor = true;
            // 
            // SurfaceMaterialOakOption
            // 
            this.SurfaceMaterialOakOption.AutoSize = true;
            this.SurfaceMaterialOakOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialOakOption.Location = new System.Drawing.Point(7, 48);
            this.SurfaceMaterialOakOption.Name = "SurfaceMaterialOakOption";
            this.SurfaceMaterialOakOption.Size = new System.Drawing.Size(52, 21);
            this.SurfaceMaterialOakOption.TabIndex = 5;
            this.SurfaceMaterialOakOption.TabStop = true;
            this.SurfaceMaterialOakOption.Text = "Oak";
            this.SurfaceMaterialOakOption.UseVisualStyleBackColor = true;
            // 
            // SurfaceMaterialRosewoodOption
            // 
            this.SurfaceMaterialRosewoodOption.AutoSize = true;
            this.SurfaceMaterialRosewoodOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialRosewoodOption.Location = new System.Drawing.Point(7, 75);
            this.SurfaceMaterialRosewoodOption.Name = "SurfaceMaterialRosewoodOption";
            this.SurfaceMaterialRosewoodOption.Size = new System.Drawing.Size(92, 21);
            this.SurfaceMaterialRosewoodOption.TabIndex = 7;
            this.SurfaceMaterialRosewoodOption.TabStop = true;
            this.SurfaceMaterialRosewoodOption.Text = "Rosewood";
            this.SurfaceMaterialRosewoodOption.UseVisualStyleBackColor = true;
            // 
            // SurfaceMaterialVeneerOption
            // 
            this.SurfaceMaterialVeneerOption.AutoSize = true;
            this.SurfaceMaterialVeneerOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialVeneerOption.Location = new System.Drawing.Point(7, 102);
            this.SurfaceMaterialVeneerOption.Name = "SurfaceMaterialVeneerOption";
            this.SurfaceMaterialVeneerOption.Size = new System.Drawing.Size(72, 21);
            this.SurfaceMaterialVeneerOption.TabIndex = 8;
            this.SurfaceMaterialVeneerOption.TabStop = true;
            this.SurfaceMaterialVeneerOption.Text = "Veneer";
            this.SurfaceMaterialVeneerOption.UseVisualStyleBackColor = true;
            // 
            // SurfaceMaterialPineOption
            // 
            this.SurfaceMaterialPineOption.AutoSize = true;
            this.SurfaceMaterialPineOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurfaceMaterialPineOption.Location = new System.Drawing.Point(7, 129);
            this.SurfaceMaterialPineOption.Name = "SurfaceMaterialPineOption";
            this.SurfaceMaterialPineOption.Size = new System.Drawing.Size(54, 21);
            this.SurfaceMaterialPineOption.TabIndex = 9;
            this.SurfaceMaterialPineOption.TabStop = true;
            this.SurfaceMaterialPineOption.Text = "Pine";
            this.SurfaceMaterialPineOption.UseVisualStyleBackColor = true;
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(-3, 0);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(141, 18);
            this.RushOrderLabel.TabIndex = 0;
            this.RushOrderLabel.Text = "Rush Order Options";
            // 
            // RushOrderNoneOption
            // 
            this.RushOrderNoneOption.AutoSize = true;
            this.RushOrderNoneOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderNoneOption.Location = new System.Drawing.Point(7, 102);
            this.RushOrderNoneOption.Name = "RushOrderNoneOption";
            this.RushOrderNoneOption.Size = new System.Drawing.Size(126, 21);
            this.RushOrderNoneOption.TabIndex = 13;
            this.RushOrderNoneOption.TabStop = true;
            this.RushOrderNoneOption.Text = "None (14 Days)";
            this.RushOrderNoneOption.UseVisualStyleBackColor = true;
            // 
            // RushOrder3DaysOption
            // 
            this.RushOrder3DaysOption.AutoSize = true;
            this.RushOrder3DaysOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder3DaysOption.Location = new System.Drawing.Point(7, 21);
            this.RushOrder3DaysOption.Name = "RushOrder3DaysOption";
            this.RushOrder3DaysOption.Size = new System.Drawing.Size(70, 21);
            this.RushOrder3DaysOption.TabIndex = 10;
            this.RushOrder3DaysOption.TabStop = true;
            this.RushOrder3DaysOption.Text = "3 Days";
            this.RushOrder3DaysOption.UseVisualStyleBackColor = true;
            // 
            // RushOrder5DaysOption
            // 
            this.RushOrder5DaysOption.AutoSize = true;
            this.RushOrder5DaysOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder5DaysOption.Location = new System.Drawing.Point(7, 48);
            this.RushOrder5DaysOption.Name = "RushOrder5DaysOption";
            this.RushOrder5DaysOption.Size = new System.Drawing.Size(70, 21);
            this.RushOrder5DaysOption.TabIndex = 11;
            this.RushOrder5DaysOption.TabStop = true;
            this.RushOrder5DaysOption.Text = "5 Days";
            this.RushOrder5DaysOption.UseVisualStyleBackColor = true;
            // 
            // RushOrder7DaysOption
            // 
            this.RushOrder7DaysOption.AutoSize = true;
            this.RushOrder7DaysOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrder7DaysOption.Location = new System.Drawing.Point(7, 75);
            this.RushOrder7DaysOption.Name = "RushOrder7DaysOption";
            this.RushOrder7DaysOption.Size = new System.Drawing.Size(70, 21);
            this.RushOrder7DaysOption.TabIndex = 12;
            this.RushOrder7DaysOption.TabStop = true;
            this.RushOrder7DaysOption.Text = "7 Days";
            this.RushOrder7DaysOption.UseVisualStyleBackColor = true;
            // 
            // SaveQuoteButton
            // 
            this.SaveQuoteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveQuoteButton.Location = new System.Drawing.Point(225, 459);
            this.SaveQuoteButton.Name = "SaveQuoteButton";
            this.SaveQuoteButton.Size = new System.Drawing.Size(140, 40);
            this.SaveQuoteButton.TabIndex = 14;
            this.SaveQuoteButton.Text = "Save Quote";
            this.SaveQuoteButton.UseMnemonic = false;
            this.SaveQuoteButton.UseVisualStyleBackColor = true;
            this.SaveQuoteButton.Click += new System.EventHandler(this.SaveQuoteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quote Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "$0.00";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeskSizeDepthLabel);
            this.panel1.Controls.Add(this.DeskSizeWidthLabel);
            this.panel1.Controls.Add(this.DeskSizeWidthInput);
            this.panel1.Controls.Add(this.DeskSizeLabel);
            this.panel1.Controls.Add(this.DeskSizeDepthInput);
            this.panel1.Location = new System.Drawing.Point(17, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 86);
            this.panel1.TabIndex = 29;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SurfaceMaterialPineOption);
            this.panel2.Controls.Add(this.SurfaceMaterialLabel);
            this.panel2.Controls.Add(this.SurfaceMaterialVeneerOption);
            this.panel2.Controls.Add(this.SurfaceMaterialLaminateOption);
            this.panel2.Controls.Add(this.SurfaceMaterialRosewoodOption);
            this.panel2.Controls.Add(this.SurfaceMaterialOakOption);
            this.panel2.Location = new System.Drawing.Point(17, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 162);
            this.panel2.TabIndex = 30;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RushOrderNoneOption);
            this.panel3.Controls.Add(this.RushOrder7DaysOption);
            this.panel3.Controls.Add(this.RushOrderLabel);
            this.panel3.Controls.Add(this.RushOrder5DaysOption);
            this.panel3.Controls.Add(this.RushOrder3DaysOption);
            this.panel3.Location = new System.Drawing.Point(17, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 134);
            this.panel3.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(225, 429);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 27);
            this.panel4.TabIndex = 32;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 511);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveQuoteButton);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameInput);
            this.Controls.Add(this.NumberOfDrawersInput);
            this.Controls.Add(this.NumberOfDrawersLabel);
            this.Controls.Add(this.AddQuoteTitleLabel);
            this.Controls.Add(this.cancelAddQuote);
            this.Name = "AddQuote";
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeskSizeWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeskSizeDepthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfDrawersInput)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelAddQuote;
        private System.Windows.Forms.Label AddQuoteTitleLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.NumericUpDown DeskSizeWidthInput;
        private System.Windows.Forms.Label DeskSizeDepthLabel;
        private System.Windows.Forms.Label DeskSizeWidthLabel;
        private System.Windows.Forms.NumericUpDown DeskSizeDepthInput;
        private System.Windows.Forms.Label NumberOfDrawersLabel;
        private System.Windows.Forms.Label DeskSizeLabel;
        private System.Windows.Forms.NumericUpDown NumberOfDrawersInput;
        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.Label SurfaceMaterialLabel;
        private System.Windows.Forms.RadioButton SurfaceMaterialPineOption;
        private System.Windows.Forms.RadioButton SurfaceMaterialVeneerOption;
        private System.Windows.Forms.RadioButton SurfaceMaterialRosewoodOption;
        private System.Windows.Forms.RadioButton SurfaceMaterialOakOption;
        private System.Windows.Forms.RadioButton SurfaceMaterialLaminateOption;
        private System.Windows.Forms.RadioButton RushOrder7DaysOption;
        private System.Windows.Forms.RadioButton RushOrder5DaysOption;
        private System.Windows.Forms.RadioButton RushOrder3DaysOption;
        private System.Windows.Forms.RadioButton RushOrderNoneOption;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.Button SaveQuoteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}