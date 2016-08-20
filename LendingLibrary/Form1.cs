using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LendingLibrary
{
	public partial class Form1 : Form
	{
		private const string version = "1.0.0";

		public Form1() {
			InitializeComponent();
		}

		[Serializable()] // For serializing into a string to save
		public struct Item
		{
		    public string nameFirst;
			public string nameLast;
			public string UMID;
			public string uniq;
			public string itemCat;
			public string itemDesc;
			public string dueDate;
			public string staffOut;
			public string checkInTime;
			public string staffIn;

			// For DataItems
			public Item(string nameFirst_, string nameLast_, string UMID_, 
				string uniq_, string cat_, string desc_, string due_, string staffOut_) {
				nameFirst = nameFirst_;
				nameLast = nameLast_;
				UMID = UMID_;
				uniq = uniq_;
				itemCat = cat_;
				itemDesc = desc_;
				dueDate = due_;
				staffOut = staffOut_;
				checkInTime = "";
				staffIn = "";
			}

			// For HistoryItems
			public Item(string nameFirst_, string nameLast_, string UMID_,
				string uniq_, string cat_, string desc_, string due_, string staffOut_,
				string inTime_, string staffIn_) {
				nameFirst = nameFirst_;
				nameLast = nameLast_;
				UMID = UMID_;
				uniq = uniq_;
				itemCat = cat_;
				itemDesc = desc_;
				dueDate = due_;
				staffOut = staffOut_;
				checkInTime = inTime_;
				staffIn = staffIn_;
			}
		}

		// Variables for save.
		public static List<Item> DataItems = new List<Item>();
		public static List<Item> HistoryItems = new List<Item>();
		public static string LastHistoryClear = "Last History Clear: None";

		private void Empty_All_Labels() {
			label_FirstName.Text = "Name (First): ";
			label_NameLast.Text = "Name (Last): ";
			label_UMID.Text = "UMID: ";
			label_Uniq.Text = "Uniqname: ";
			label_ItemCat.Text = "Item Category: ";
			label_ItemDesc.Text = "Item Description: ";
			label_DueDate.Text = "Due Date: ";
			label_CheckOut.Text = "Checked Out By: ";
			label_Reminder.Text = "";
		}

		// Returns true if overdue
		// Returns false if fine.
		private bool Is_Overdue(string dueDateStr) {
			DateTime localTime = DateTime.Now;
			string currDateStr = localTime.Date.ToString("d");
			// [0] is month, [1] is day, [2] is year
			string[] currDate = currDateStr.Split('/');
			string[] dueDate = dueDateStr.Split('/');
			if (int.Parse(currDate[2]) > int.Parse(dueDate[2])) { return true; }
			if (int.Parse(currDate[0]) > int.Parse(dueDate[0])) { return true; }
			if (int.Parse(currDate[1]) > int.Parse(dueDate[1])) { return true; }
			return false;
		}

		#region Event Handlers

		private void button_CheckOut_Click(object sender, EventArgs e) {
			CheckOut checkOut_Win = new CheckOut();
			checkOut_Win.CheckOut_Dialog(ref dataGridView1);
			Empty_All_Labels();
		}

		// For checking-In Item.
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			DataGridView Grid = (DataGridView)sender;
			if (Grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
				//Button Clicked for that row.
				DataGridViewRow Item = Grid.Rows[e.RowIndex];
				MessageBoxText checkIn_Win = new MessageBoxText();
				if (checkIn_Win.CheckIn_Dialog(Item)) {
					Grid.Rows.RemoveAt(Item.Index);
					Grid.Refresh();
					Empty_All_Labels();
					MessageBox.Show("Item checked in!", "Success");
				}
			}
		}

		// Remove an Item.
		private void button_Remove_Click(object sender, EventArgs e) {
			DataGridViewRow Item = dataGridView1.SelectedRows[0];
			string message = "Do you want to remove Item \"" + Item.Cells[5].Value.ToString();
			if (!string.IsNullOrWhiteSpace(Item.Cells[6].Value.ToString())) { message += " - " + Item.Cells[6].Value.ToString(); }
			message += "\"?\n";
			message += "NOTE: This is NOT checking in an item. Please press the \"In\" button on each Item if checking in.";
			if (MessageBox.Show(message, "Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				dataGridView1.Rows.RemoveAt(Item.Index);
				dataGridView1.Refresh();
				Empty_All_Labels();
				MessageBox.Show("Item removed.", "Removed");
			}
		}

		private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
			History History_Win = new History();
			History_Win.History_Dialog();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
			string message = "Welcome to the UMich Housing Lending Library!\n\n" + 
				"This tool is mainly used for the University of Michigan Housing to " + 
				"keep track of items that are Checked Out and Checked In.\n\n" +
				"- Press the \"Check Out\" button to add an Item for lending.\n" +  
				"- Press the \"In\" button that is on the row of each Item to check it in" +  
				". You will have to sign it off. Checking in an item will " +
				"add it to the History.\n" +
				"- Double click on an Item to edit the information.\n" + 
				"- You can check the History through the Misc -> History menu strip. " +
				"All items will be logged appropriately with its specified time and date. " + 
				"You are also able to Clear the History.\n\n" +
				"Open-Source: https://github.com/mrdoowan/LendingLibrary \n" +
				"Created by Steven Duan. Contact me (sduans@umich.edu) for any questions.";
			MessageBox.Show(message, "Help", MessageBoxButtons.OK);
		}

		// To edit the Checked Out Item
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			CheckOut EditItem_Win = new CheckOut();
			EditItem_Win.EditItem_Dialog(ref dataGridView1);
		}

        // To display the information in the labels
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
			try {
				DataGridView Grid = (DataGridView)sender;
				DataGridViewRow Item = Grid.Rows[e.RowIndex];
				label_FirstName.Text = "Name (First): " + Item.Cells[1].Value.ToString();
				label_NameLast.Text = "Name (Last): " + Item.Cells[2].Value.ToString();
				label_UMID.Text = "UMID: " + Item.Cells[3].Value.ToString();
				label_Uniq.Text = "Uniqname: " + Item.Cells[4].Value.ToString();
				label_ItemCat.Text = "Item Category: " + Item.Cells[5].Value.ToString();
				label_ItemDesc.Text = "Item Description: " + Item.Cells[6].Value.ToString();
				string dueDate = Item.Cells[7].Value.ToString();
				label_DueDate.Text = "Due Date: " + dueDate;
				label_CheckOut.Text = "Checked Out By: " + Item.Cells[8].Value.ToString();
				if (Is_Overdue(dueDate)) {
					label_Reminder.Text = "OVERDUE: " + dueDate + ". Please Email the resident a reminder.";
				}
			}
			catch { } // Used if resizing the columns
		}

		// Save the objects
		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {

		}

		// Also checks for Updates
		// Opens the objects
		// Also flags a row red when an item is overdue.
		private void Form1_Load(object sender, EventArgs e) {

		}

		#endregion
	}
}
