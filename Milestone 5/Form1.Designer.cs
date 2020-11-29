namespace Milestone_4
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
            this.idLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListView();
            this.restockButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idLabel.Location = new System.Drawing.Point(19, 19);
            this.idLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(73, 20);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "Enter ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(19, 49);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(98, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Enter Name:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceLabel.Location = new System.Drawing.Point(19, 79);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(91, 20);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Enter Price:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.quantityLabel.Location = new System.Drawing.Point(19, 109);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(115, 20);
            this.quantityLabel.TabIndex = 3;
            this.quantityLabel.Text = "Enter Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quantityTextBox.Location = new System.Drawing.Point(154, 106);
            this.quantityTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(155, 23);
            this.quantityTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.priceTextBox.Location = new System.Drawing.Point(154, 76);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(155, 23);
            this.priceTextBox.TabIndex = 5;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nameTextBox.Location = new System.Drawing.Point(154, 46);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 23);
            this.nameTextBox.TabIndex = 6;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.idTextBox.Location = new System.Drawing.Point(154, 16);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(155, 23);
            this.idTextBox.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Gainsboro;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.addButton.Location = new System.Drawing.Point(322, 46);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 53);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "ADD ITEM";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // itemList
            // 
            this.itemList.HideSelection = false;
            this.itemList.Location = new System.Drawing.Point(23, 149);
            this.itemList.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(422, 225);
            this.itemList.TabIndex = 9;
            this.itemList.UseCompatibleStateImageBehavior = false;
            this.itemList.View = System.Windows.Forms.View.List;
            // 
            // restockButton
            // 
            this.restockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.restockButton.Location = new System.Drawing.Point(23, 387);
            this.restockButton.Margin = new System.Windows.Forms.Padding(10);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(130, 25);
            this.restockButton.TabIndex = 10;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.restockButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.removeButton.Location = new System.Drawing.Point(315, 387);
            this.removeButton.Margin = new System.Windows.Forms.Padding(10);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(130, 25);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search.Location = new System.Drawing.Point(173, 387);
            this.Search.Margin = new System.Windows.Forms.Padding(10);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(130, 25);
            this.Search.TabIndex = 14;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.saveButton.Location = new System.Drawing.Point(173, 423);
            this.saveButton.Margin = new System.Windows.Forms.Padding(10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(130, 25);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save To File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(472, 457);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "InventoryForm";
            this.Text = "Item Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListView itemList;
        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button saveButton;
    }
}

