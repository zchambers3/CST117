namespace CST_117_Week_1_Assignment_3_and_Beyond
{
    partial class Form1
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
            this.earthWeightLabel = new System.Windows.Forms.Label();
            this.earthWeightTextBox = new System.Windows.Forms.TextBox();
            this.marsWeightLabel = new System.Windows.Forms.Label();
            this.marsWeightTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // earthWeightLabel
            // 
            this.earthWeightLabel.AutoSize = true;
            this.earthWeightLabel.Location = new System.Drawing.Point(13, 17);
            this.earthWeightLabel.Name = "earthWeightLabel";
            this.earthWeightLabel.Size = new System.Drawing.Size(141, 13);
            this.earthWeightLabel.TabIndex = 0;
            this.earthWeightLabel.Text = "Enter your weight on Earth : ";
            // 
            // earthWeightTextBox
            // 
            this.earthWeightTextBox.Location = new System.Drawing.Point(161, 13);
            this.earthWeightTextBox.Name = "earthWeightTextBox";
            this.earthWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.earthWeightTextBox.TabIndex = 1;
            // 
            // marsWeightLabel
            // 
            this.marsWeightLabel.AutoSize = true;
            this.marsWeightLabel.Location = new System.Drawing.Point(16, 49);
            this.marsWeightLabel.Name = "marsWeightLabel";
            this.marsWeightLabel.Size = new System.Drawing.Size(116, 13);
            this.marsWeightLabel.TabIndex = 2;
            this.marsWeightLabel.Text = "Your Weight on Mars : ";
            // 
            // marsWeightTextBox
            // 
            this.marsWeightTextBox.Location = new System.Drawing.Point(161, 49);
            this.marsWeightTextBox.Name = "marsWeightTextBox";
            this.marsWeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.marsWeightTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(161, 90);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 121);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.marsWeightTextBox);
            this.Controls.Add(this.marsWeightLabel);
            this.Controls.Add(this.earthWeightTextBox);
            this.Controls.Add(this.earthWeightLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earthWeightLabel;
        private System.Windows.Forms.TextBox earthWeightTextBox;
        private System.Windows.Forms.Label marsWeightLabel;
        private System.Windows.Forms.TextBox marsWeightTextBox;
        private System.Windows.Forms.Button convertButton;
    }
}

