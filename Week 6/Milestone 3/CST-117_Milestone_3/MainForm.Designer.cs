namespace CST_117_Milestone_3
{
    partial class MainForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantTextBox = new System.Windows.Forms.TextBox();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.itemListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.priceUpdateTextBox = new System.Windows.Forms.TextBox();
            this.quantUpdateTextBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.prodLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addGroupBox.SuspendLayout();
            this.productGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(58, 136);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.priceTextBox);
            this.addGroupBox.Controls.Add(this.quantTextBox);
            this.addGroupBox.Controls.Add(this.productTextBox);
            this.addGroupBox.Controls.Add(this.nameTextBox);
            this.addGroupBox.Controls.Add(this.label3);
            this.addGroupBox.Controls.Add(this.addButton);
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.label1);
            this.addGroupBox.Controls.Add(this.itemNameLabel);
            this.addGroupBox.Location = new System.Drawing.Point(12, 12);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(200, 173);
            this.addGroupBox.TabIndex = 1;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add Items";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(82, 104);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 7;
            // 
            // quantTextBox
            // 
            this.quantTextBox.Location = new System.Drawing.Point(82, 77);
            this.quantTextBox.Name = "quantTextBox";
            this.quantTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantTextBox.TabIndex = 6;
            // 
            // productTextBox
            // 
            this.productTextBox.Location = new System.Drawing.Point(82, 50);
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.Size = new System.Drawing.Size(100, 20);
            this.productTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(82, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID:";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(29, 25);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(38, 13);
            this.itemNameLabel.TabIndex = 0;
            this.itemNameLabel.Text = "Name:";
            // 
            // productGroupBox
            // 
            this.productGroupBox.Controls.Add(this.label4);
            this.productGroupBox.Controls.Add(this.searchButton);
            this.productGroupBox.Controls.Add(this.searchTextBox);
            this.productGroupBox.Controls.Add(this.itemListBox);
            this.productGroupBox.Location = new System.Drawing.Point(229, 12);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(200, 173);
            this.productGroupBox.TabIndex = 2;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Name or Product ID:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(119, 142);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(21, 146);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(91, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // itemListBox
            // 
            this.itemListBox.FormattingEnabled = true;
            this.itemListBox.Location = new System.Drawing.Point(40, 22);
            this.itemListBox.Name = "itemListBox";
            this.itemListBox.Size = new System.Drawing.Size(120, 95);
            this.itemListBox.TabIndex = 0;
            this.itemListBox.SelectedIndexChanged += new System.EventHandler(this.itemListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.priceUpdateTextBox);
            this.groupBox2.Controls.Add(this.quantUpdateTextBox);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.prodLabel);
            this.groupBox2.Controls.Add(this.nameLabel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.removeButton);
            this.groupBox2.Location = new System.Drawing.Point(447, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 173);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected Item";
            // 
            // priceUpdateTextBox
            // 
            this.priceUpdateTextBox.Location = new System.Drawing.Point(77, 104);
            this.priceUpdateTextBox.Name = "priceUpdateTextBox";
            this.priceUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceUpdateTextBox.TabIndex = 14;
            // 
            // quantUpdateTextBox
            // 
            this.quantUpdateTextBox.Location = new System.Drawing.Point(77, 78);
            this.quantUpdateTextBox.Name = "quantUpdateTextBox";
            this.quantUpdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantUpdateTextBox.TabIndex = 13;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(18, 136);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 12;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // prodLabel
            // 
            this.prodLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prodLabel.Location = new System.Drawing.Point(77, 50);
            this.prodLabel.Name = "prodLabel";
            this.prodLabel.Size = new System.Drawing.Size(100, 20);
            this.prodLabel.TabIndex = 9;
            this.prodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Location = new System.Drawing.Point(77, 24);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 20);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Product ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Name:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(105, 136);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 0;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(572, 201);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 236);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.productGroupBox);
            this.Controls.Add(this.addGroupBox);
            this.Name = "MainForm";
            this.Text = "Product Inventory";
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quantTextBox;
        private System.Windows.Forms.TextBox productTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ListBox itemListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label prodLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox priceUpdateTextBox;
        private System.Windows.Forms.TextBox quantUpdateTextBox;
        private System.Windows.Forms.Button updateButton;
    }
}

