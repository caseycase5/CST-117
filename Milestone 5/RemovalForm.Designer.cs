namespace Milestone_4
{
    partial class RemovalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.removalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Item ID to Remove:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(16, 30);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // removalButton
            // 
            this.removalButton.Location = new System.Drawing.Point(16, 67);
            this.removalButton.Name = "removalButton";
            this.removalButton.Size = new System.Drawing.Size(99, 23);
            this.removalButton.TabIndex = 2;
            this.removalButton.Text = "Remove Item";
            this.removalButton.UseVisualStyleBackColor = true;
            this.removalButton.Click += new System.EventHandler(this.removalButton_Click);
            // 
            // RemovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(212, 106);
            this.Controls.Add(this.removalButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "RemovalForm";
            this.Text = "Remove Item";
            this.Load += new System.EventHandler(this.RemovalForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button removalButton;
    }
}