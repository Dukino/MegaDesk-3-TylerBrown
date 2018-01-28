namespace MegaDesk_3_TylerBrown
{
    partial class SearchQuotes
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
            this.ReturnToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReturnToMainMenuButton
            // 
            this.ReturnToMainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnToMainMenuButton.Location = new System.Drawing.Point(132, 209);
            this.ReturnToMainMenuButton.Name = "ReturnToMainMenuButton";
            this.ReturnToMainMenuButton.Size = new System.Drawing.Size(140, 40);
            this.ReturnToMainMenuButton.TabIndex = 18;
            this.ReturnToMainMenuButton.Text = "Done";
            this.ReturnToMainMenuButton.UseMnemonic = false;
            this.ReturnToMainMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMainMenuButton.Click += new System.EventHandler(this.ReturnToMainMenuButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ReturnToMainMenuButton);
            this.Name = "SearchQuotes";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMainMenuButton;
    }
}