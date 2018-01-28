namespace MegaDesk_3_TylerBrown
{
    partial class DisplayQuote
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
            this.DisplayQuoteTitleLabel = new System.Windows.Forms.Label();
            this.ReturnToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DisplayQuoteTitleLabel
            // 
            this.DisplayQuoteTitleLabel.AutoSize = true;
            this.DisplayQuoteTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayQuoteTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.DisplayQuoteTitleLabel.Name = "DisplayQuoteTitleLabel";
            this.DisplayQuoteTitleLabel.Size = new System.Drawing.Size(202, 26);
            this.DisplayQuoteTitleLabel.TabIndex = 1;
            this.DisplayQuoteTitleLabel.Text = "Review Your Quote";
            // 
            // ReturnToMainMenuButton
            // 
            this.ReturnToMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMainMenuButton.Location = new System.Drawing.Point(268, 270);
            this.ReturnToMainMenuButton.Name = "ReturnToMainMenuButton";
            this.ReturnToMainMenuButton.Size = new System.Drawing.Size(140, 40);
            this.ReturnToMainMenuButton.TabIndex = 16;
            this.ReturnToMainMenuButton.Text = "Done";
            this.ReturnToMainMenuButton.UseMnemonic = false;
            this.ReturnToMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMainMenuButton.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 322);
            this.Controls.Add(this.ReturnToMainMenuButton);
            this.Controls.Add(this.DisplayQuoteTitleLabel);
            this.Name = "DisplayQuote";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DisplayQuoteTitleLabel;
        private System.Windows.Forms.Button ReturnToMainMenuButton;
    }
}