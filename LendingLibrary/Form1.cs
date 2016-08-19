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
		}

		// Key: UMID, Value: Item
		public static List<Item> DataItems = new List<Item>();
		public static List<Item> HistoryItems = new List<Item>();

		#region Event Handlers

		private void button_CheckOut_Click(object sender, EventArgs e) {
			CheckOut checkOut_Win = new CheckOut();
			checkOut_Win.CheckOut_Dialog(ref dataGridView1);
		}

		// Check all checkboxes
		private void button_CheckIn_Click(object sender, EventArgs e) {
			MessageBoxText checkIn_Win = new MessageBoxText();
			//checkIn_Win.CheckIn_Dialog();
		}

		private void historyToolStripMenuItem_Click(object sender, EventArgs e) {
			MessageBoxText History_Win = new MessageBoxText();
			//History_Win.History_Dialog();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
			string message = "Welcome to the UMich Housing Lending Library!\n\n" + 
				"This tool is mainly used for University of Michigan Housing to " + 
				"keep track of items that are Checked Out and Checked In.\n\n" +
				"- Press the \"Check Out\" button to add an Item for lending.\n" +  
				"- Check the box of an item and press the \"Check In\" button to log " +  
				"an Item back in. You will have to sign it off. Checking in an item will " +
				"add it to the History.\n" +
				"- Double click on an Item to edit the information.\n" + 
				"- You can check the History through the Info -> History menu strip. " +
				"All items will be logged appropriately with its specified time and date." + 
				"You are also able to Clear the History, in which it will be recorded.\n\n" +
				"Open-Source: [LINK]\n" +
				"Created by Steven Duan. Contact me (sduans@umich.edu) for any questions.";
			MessageBox.Show(message, "Help", MessageBoxButtons.OK);
		}

		// To edit the Checked Out Item
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			CheckOut EditItem_Win = new CheckOut();
			EditItem_Win.EditItem_Dialog(ref dataGridView1);
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {

		}

		#endregion
	}
}
