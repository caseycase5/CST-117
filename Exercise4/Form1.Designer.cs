namespace Exercise4
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
			this.titleLabel = new System.Windows.Forms.Label();
			this.userEntryBox = new System.Windows.Forms.TextBox();
			this.secondsLabel = new System.Windows.Forms.Label();
			this.convertButton = new System.Windows.Forms.Button();
			this.conversionBox = new System.Windows.Forms.TextBox();
			this.conversionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.titleLabel.Location = new System.Drawing.Point(114, 20);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(172, 24);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Seconds Converter";
			this.titleLabel.Click += new System.EventHandler(this.label1_Click);
			// 
			// userEntryBox
			// 
			this.userEntryBox.Location = new System.Drawing.Point(118, 82);
			this.userEntryBox.Name = "userEntryBox";
			this.userEntryBox.Size = new System.Drawing.Size(152, 20);
			this.userEntryBox.TabIndex = 1;
			this.userEntryBox.TextChanged += new System.EventHandler(this.userEntryBox_TextChanged);
			// 
			// secondsLabel
			// 
			this.secondsLabel.AutoSize = true;
			this.secondsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.secondsLabel.Location = new System.Drawing.Point(12, 82);
			this.secondsLabel.Name = "secondsLabel";
			this.secondsLabel.Size = new System.Drawing.Size(105, 17);
			this.secondsLabel.TabIndex = 2;
			this.secondsLabel.Text = "Enter Seconds:";
			this.secondsLabel.Click += new System.EventHandler(this.label2_Click);
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(118, 142);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(75, 23);
			this.convertButton.TabIndex = 3;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// conversionBox
			// 
			this.conversionBox.Location = new System.Drawing.Point(118, 205);
			this.conversionBox.Name = "conversionBox";
			this.conversionBox.ReadOnly = true;
			this.conversionBox.Size = new System.Drawing.Size(100, 20);
			this.conversionBox.TabIndex = 4;
			// 
			// conversionLabel
			// 
			this.conversionLabel.AutoSize = true;
			this.conversionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.conversionLabel.Location = new System.Drawing.Point(29, 208);
			this.conversionLabel.Name = "conversionLabel";
			this.conversionLabel.Size = new System.Drawing.Size(83, 17);
			this.conversionLabel.TabIndex = 5;
			this.conversionLabel.Text = "Conversion:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.conversionLabel);
			this.Controls.Add(this.conversionBox);
			this.Controls.Add(this.convertButton);
			this.Controls.Add(this.secondsLabel);
			this.Controls.Add(this.userEntryBox);
			this.Controls.Add(this.titleLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.TextBox userEntryBox;
		private System.Windows.Forms.Label secondsLabel;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.TextBox conversionBox;
		private System.Windows.Forms.Label conversionLabel;
	}
}

