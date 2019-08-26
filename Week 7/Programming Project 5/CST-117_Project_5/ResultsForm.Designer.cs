namespace CST_117_Project_5
{
    partial class ResultsForm
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
            this.luckyLabel = new System.Windows.Forms.Label();
            this.yourLuckLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // luckyLabel
            // 
            this.luckyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luckyLabel.Location = new System.Drawing.Point(24, 101);
            this.luckyLabel.Name = "luckyLabel";
            this.luckyLabel.Size = new System.Drawing.Size(197, 61);
            this.luckyLabel.TabIndex = 0;
            this.luckyLabel.Text = "Lucky#";
            this.luckyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yourLuckLabel
            // 
            this.yourLuckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourLuckLabel.Location = new System.Drawing.Point(12, 9);
            this.yourLuckLabel.Name = "yourLuckLabel";
            this.yourLuckLabel.Size = new System.Drawing.Size(231, 92);
            this.yourLuckLabel.TabIndex = 1;
            this.yourLuckLabel.Text = "Your Luck number is...";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(85, 175);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 223);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.yourLuckLabel);
            this.Controls.Add(this.luckyLabel);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label luckyLabel;
        public System.Windows.Forms.Label yourLuckLabel;
        private System.Windows.Forms.Button closeButton;
    }
}