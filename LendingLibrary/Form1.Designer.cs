﻿namespace LendingLibrary
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
            this.Trash = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NameFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uniqname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_CheckOut = new System.Windows.Forms.Button();
            this.button_Email = new System.Windows.Forms.Button();
            this.label_TimeRemind = new System.Windows.Forms.Label();
            this.button_History = new System.Windows.Forms.Button();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_EmailSetting = new System.Windows.Forms.Button();
            this.label_OverdueMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.TimeStamp,
            this.ItemCat,
            this.ItemDesc,
            this.DueDate,
            this.CheckOut});
            this.dataGridView1.Location = new System.Drawing.Point(13, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
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
            // TimeStamp
            // 
            this.TimeStamp.HeaderText = "Check-Out Time";
            this.TimeStamp.Name = "TimeStamp";
            this.TimeStamp.ReadOnly = true;
            this.TimeStamp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TimeStamp.Width = 125;
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
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("Impact", 40F);
            this.label_Title.ForeColor = System.Drawing.Color.Yellow;
            this.label_Title.Location = new System.Drawing.Point(229, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(525, 76);
            this.label_Title.TabIndex = 1;
            this.label_Title.Text = "Lending Library";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_CheckOut
            // 
            this.button_CheckOut.Location = new System.Drawing.Point(12, 54);
            this.button_CheckOut.Name = "button_CheckOut";
            this.button_CheckOut.Size = new System.Drawing.Size(105, 31);
            this.button_CheckOut.TabIndex = 6;
            this.button_CheckOut.Text = "Check Out";
            this.button_CheckOut.UseVisualStyleBackColor = true;
            this.button_CheckOut.Click += new System.EventHandler(this.button_CheckOut_Click);
            // 
            // button_Email
            // 
            this.button_Email.Location = new System.Drawing.Point(124, 54);
            this.button_Email.Name = "button_Email";
            this.button_Email.Size = new System.Drawing.Size(105, 31);
            this.button_Email.TabIndex = 8;
            this.button_Email.Text = "Send Email";
            this.button_Email.UseVisualStyleBackColor = true;
            this.button_Email.Click += new System.EventHandler(this.button_Email_Click);
            // 
            // label_TimeRemind
            // 
            this.label_TimeRemind.Location = new System.Drawing.Point(760, 21);
            this.label_TimeRemind.Name = "label_TimeRemind";
            this.label_TimeRemind.Size = new System.Drawing.Size(208, 64);
            this.label_TimeRemind.TabIndex = 9;
            this.label_TimeRemind.Text = "Please make sure that the current Time and Date is correct.";
            this.label_TimeRemind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_History
            // 
            this.button_History.Location = new System.Drawing.Point(645, 459);
            this.button_History.Name = "button_History";
            this.button_History.Size = new System.Drawing.Size(100, 31);
            this.button_History.TabIndex = 11;
            this.button_History.Text = "History";
            this.button_History.UseVisualStyleBackColor = true;
            this.button_History.Click += new System.EventHandler(this.button_History_Click);
            // 
            // button_Help
            // 
            this.button_Help.Location = new System.Drawing.Point(863, 459);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(106, 31);
            this.button_Help.TabIndex = 10;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button_Help_Click);
            // 
            // button_EmailSetting
            // 
            this.button_EmailSetting.Location = new System.Drawing.Point(751, 459);
            this.button_EmailSetting.Name = "button_EmailSetting";
            this.button_EmailSetting.Size = new System.Drawing.Size(106, 31);
            this.button_EmailSetting.TabIndex = 12;
            this.button_EmailSetting.Text = "Email Settings";
            this.button_EmailSetting.UseVisualStyleBackColor = true;
            this.button_EmailSetting.Click += new System.EventHandler(this.button_EmailSetting_Click);
            // 
            // label_OverdueMsg
            // 
            this.label_OverdueMsg.ForeColor = System.Drawing.Color.DarkRed;
            this.label_OverdueMsg.Location = new System.Drawing.Point(13, 459);
            this.label_OverdueMsg.Name = "label_OverdueMsg";
            this.label_OverdueMsg.Size = new System.Drawing.Size(626, 31);
            this.label_OverdueMsg.TabIndex = 13;
            this.label_OverdueMsg.Text = "Resident has not been Emailed yet for Overdue Item";
            this.label_OverdueMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_OverdueMsg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(981, 499);
            this.Controls.Add(this.label_OverdueMsg);
            this.Controls.Add(this.button_EmailSetting);
            this.Controls.Add(this.button_History);
            this.Controls.Add(this.button_Help);
            this.Controls.Add(this.label_TimeRemind);
            this.Controls.Add(this.button_Email);
            this.Controls.Add(this.button_CheckOut);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(997, 538);
            this.MinimumSize = new System.Drawing.Size(997, 538);
            this.Name = "Form1";
            this.Text = "Lending Library";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label_Title;
		private System.Windows.Forms.Button button_CheckOut;
		private System.Windows.Forms.Button button_Email;
		private System.Windows.Forms.Label label_TimeRemind;
		private System.Windows.Forms.DataGridViewButtonColumn Trash;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameFirst;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameLast;
		private System.Windows.Forms.DataGridViewTextBoxColumn UMID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Uniqname;
		private System.Windows.Forms.DataGridViewTextBoxColumn TimeStamp;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemCat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
		private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.Button button_History;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Button button_EmailSetting;
        private System.Windows.Forms.Label label_OverdueMsg;
    }
}

