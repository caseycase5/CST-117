namespace Milestone_4
{
    partial class SearchForm
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
            this.idSearchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameSearchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID to Search For:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(16, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // idSearchButton
            // 
            this.idSearchButton.Location = new System.Drawing.Point(16, 61);
            this.idSearchButton.Name = "idSearchButton";
            this.idSearchButton.Size = new System.Drawing.Size(100, 23);
            this.idSearchButton.TabIndex = 2;
            this.idSearchButton.Text = "Search";
            this.idSearchButton.UseVisualStyleBackColor = true;
            this.idSearchButton.Click += new System.EventHandler(this.idSearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Name to Search For:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // nameSearchButton
            // 
            this.nameSearchButton.Location = new System.Drawing.Point(16, 152);
            this.nameSearchButton.Name = "nameSearchButton";
            this.nameSearchButton.Size = new System.Drawing.Size(100, 23);
            this.nameSearchButton.TabIndex = 5;
            this.nameSearchButton.Text = "Search";
            this.nameSearchButton.UseVisualStyleBackColor = true;
            this.nameSearchButton.Click += new System.EventHandler(this.nameSearchButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(244, 206);
            this.Controls.Add(this.nameSearchButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idSearchButton);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button idSearchButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nameSearchButton;
    }
}