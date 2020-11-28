namespace Programming_Project_5
{
    partial class inputForm
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
            this.labelBirthYear = new System.Windows.Forms.Label();
            this.labelMonth = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxDay = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBirthYear
            // 
            this.labelBirthYear.AutoSize = true;
            this.labelBirthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelBirthYear.Location = new System.Drawing.Point(12, 36);
            this.labelBirthYear.Name = "labelBirthYear";
            this.labelBirthYear.Size = new System.Drawing.Size(161, 20);
            this.labelBirthYear.TabIndex = 0;
            this.labelBirthYear.Text = "Select your birth year:";
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMonth.Location = new System.Drawing.Point(12, 74);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(176, 20);
            this.labelMonth.TabIndex = 1;
            this.labelMonth.Text = "Select your birth month:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDay.Location = new System.Drawing.Point(12, 110);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(163, 20);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Select your birth date:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelColor.Location = new System.Drawing.Point(12, 145);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(186, 20);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Select your favorite color:";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010"});
            this.comboBoxYear.Location = new System.Drawing.Point(204, 35);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(121, 21);
            this.comboBoxYear.TabIndex = 4;
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(204, 76);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMonth.TabIndex = 5;
            // 
            // comboBoxDay
            // 
            this.comboBoxDay.FormattingEnabled = true;
            this.comboBoxDay.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDay.Location = new System.Drawing.Point(204, 109);
            this.comboBoxDay.Name = "comboBoxDay";
            this.comboBoxDay.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDay.TabIndex = 6;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Yellow",
            "Red",
            "Purple",
            "Orange",
            "Black",
            "White"});
            this.comboBoxColor.Location = new System.Drawing.Point(204, 147);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxColor.TabIndex = 7;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.submitButton.Location = new System.Drawing.Point(25, 187);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(300, 60);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "FIND YOUR LUCKY NUMBER!!!";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(219, 271);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(106, 23);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "RESET FORM";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(358, 306);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxDay);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.labelBirthYear);
            this.Name = "inputForm";
            this.Text = "Lucky Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBirthYear;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.ComboBox comboBoxDay;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

