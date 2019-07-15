namespace Milestone1
{
    partial class InventoryForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDataViewer = new System.Windows.Forms.DataGridView();
            this.item_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemId_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addItemButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(469, 28);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.newToolStripMenuItem.Text = "New";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editItemToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.editItemToolStripMenuItem.Text = "Edit Item";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemPropertiesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // itemPropertiesToolStripMenuItem
            // 
            this.itemPropertiesToolStripMenuItem.Name = "itemPropertiesToolStripMenuItem";
            this.itemPropertiesToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.itemPropertiesToolStripMenuItem.Text = "Item Properties";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutInventoryToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutInventoryToolStripMenuItem
            // 
            this.aboutInventoryToolStripMenuItem.Name = "aboutInventoryToolStripMenuItem";
            this.aboutInventoryToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.aboutInventoryToolStripMenuItem.Text = "About Inventory";
            // 
            // itemDataViewer
            // 
            this.itemDataViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_Name_Column,
            this.category_Column,
            this.qty_Column,
            this.itemId_Column});
            this.itemDataViewer.Location = new System.Drawing.Point(12, 31);
            this.itemDataViewer.Name = "itemDataViewer";
            this.itemDataViewer.RowTemplate.Height = 24;
            this.itemDataViewer.Size = new System.Drawing.Size(443, 410);
            this.itemDataViewer.TabIndex = 1;
            this.itemDataViewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // item_Name_Column
            // 
            this.item_Name_Column.HeaderText = "Item Name";
            this.item_Name_Column.Name = "item_Name_Column";
            // 
            // category_Column
            // 
            this.category_Column.HeaderText = "Category";
            this.category_Column.Name = "category_Column";
            // 
            // qty_Column
            // 
            this.qty_Column.HeaderText = "QTY";
            this.qty_Column.Name = "qty_Column";
            // 
            // itemId_Column
            // 
            this.itemId_Column.HeaderText = "Item ID";
            this.itemId_Column.Name = "itemId_Column";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(12, 447);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(112, 37);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add New Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(172, 449);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(131, 35);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Reorder Selected";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(347, 449);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(108, 35);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 495);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemDataViewer);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "InventoryForm";
            this.Text = "Inventory";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutInventoryToolStripMenuItem;
        private System.Windows.Forms.DataGridView itemDataViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn category_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemId_Column;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button searchButton;
    }
}

