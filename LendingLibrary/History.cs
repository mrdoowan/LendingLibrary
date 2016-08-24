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
	public partial class History : Form
	{
		public History() {
			InitializeComponent();
		}

		#region Functions

		public void History_Dialog() {
			foreach (Form1.Item PastItem in Form1.HistoryItems) {
				dataGridView1.Rows.Insert(0, PastItem.nameFirst, PastItem.nameLast, PastItem.UMID, PastItem.uniq,
					PastItem.checkOutTime, PastItem.itemCat, PastItem.itemDesc, PastItem.dueDate, PastItem.staffOut, 
					PastItem.checkInTime, PastItem.staffIn);
			}
			label_LastClear.Text = Form1.LastHistoryClear;
			ShowDialog();
		}

		// That's weird that we have to do this to clear selection
		private void History_Shown(object sender, EventArgs e) {
			dataGridView1.ClearSelection();
		}

		private void Empty_All_Labels() {
			label_Name.Text = "Resident Name: ";
			label_UMID.Text = "UMID: ";
			label_Uniq.Text = "Uniqname: ";
			label_ItemCat.Text = "Item Category: ";
			label_ItemDesc.Text = "Item Description: ";
			label_DueDate.Text = "Due Date: ";
			label_CheckOutTime.Text = "Check Out Time: ";
			label_CheckOut.Text = "Checked Out By: ";
			label_CheckIn.Text = "Check In Time: ";
			label_StaffIn.Text = "Checked In By: ";
		}

		#endregion

		#region Event Handlers

		// Show Item Info
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
			try {
				DataGridView Grid = (DataGridView)sender;
				DataGridViewRow item = Grid.Rows[e.RowIndex];
				label_Name.Text = "Resident Name: " + item.Cells[0].Value.ToString() + " " + item.Cells[1].Value.ToString();
				label_UMID.Text = "UMID: " + item.Cells[2].Value.ToString();
				label_Uniq.Text = "Uniqname: " + item.Cells[3].Value.ToString();
				label_CheckOutTime.Text = "Check Out Time: " + item.Cells[4].Value.ToString();
				label_ItemCat.Text = "Item Category: " + item.Cells[5].Value.ToString();
				label_ItemDesc.Text = "Item Description: " + item.Cells[6].Value.ToString();
				label_DueDate.Text = "Due Date: " + item.Cells[7].Value.ToString();
				label_CheckOut.Text = "Checked Out By: " + item.Cells[8].Value.ToString();
				label_CheckIn.Text = "Check In Time: " + item.Cells[9].Value.ToString();
				label_StaffIn.Text = "Checked In By: " + item.Cells[10].Value.ToString();
			}
			catch { } // Used if resizing the columns
		}

		private void button_ClearHistory_Click(object sender, EventArgs e) {
			MessageBoxText clearHist_Win = new MessageBoxText();
			if (clearHist_Win.ClearHist_Dialog()) {
				// This should have been updated in ClearHist_Dialog()
				label_LastClear.Text = Form1.LastHistoryClear;
				// Clear DataGridView and List
				Form1.HistoryItems.Clear();
				dataGridView1.Rows.Clear();
				dataGridView1.Refresh();
				Empty_All_Labels();
			}
		}

		#endregion
	}
}
