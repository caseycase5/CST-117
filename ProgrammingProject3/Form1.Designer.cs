namespace ProgrammingProject3
{
    partial class Form
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.finalText = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input File Name:";
            // 
            // userInput
            // 
            this.userInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userInput.Location = new System.Drawing.Point(145, 12);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(275, 23);
            this.userInput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Read File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalText
            // 
            this.finalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.finalText.FormattingEnabled = true;
            this.finalText.ItemHeight = 16;
            this.finalText.Location = new System.Drawing.Point(17, 147);
            this.finalText.Name = "finalText";
            this.finalText.Size = new System.Drawing.Size(555, 292);
            this.finalText.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 455);
            this.Controls.Add(this.finalText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Read/Write Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox finalText;
    }
}

