namespace Exercise05
{
    partial class ApproximatePiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproximatePiForm));
            this.enterLabel = new System.Windows.Forms.Label();
            this.numberTermsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.termsLabel = new System.Windows.Forms.Label();
            this.approximationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enterLabel
            // 
            this.enterLabel.AutoSize = true;
            this.enterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLabel.Location = new System.Drawing.Point(28, 38);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(162, 25);
            this.enterLabel.TabIndex = 0;
            this.enterLabel.Text = "Enter # of Terms:";
            // 
            // numberTermsTextBox
            // 
            this.numberTermsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTermsTextBox.Location = new System.Drawing.Point(196, 35);
            this.numberTermsTextBox.Name = "numberTermsTextBox";
            this.numberTermsTextBox.Size = new System.Drawing.Size(100, 30);
            this.numberTermsTextBox.TabIndex = 1;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(33, 101);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(157, 40);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // termsLabel
            // 
            this.termsLabel.AutoSize = true;
            this.termsLabel.Location = new System.Drawing.Point(30, 157);
            this.termsLabel.Name = "termsLabel";
            this.termsLabel.Size = new System.Drawing.Size(16, 17);
            this.termsLabel.TabIndex = 3;
            this.termsLabel.Text = "  ";
            // 
            // approximationLabel
            // 
            this.approximationLabel.AutoSize = true;
            this.approximationLabel.Location = new System.Drawing.Point(33, 192);
            this.approximationLabel.Name = "approximationLabel";
            this.approximationLabel.Size = new System.Drawing.Size(16, 17);
            this.approximationLabel.TabIndex = 4;
            this.approximationLabel.Text = "  ";
            // 
            // ApproximatePiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 238);
            this.Controls.Add(this.approximationLabel);
            this.Controls.Add(this.termsLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberTermsTextBox);
            this.Controls.Add(this.enterLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApproximatePiForm";
            this.Text = "Approximate PI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.TextBox numberTermsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label termsLabel;
        private System.Windows.Forms.Label approximationLabel;
    }
}

