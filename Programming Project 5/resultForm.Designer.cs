namespace Programming_Project_5
{
    partial class resultForm
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
            this.luckyNumberLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // luckyNumberLabel
            // 
            this.luckyNumberLabel.AutoSize = true;
            this.luckyNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.luckyNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.luckyNumberLabel.ForeColor = System.Drawing.Color.Red;
            this.luckyNumberLabel.Location = new System.Drawing.Point(125, 148);
            this.luckyNumberLabel.Name = "luckyNumberLabel";
            this.luckyNumberLabel.Size = new System.Drawing.Size(75, 54);
            this.luckyNumberLabel.TabIndex = 0;
            this.luckyNumberLabel.Text = "99";
            this.luckyNumberLabel.Click += new System.EventHandler(this.luckyNumberLabel_Click);
            // 
            // resultsLabel
            // 
            this.resultsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.resultsLabel.ForeColor = System.Drawing.Color.Red;
            this.resultsLabel.Location = new System.Drawing.Point(12, 9);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(309, 95);
            this.resultsLabel.TabIndex = 1;
            this.resultsLabel.Text = "YOUR LUCKY NUMBER IS:";
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(309, 211);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.luckyNumberLabel);
            this.Name = "resultForm";
            this.Text = "Your Results!";
            this.Load += new System.EventHandler(this.resultForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label luckyNumberLabel;
        private System.Windows.Forms.Label resultsLabel;
    }
}