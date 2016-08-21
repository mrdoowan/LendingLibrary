namespace LendingLibrary
{
	partial class CheckOut
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox_NameFirst = new System.Windows.Forms.TextBox();
			this.textBox_NameLast = new System.Windows.Forms.TextBox();
			this.textBox_UMID = new System.Windows.Forms.TextBox();
			this.textBox_Uniq = new System.Windows.Forms.TextBox();
			this.textBox_ItemDesc = new System.Windows.Forms.TextBox();
			this.textBox_StaffOut = new System.Windows.Forms.TextBox();
			this.comboBox_ItemCat = new System.Windows.Forms.ComboBox();
			this.button_CheckOut = new System.Windows.Forms.Button();
			this.numericUpDown_Month = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.numericUpDown_Day = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown_Year = new System.Windows.Forms.NumericUpDown();
			this.label10 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Month)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Day)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name (First):";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name (Last):";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 89);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "UMID:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(123, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Uniqname:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(12, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 19);
			this.label5.TabIndex = 4;
			this.label5.Text = "Item Category:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(12, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(123, 19);
			this.label6.TabIndex = 5;
			this.label6.Text = "Item Description:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(12, 249);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(123, 19);
			this.label7.TabIndex = 6;
			this.label7.Text = "Due Date:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(12, 289);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(123, 19);
			this.label8.TabIndex = 7;
			this.label8.Text = "Staff Out:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_NameFirst
			// 
			this.textBox_NameFirst.Location = new System.Drawing.Point(141, 7);
			this.textBox_NameFirst.Name = "textBox_NameFirst";
			this.textBox_NameFirst.Size = new System.Drawing.Size(281, 23);
			this.textBox_NameFirst.TabIndex = 8;
			this.textBox_NameFirst.TextChanged += new System.EventHandler(this.textBox_NameFirst_TextChanged);
			// 
			// textBox_NameLast
			// 
			this.textBox_NameLast.Location = new System.Drawing.Point(141, 47);
			this.textBox_NameLast.Name = "textBox_NameLast";
			this.textBox_NameLast.Size = new System.Drawing.Size(281, 23);
			this.textBox_NameLast.TabIndex = 9;
			this.textBox_NameLast.TextChanged += new System.EventHandler(this.textBox_NameLast_TextChanged);
			// 
			// textBox_UMID
			// 
			this.textBox_UMID.Location = new System.Drawing.Point(141, 87);
			this.textBox_UMID.Name = "textBox_UMID";
			this.textBox_UMID.Size = new System.Drawing.Size(281, 23);
			this.textBox_UMID.TabIndex = 10;
			this.textBox_UMID.TextChanged += new System.EventHandler(this.textBox_UMID_TextChanged);
			// 
			// textBox_Uniq
			// 
			this.textBox_Uniq.Location = new System.Drawing.Point(141, 127);
			this.textBox_Uniq.Name = "textBox_Uniq";
			this.textBox_Uniq.Size = new System.Drawing.Size(281, 23);
			this.textBox_Uniq.TabIndex = 11;
			this.textBox_Uniq.TextChanged += new System.EventHandler(this.textBox_Uniq_TextChanged);
			// 
			// textBox_ItemDesc
			// 
			this.textBox_ItemDesc.Location = new System.Drawing.Point(141, 207);
			this.textBox_ItemDesc.Name = "textBox_ItemDesc";
			this.textBox_ItemDesc.Size = new System.Drawing.Size(281, 23);
			this.textBox_ItemDesc.TabIndex = 12;
			// 
			// textBox_StaffOut
			// 
			this.textBox_StaffOut.Location = new System.Drawing.Point(141, 287);
			this.textBox_StaffOut.Name = "textBox_StaffOut";
			this.textBox_StaffOut.Size = new System.Drawing.Size(281, 23);
			this.textBox_StaffOut.TabIndex = 14;
			this.textBox_StaffOut.TextChanged += new System.EventHandler(this.textBox_StaffOut_TextChanged);
			// 
			// comboBox_ItemCat
			// 
			this.comboBox_ItemCat.FormattingEnabled = true;
			this.comboBox_ItemCat.Items.AddRange(new object[] {
            "Blue Apple Key",
            "DVD",
            "Board Games / Cards",
            "Household Items",
            "Ping Pong Equipment",
            "Pool Equipment",
            "Sports Equipment",
            "Vacuum",
            "Video Games",
            "Miscellaneous (provide Item Description)"});
			this.comboBox_ItemCat.Location = new System.Drawing.Point(141, 167);
			this.comboBox_ItemCat.Name = "comboBox_ItemCat";
			this.comboBox_ItemCat.Size = new System.Drawing.Size(281, 24);
			this.comboBox_ItemCat.TabIndex = 15;
			this.comboBox_ItemCat.SelectedIndexChanged += new System.EventHandler(this.comboBox_ItemCat_SelectedIndexChanged);
			// 
			// button_CheckOut
			// 
			this.button_CheckOut.Location = new System.Drawing.Point(317, 319);
			this.button_CheckOut.Name = "button_CheckOut";
			this.button_CheckOut.Size = new System.Drawing.Size(105, 23);
			this.button_CheckOut.TabIndex = 16;
			this.button_CheckOut.Text = "Check Out";
			this.button_CheckOut.UseVisualStyleBackColor = true;
			this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
			// 
			// numericUpDown_Month
			// 
			this.numericUpDown_Month.Location = new System.Drawing.Point(141, 248);
			this.numericUpDown_Month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
			this.numericUpDown_Month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_Month.Name = "numericUpDown_Month";
			this.numericUpDown_Month.Size = new System.Drawing.Size(37, 23);
			this.numericUpDown_Month.TabIndex = 17;
			this.numericUpDown_Month.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_Month.ValueChanged += new System.EventHandler(this.numericUpDown_Month_ValueChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(184, 249);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(10, 19);
			this.label9.TabIndex = 18;
			this.label9.Text = "/";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// numericUpDown_Day
			// 
			this.numericUpDown_Day.Location = new System.Drawing.Point(200, 248);
			this.numericUpDown_Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
			this.numericUpDown_Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_Day.Name = "numericUpDown_Day";
			this.numericUpDown_Day.Size = new System.Drawing.Size(37, 23);
			this.numericUpDown_Day.TabIndex = 19;
			this.numericUpDown_Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown_Day.ValueChanged += new System.EventHandler(this.numericUpDown_Day_ValueChanged);
			// 
			// numericUpDown_Year
			// 
			this.numericUpDown_Year.Location = new System.Drawing.Point(259, 248);
			this.numericUpDown_Year.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
			this.numericUpDown_Year.Name = "numericUpDown_Year";
			this.numericUpDown_Year.Size = new System.Drawing.Size(55, 23);
			this.numericUpDown_Year.TabIndex = 21;
			this.numericUpDown_Year.Value = new decimal(new int[] {
            2016,
            0,
            0,
            0});
			this.numericUpDown_Year.ValueChanged += new System.EventHandler(this.numericUpDown_Year_ValueChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(243, 249);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(10, 19);
			this.label10.TabIndex = 20;
			this.label10.Text = "/";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CheckOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 354);
			this.Controls.Add(this.numericUpDown_Year);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.numericUpDown_Day);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.numericUpDown_Month);
			this.Controls.Add(this.button_CheckOut);
			this.Controls.Add(this.comboBox_ItemCat);
			this.Controls.Add(this.textBox_StaffOut);
			this.Controls.Add(this.textBox_ItemDesc);
			this.Controls.Add(this.textBox_Uniq);
			this.Controls.Add(this.textBox_UMID);
			this.Controls.Add(this.textBox_NameLast);
			this.Controls.Add(this.textBox_NameFirst);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "CheckOut";
			this.Text = "Check Out Item";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Month)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Day)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Year)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox_NameFirst;
		private System.Windows.Forms.TextBox textBox_NameLast;
		private System.Windows.Forms.TextBox textBox_UMID;
		private System.Windows.Forms.TextBox textBox_Uniq;
		private System.Windows.Forms.TextBox textBox_ItemDesc;
		private System.Windows.Forms.TextBox textBox_StaffOut;
		private System.Windows.Forms.ComboBox comboBox_ItemCat;
		private System.Windows.Forms.Button button_CheckOut;
		private System.Windows.Forms.NumericUpDown numericUpDown_Month;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown numericUpDown_Day;
		private System.Windows.Forms.NumericUpDown numericUpDown_Year;
		private System.Windows.Forms.Label label10;
	}
}