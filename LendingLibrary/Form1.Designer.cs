namespace LendingLibrary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label_Title = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label_Reminder = new System.Windows.Forms.Label();
			this.label_CheckOut = new System.Windows.Forms.Label();
			this.label_DueDate = new System.Windows.Forms.Label();
			this.label_ItemDesc = new System.Windows.Forms.Label();
			this.label_ItemCat = new System.Windows.Forms.Label();
			this.label_Uniq = new System.Windows.Forms.Label();
			this.label_UMID = new System.Windows.Forms.Label();
			this.label_NameLast = new System.Windows.Forms.Label();
			this.label_FirstName = new System.Windows.Forms.Label();
			this.button_CheckOut = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Trash = new System.Windows.Forms.DataGridViewButtonColumn();
			this.NameFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Uniqname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button_Remove = new System.Windows.Forms.Button();
			this.label_TimeRemind = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Trash,
            this.NameFirst,
            this.NameLast,
            this.UMID,
            this.Uniqname,
            this.ItemCat,
            this.ItemDesc,
            this.DueDate,
            this.CheckOut});
			this.dataGridView1.Location = new System.Drawing.Point(13, 104);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(871, 363);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// label_Title
			// 
			this.label_Title.Font = new System.Drawing.Font("Impact", 40F);
			this.label_Title.ForeColor = System.Drawing.Color.Yellow;
			this.label_Title.Location = new System.Drawing.Point(250, 24);
			this.label_Title.Name = "label_Title";
			this.label_Title.Size = new System.Drawing.Size(396, 76);
			this.label_Title.TabIndex = 1;
			this.label_Title.Text = "Lending Library";
			this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label_Reminder);
			this.groupBox1.Controls.Add(this.label_CheckOut);
			this.groupBox1.Controls.Add(this.label_DueDate);
			this.groupBox1.Controls.Add(this.label_ItemDesc);
			this.groupBox1.Controls.Add(this.label_ItemCat);
			this.groupBox1.Controls.Add(this.label_Uniq);
			this.groupBox1.Controls.Add(this.label_UMID);
			this.groupBox1.Controls.Add(this.label_NameLast);
			this.groupBox1.Controls.Add(this.label_FirstName);
			this.groupBox1.Location = new System.Drawing.Point(13, 474);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(871, 129);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Item Information";
			// 
			// label_Reminder
			// 
			this.label_Reminder.ForeColor = System.Drawing.Color.Red;
			this.label_Reminder.Location = new System.Drawing.Point(6, 98);
			this.label_Reminder.Name = "label_Reminder";
			this.label_Reminder.Size = new System.Drawing.Size(859, 20);
			this.label_Reminder.TabIndex = 8;
			// 
			// label_CheckOut
			// 
			this.label_CheckOut.Location = new System.Drawing.Point(430, 78);
			this.label_CheckOut.Name = "label_CheckOut";
			this.label_CheckOut.Size = new System.Drawing.Size(435, 20);
			this.label_CheckOut.TabIndex = 7;
			this.label_CheckOut.Text = "Checked Out By: ";
			// 
			// label_DueDate
			// 
			this.label_DueDate.Location = new System.Drawing.Point(430, 58);
			this.label_DueDate.Name = "label_DueDate";
			this.label_DueDate.Size = new System.Drawing.Size(435, 20);
			this.label_DueDate.TabIndex = 6;
			this.label_DueDate.Text = "Due Date: ";
			// 
			// label_ItemDesc
			// 
			this.label_ItemDesc.Location = new System.Drawing.Point(430, 38);
			this.label_ItemDesc.Name = "label_ItemDesc";
			this.label_ItemDesc.Size = new System.Drawing.Size(435, 20);
			this.label_ItemDesc.TabIndex = 5;
			this.label_ItemDesc.Text = "Item Description: ";
			// 
			// label_ItemCat
			// 
			this.label_ItemCat.Location = new System.Drawing.Point(430, 18);
			this.label_ItemCat.Name = "label_ItemCat";
			this.label_ItemCat.Size = new System.Drawing.Size(435, 20);
			this.label_ItemCat.TabIndex = 4;
			this.label_ItemCat.Text = "Item Category:";
			// 
			// label_Uniq
			// 
			this.label_Uniq.Location = new System.Drawing.Point(6, 78);
			this.label_Uniq.Name = "label_Uniq";
			this.label_Uniq.Size = new System.Drawing.Size(418, 20);
			this.label_Uniq.TabIndex = 3;
			this.label_Uniq.Text = "Uniqname: ";
			// 
			// label_UMID
			// 
			this.label_UMID.Location = new System.Drawing.Point(6, 58);
			this.label_UMID.Name = "label_UMID";
			this.label_UMID.Size = new System.Drawing.Size(418, 20);
			this.label_UMID.TabIndex = 2;
			this.label_UMID.Text = "UMID: ";
			// 
			// label_NameLast
			// 
			this.label_NameLast.Location = new System.Drawing.Point(6, 38);
			this.label_NameLast.Name = "label_NameLast";
			this.label_NameLast.Size = new System.Drawing.Size(418, 20);
			this.label_NameLast.TabIndex = 1;
			this.label_NameLast.Text = "Name (Last): ";
			// 
			// label_FirstName
			// 
			this.label_FirstName.Location = new System.Drawing.Point(6, 18);
			this.label_FirstName.Name = "label_FirstName";
			this.label_FirstName.Size = new System.Drawing.Size(418, 20);
			this.label_FirstName.TabIndex = 0;
			this.label_FirstName.Text = "Name (First): ";
			// 
			// button_CheckOut
			// 
			this.button_CheckOut.Location = new System.Drawing.Point(12, 74);
			this.button_CheckOut.Name = "button_CheckOut";
			this.button_CheckOut.Size = new System.Drawing.Size(113, 23);
			this.button_CheckOut.TabIndex = 6;
			this.button_CheckOut.Text = "Check Out";
			this.button_CheckOut.UseVisualStyleBackColor = true;
			this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(897, 24);
			this.menuStrip1.TabIndex = 7;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// infoToolStripMenuItem
			// 
			this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
			this.infoToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.infoToolStripMenuItem.Text = "Misc";
			// 
			// historyToolStripMenuItem
			// 
			this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
			this.historyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.historyToolStripMenuItem.Text = "History";
			this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// Trash
			// 
			this.Trash.HeaderText = "";
			this.Trash.Name = "Trash";
			this.Trash.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Trash.Text = "In";
			this.Trash.Width = 25;
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
			this.UMID.Width = 70;
			// 
			// Uniqname
			// 
			this.Uniqname.HeaderText = "Uniqname";
			this.Uniqname.Name = "Uniqname";
			this.Uniqname.ReadOnly = true;
			this.Uniqname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.Uniqname.Width = 80;
			// 
			// ItemCat
			// 
			this.ItemCat.HeaderText = "Item Category";
			this.ItemCat.Name = "ItemCat";
			this.ItemCat.ReadOnly = true;
			this.ItemCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ItemCat.Width = 120;
			// 
			// ItemDesc
			// 
			this.ItemDesc.HeaderText = "Item Description";
			this.ItemDesc.Name = "ItemDesc";
			this.ItemDesc.ReadOnly = true;
			this.ItemDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ItemDesc.Width = 130;
			// 
			// DueDate
			// 
			this.DueDate.HeaderText = "Due Date";
			this.DueDate.Name = "DueDate";
			this.DueDate.ReadOnly = true;
			this.DueDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// CheckOut
			// 
			this.CheckOut.HeaderText = "Staff Out";
			this.CheckOut.Name = "CheckOut";
			this.CheckOut.ReadOnly = true;
			this.CheckOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// button_Remove
			// 
			this.button_Remove.Location = new System.Drawing.Point(131, 74);
			this.button_Remove.Name = "button_Remove";
			this.button_Remove.Size = new System.Drawing.Size(113, 23);
			this.button_Remove.TabIndex = 8;
			this.button_Remove.Text = "Remove";
			this.button_Remove.UseVisualStyleBackColor = true;
			this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
			// 
			// label_TimeRemind
			// 
			this.label_TimeRemind.Location = new System.Drawing.Point(652, 33);
			this.label_TimeRemind.Name = "label_TimeRemind";
			this.label_TimeRemind.Size = new System.Drawing.Size(232, 64);
			this.label_TimeRemind.TabIndex = 9;
			this.label_TimeRemind.Text = "Please make sure that the Current Time and Date is correct.";
			this.label_TimeRemind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(897, 613);
			this.Controls.Add(this.label_TimeRemind);
			this.Controls.Add(this.button_Remove);
			this.Controls.Add(this.button_CheckOut);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label_Title);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Lending Library";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label_Title;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label_CheckOut;
		private System.Windows.Forms.Label label_DueDate;
		private System.Windows.Forms.Label label_ItemDesc;
		private System.Windows.Forms.Label label_ItemCat;
		private System.Windows.Forms.Label label_Uniq;
		private System.Windows.Forms.Label label_UMID;
		private System.Windows.Forms.Label label_NameLast;
		private System.Windows.Forms.Label label_FirstName;
		private System.Windows.Forms.Button button_CheckOut;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Label label_Reminder;
		private System.Windows.Forms.DataGridViewButtonColumn Trash;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameFirst;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameLast;
		private System.Windows.Forms.DataGridViewTextBoxColumn UMID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uniqname;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemCat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
		private System.Windows.Forms.Button button_Remove;
		private System.Windows.Forms.Label label_TimeRemind;
	}
}

