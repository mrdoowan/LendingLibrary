using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LendingLibrary
{
	public partial class MessageBoxText : Form
	{
		private bool button_clicked;

		public MessageBoxText() {
			InitializeComponent();
			button_clicked = false;
		}

		#region Dialog Functions to Prompt Form

		// Returns true if button is confirmed.
		// Returns false if closed.
		// This is for a Check In box.
		public bool CheckIn_Dialog(DataGridViewRow Item) {
			string nameFirst = Item.Cells[1].Value.ToString();
			string nameLast = Item.Cells[2].Value.ToString();
			string itemCat = Item.Cells[5].Value.ToString();
			string itemDesc = Item.Cells[6].Value.ToString();
			label_TopMsg.Text = "Checking in \"" + itemCat + "\"";
			if (!string.IsNullOrWhiteSpace(itemDesc)) { label_TopMsg.Text += " - " + itemDesc; }
			label_TopMsg.Text += "\n";
			label_TopMsg.Text += "From " + nameFirst + " " + nameLast + '\n';
			ShowDialog();
			if (button_clicked) {
				// Add into the List<Items> of HistoryItems
				string staffIn = textBox1.Text;
				DateTime localTime = DateTime.Now;
				var culture = new CultureInfo("en-US");
				string currTime = localTime.ToString(culture);
				string UMID = Item.Cells[3].Value.ToString();
				string Uniq = Item.Cells[4].Value.ToString();
				string dueDate = Item.Cells[7].Value.ToString();
				string staffOut = Item.Cells[8].Value.ToString();
				Form1.Item histItem = new Form1.Item(nameFirst, nameLast, UMID, Uniq,
					itemCat, itemDesc, dueDate, staffOut, currTime, staffIn);
				Form1.HistoryItems.Add(histItem);
				return true;
			}
			return false;
		}

		// This for Clearing History
		public bool ClearHist_Dialog() {
			label_TopMsg.Text = "This will delete the entire History.\nPlease sign off to clear the History.";
			label_BottomMsg.Text = "History Cleared by Staff:";
			this.Text = "Clear History";
			button_OK.Text = "Clear";
			ShowDialog();
			if (button_clicked) {
				DateTime localTime = DateTime.Now;
				var culture = new CultureInfo("en-US");
				string currTime = localTime.ToString(culture);
				Form1.LastHistoryClear = "Last History Clear: " + textBox1.Text + " at " + currTime;
				return true;
			}
			else {
				return false;
			}
		}

		#endregion

		#region Event Handlers

		private void button_OK_Click(object sender, EventArgs e) {
			Close();
			button_clicked = true;
		}

		#endregion
	}
}
