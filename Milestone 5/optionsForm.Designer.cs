namespace Milestone_4
{
    partial class RestockForm
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
            this.restockButton = new System.Windows.Forms.Button();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.restockLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(31, 118);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(102, 23);
            this.restockButton.TabIndex = 0;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(31, 92);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(102, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // restockLabel
            // 
            this.restockLabel.AutoSize = true;
            this.restockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.restockLabel.Location = new System.Drawing.Point(12, 62);
            this.restockLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.restockLabel.Name = "restockLabel";
            this.restockLabel.Size = new System.Drawing.Size(134, 17);
            this.restockLabel.TabIndex = 2;
            this.restockLabel.Text = "Enter New Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Item ID:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(31, 39);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(102, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // RestockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(182, 164);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.restockLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.restockButton);
            this.Name = "RestockForm";
            this.Text = "Restock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button restockButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label restockLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
    }
}