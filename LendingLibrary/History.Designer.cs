namespace LendingLibrary
{
	partial class History
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.NameFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Uniqname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckInStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label_CheckOut = new System.Windows.Forms.Label();
			this.label_DueDate = new System.Windows.Forms.Label();
			this.label_StaffIn = new System.Windows.Forms.Label();
			this.label_CheckIn = new System.Windows.Forms.Label();
			this.label_ItemDesc = new System.Windows.Forms.Label();
			this.label_ItemCat = new System.Windows.Forms.Label();
			this.label_Uniq = new System.Windows.Forms.Label();
			this.label_UMID = new System.Windows.Forms.Label();
			this.label_NameLast = new System.Windows.Forms.Label();
			this.label_FirstName = new System.Windows.Forms.Label();
			this.button_ClearHistory = new System.Windows.Forms.Button();
			this.label_LastClear = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameFirst,
            this.NameLast,
            this.UMID,
            this.Uniqname,
            this.ItemCat,
            this.ItemDesc,
            this.DueDate,
            this.StaffOut,
            this.CheckInTime,
            this.CheckInStaff});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(755, 420);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// NameFirst
			// 
			this.NameFirst.HeaderText = "Name (First)";
			this.NameFirst.Name = "NameFirst";
			this.NameFirst.ReadOnly = true;
			this.NameFirst.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// NameLast
			// 
			this.NameLast.HeaderText = "Name (Last)";
			this.NameLast.Name = "NameLast";
			this.NameLast.ReadOnly = true;
			this.NameLast.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// UMID
			// 
			this.UMID.HeaderText = "UMID";
			this.UMID.Name = "UMID";
			this.UMID.ReadOnly = true;
			this.UMID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Uniqname
			// 
			this.Uniqname.HeaderText = "Uniqname";
			this.Uniqname.Name = "Uniqname";
			this.Uniqname.ReadOnly = true;
			this.Uniqname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// ItemCat
			// 
			this.ItemCat.HeaderText = "Item Category";
			this.ItemCat.Name = "ItemCat";
			this.ItemCat.ReadOnly = true;
			this.ItemCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// ItemDesc
			// 
			this.ItemDesc.HeaderText = "Item Description";
			this.ItemDesc.Name = "ItemDesc";
			this.ItemDesc.ReadOnly = true;
			this.ItemDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// DueDate
			// 
			this.DueDate.HeaderText = "Due Date";
			this.DueDate.Name = "DueDate";
			this.DueDate.ReadOnly = true;
			this.DueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// StaffOut
			// 
			this.StaffOut.HeaderText = "Staff Out";
			this.StaffOut.Name = "StaffOut";
			this.StaffOut.ReadOnly = true;
			this.StaffOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// CheckInTime
			// 
			this.CheckInTime.HeaderText = "Check-In Time";
			this.CheckInTime.Name = "CheckInTime";
			this.CheckInTime.ReadOnly = true;
			this.CheckInTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// CheckInStaff
			// 
			this.CheckInStaff.HeaderText = "Staff In";
			this.CheckInStaff.Name = "CheckInStaff";
			this.CheckInStaff.ReadOnly = true;
			this.CheckInStaff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label_CheckOut);
			this.groupBox1.Controls.Add(this.label_DueDate);
			this.groupBox1.Controls.Add(this.label_StaffIn);
			this.groupBox1.Controls.Add(this.label_CheckIn);
			this.groupBox1.Controls.Add(this.label_ItemDesc);
			this.groupBox1.Controls.Add(this.label_ItemCat);
			this.groupBox1.Controls.Add(this.label_Uniq);
			this.groupBox1.Controls.Add(this.label_UMID);
			this.groupBox1.Controls.Add(this.label_NameLast);
			this.groupBox1.Controls.Add(this.label_FirstName);
			this.groupBox1.Location = new System.Drawing.Point(12, 438);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(755, 122);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Information";
			// 
			// label_CheckOut
			// 
			this.label_CheckOut.Location = new System.Drawing.Point(376, 78);
			this.label_CheckOut.Name = "label_CheckOut";
			this.label_CheckOut.Size = new System.Drawing.Size(373, 20);
			this.label_CheckOut.TabIndex = 11;
			this.label_CheckOut.Text = "Checked Out By:";
			// 
			// label_DueDate
			// 
			this.label_DueDate.Location = new System.Drawing.Point(6, 78);
			this.label_DueDate.Name = "label_DueDate";
			this.label_DueDate.Size = new System.Drawing.Size(364, 20);
			this.label_DueDate.TabIndex = 10;
			this.label_DueDate.Text = "Due Date:";
			// 
			// label_StaffIn
			// 
			this.label_StaffIn.Location = new System.Drawing.Point(376, 98);
			this.label_StaffIn.Name = "label_StaffIn";
			this.label_StaffIn.Size = new System.Drawing.Size(373, 20);
			this.label_StaffIn.TabIndex = 9;
			this.label_StaffIn.Text = "Checked In By: ";
			// 
			// label_CheckIn
			// 
			this.label_CheckIn.Location = new System.Drawing.Point(6, 98);
			this.label_CheckIn.Name = "label_CheckIn";
			this.label_CheckIn.Size = new System.Drawing.Size(364, 20);
			this.label_CheckIn.TabIndex = 8;
			this.label_CheckIn.Text = "Check In Time: ";
			// 
			// label_ItemDesc
			// 
			this.label_ItemDesc.Location = new System.Drawing.Point(376, 38);
			this.label_ItemDesc.Name = "label_ItemDesc";
			this.label_ItemDesc.Size = new System.Drawing.Size(373, 20);
			this.label_ItemDesc.TabIndex = 5;
			this.label_ItemDesc.Text = "Item Description: ";
			// 
			// label_ItemCat
			// 
			this.label_ItemCat.Location = new System.Drawing.Point(376, 18);
			this.label_ItemCat.Name = "label_ItemCat";
			this.label_ItemCat.Size = new System.Drawing.Size(373, 20);
			this.label_ItemCat.TabIndex = 4;
			this.label_ItemCat.Text = "Item Category:";
			// 
			// label_Uniq
			// 
			this.label_Uniq.Location = new System.Drawing.Point(376, 58);
			this.label_Uniq.Name = "label_Uniq";
			this.label_Uniq.Size = new System.Drawing.Size(364, 20);
			this.label_Uniq.TabIndex = 3;
			this.label_Uniq.Text = "Uniqname: ";
			// 
			// label_UMID
			// 
			this.label_UMID.Location = new System.Drawing.Point(6, 58);
			this.label_UMID.Name = "label_UMID";
			this.label_UMID.Size = new System.Drawing.Size(364, 20);
			this.label_UMID.TabIndex = 2;
			this.label_UMID.Text = "UMID: ";
			// 
			// label_NameLast
			// 
			this.label_NameLast.Location = new System.Drawing.Point(6, 38);
			this.label_NameLast.Name = "label_NameLast";
			this.label_NameLast.Size = new System.Drawing.Size(364, 20);
			this.label_NameLast.TabIndex = 1;
			this.label_NameLast.Text = "Name (Last): ";
			// 
			// label_FirstName
			// 
			this.label_FirstName.Location = new System.Drawing.Point(6, 18);
			this.label_FirstName.Name = "label_FirstName";
			this.label_FirstName.Size = new System.Drawing.Size(364, 20);
			this.label_FirstName.TabIndex = 0;
			this.label_FirstName.Text = "Name (First): ";
			// 
			// button_ClearHistory
			// 
			this.button_ClearHistory.Location = new System.Drawing.Point(649, 566);
			this.button_ClearHistory.Name = "button_ClearHistory";
			this.button_ClearHistory.Size = new System.Drawing.Size(118, 28);
			this.button_ClearHistory.TabIndex = 4;
			this.button_ClearHistory.Text = "Clear History";
			this.button_ClearHistory.UseVisualStyleBackColor = true;
			this.button_ClearHistory.Click += new System.EventHandler(this.button_ClearHistory_Click);
			// 
			// label_LastClear
			// 
			this.label_LastClear.Location = new System.Drawing.Point(18, 570);
			this.label_LastClear.Name = "label_LastClear";
			this.label_LastClear.Size = new System.Drawing.Size(625, 20);
			this.label_LastClear.TabIndex = 10;
			this.label_LastClear.Text = "Last History Clear: None";
			// 
			// History
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(779, 599);
			this.Controls.Add(this.label_LastClear);
			this.Controls.Add(this.button_ClearHistory);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "History";
			this.Text = "Item History";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label_ItemDesc;
		private System.Windows.Forms.Label label_ItemCat;
		private System.Windows.Forms.Label label_Uniq;
		private System.Windows.Forms.Label label_UMID;
		private System.Windows.Forms.Label label_NameLast;
		private System.Windows.Forms.Label label_FirstName;
		private System.Windows.Forms.Label label_StaffIn;
		private System.Windows.Forms.Label label_CheckIn;
		private System.Windows.Forms.Button button_ClearHistory;
		private System.Windows.Forms.Label label_LastClear;
		private System.Windows.Forms.Label label_CheckOut;
		private System.Windows.Forms.Label label_DueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameFirst;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameLast;
		private System.Windows.Forms.DataGridViewTextBoxColumn UMID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uniqname;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemCat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckInStaff;
	}
}