using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LendingLibrary
{
	public partial class CheckOut : Form
	{
		private bool button_clicked;

		public CheckOut() {
			InitializeComponent();
			button_clicked = false;
		}

		private bool Is_Valid_Date(string DateStr) {
			DateTime localTime = DateTime.Now;
			string currDateStr = localTime.Date.ToString("d");
			// [0] is month, [1] is day, [2] is year
			string[] currDate = currDateStr.Split('/');
			string[] dueDate = DateStr.Split('/');
			if (int.Parse(dueDate[2]) < int.Parse(currDate[2])) {
				numericUpDown_Year.BackColor = Color.LightCoral;
				return false;
			}
			if (int.Parse(dueDate[0]) < int.Parse(currDate[0])) {
				numericUpDown_Month.BackColor = Color.LightCoral;
				return false;
			}
			if (int.Parse(dueDate[1]) < int.Parse(currDate[1])) {
				numericUpDown_Day.BackColor = Color.LightCoral;
				return false;
			}
			return true;
		}

		#region Functions

		public void CheckOut_Dialog(ref DataGridView Main_Form) {
			// Preset the Due Dates to the Current Date
			DateTime localTime = DateTime.Now;
			string currDateStr = localTime.Date.ToString("d");
			// [0] is month, [1] is day, [2] is year
			string[] currDate = currDateStr.Split('/');
			numericUpDown_Month.Value = int.Parse(currDate[0]);
			numericUpDown_Day.Value = int.Parse(currDate[1]);
			numericUpDown_Year.Value = int.Parse(currDate[2]);
			ShowDialog();
			if (button_clicked) {
				string Date_Str = Date_To_String((int)numericUpDown_Month.Value,
					(int)numericUpDown_Day.Value, (int)numericUpDown_Year.Value);
				// Get current Time stamp for Check Out Time
				var culture = new CultureInfo("en-US");
				string checkoutTime = localTime.ToString(culture);
				// Add to DataGridView
				DataGridViewButtonColumn button = new DataGridViewButtonColumn();
				Main_Form.Rows.Insert(0, button, textBox_NameFirst.Text,
					textBox_NameLast.Text, textBox_UMID.Text, textBox_Uniq.Text,
					checkoutTime, comboBox_ItemCat.Text, textBox_ItemDesc.Text, 
					Date_Str, textBox_StaffOut.Text);
				Main_Form.Rows[0].Cells[0].Value = "In";
				Main_Form.ClearSelection();
				string dueDate = Main_Form.Rows[0].Cells[8].Value.ToString();
				if (Form1.Is_Overdue(dueDate)) {
					// Mark every cell in the row as Red.
					foreach (DataGridViewCell cell in Main_Form.Rows[0].Cells) {
						cell.Style.BackColor = Color.LightCoral;
					}
				}
			}
		}

		public void EditItem_Dialog(ref DataGridView Main_Form) {
			Text = "Edit Item";
			button_CheckOut.Text = "Edit";
			textBox_NameFirst.Text = Main_Form.SelectedRows[0].Cells[1].Value.ToString();
			textBox_NameLast.Text = Main_Form.SelectedRows[0].Cells[2].Value.ToString();
			textBox_UMID.Text = Main_Form.SelectedRows[0].Cells[3].Value.ToString();
			textBox_Uniq.Text = Main_Form.SelectedRows[0].Cells[4].Value.ToString();
			comboBox_ItemCat.Text = Main_Form.SelectedRows[0].Cells[6].Value.ToString();
			textBox_ItemDesc.Text = Main_Form.SelectedRows[0].Cells[7].Value.ToString();
			// Parse Dates
			string Old_Date_Str = Main_Form.SelectedRows[0].Cells[8].Value.ToString();
			string[] Dates = Old_Date_Str.Split('/');
			numericUpDown_Month.Value = int.Parse(Dates[0]);
			numericUpDown_Day.Value = int.Parse(Dates[1]);
			numericUpDown_Year.Value = int.Parse(Dates[2]);
			textBox_StaffOut.Text = Main_Form.SelectedRows[0].Cells[9].Value.ToString();
			ShowDialog();
			if (button_clicked) {
				string Date_Str = Date_To_String((int)numericUpDown_Month.Value,
					(int)numericUpDown_Day.Value, (int)numericUpDown_Year.Value);
				// Edit Form and mark background color as White.
				Main_Form.SelectedRows[0].Cells[1].Value = textBox_NameFirst.Text;
				Main_Form.SelectedRows[0].Cells[2].Value = textBox_NameLast.Text;
				Main_Form.SelectedRows[0].Cells[3].Value = textBox_UMID.Text;
				Main_Form.SelectedRows[0].Cells[4].Value = textBox_Uniq.Text;
				DateTime localTime = DateTime.Now;
				var culture = new CultureInfo("en-US");
				string checkoutTime = localTime.ToString(culture);
				Main_Form.SelectedRows[0].Cells[5].Value = checkoutTime + " [Edited]";
				Main_Form.SelectedRows[0].Cells[6].Value = comboBox_ItemCat.Text;
				Main_Form.SelectedRows[0].Cells[7].Value = textBox_ItemDesc.Text;
				Main_Form.SelectedRows[0].Cells[8].Value = Date_Str;
				Main_Form.SelectedRows[0].Cells[9].Value = textBox_StaffOut.Text;
				foreach (DataGridViewCell cell in Main_Form.SelectedRows[0].Cells) {
					cell.Style.BackColor = Color.White;
				}
				string dueDate = Main_Form.SelectedRows[0].Cells[8].Value.ToString();
				if (Form1.Is_Overdue(dueDate)) {
					// Mark every cell in the row as Red.
					foreach (DataGridViewCell cell in Main_Form.SelectedRows[0].Cells) {
						cell.Style.BackColor = Color.LightCoral;
					}
				}
			}
		}

		private string Date_To_String(int month, int day, int year) {
			return month + "/" + day + "/" + year;
		}

		#endregion

		#region Event Handlers

		private void button_CheckOut_Click(object sender, EventArgs e) {
			// Do a check.
			int empty = 0;
			string Date_Str = Date_To_String((int)numericUpDown_Month.Value,
					(int)numericUpDown_Day.Value, (int)numericUpDown_Year.Value);
			if (string.IsNullOrWhiteSpace(textBox_NameFirst.Text)) {
				textBox_NameFirst.BackColor = Color.LightCoral;
				empty++;
			}
			if (string.IsNullOrWhiteSpace(textBox_NameLast.Text)) {
				textBox_NameLast.BackColor = Color.LightCoral;
				empty++;
			}
			if (string.IsNullOrWhiteSpace(textBox_UMID.Text)) {
				textBox_UMID.BackColor = Color.LightCoral;
				empty++;
			}
			if (string.IsNullOrWhiteSpace(textBox_Uniq.Text)) {
				textBox_Uniq.BackColor = Color.LightCoral;
				empty++;
			}
			if (string.IsNullOrWhiteSpace(comboBox_ItemCat.Text)) {
				comboBox_ItemCat.BackColor = Color.LightCoral;
				empty++;
			}
			if (string.IsNullOrWhiteSpace(textBox_StaffOut.Text)) {
				textBox_StaffOut.BackColor = Color.LightCoral;
				empty++;
			}
			// Empty check
			if (empty > 0) {
				MessageBox.Show("Item form incomplete.", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			/* else if (!Is_Valid_Date(Date_Str)) {
				MessageBox.Show("Proposed Due Date is not valid with the current Date.", "Invalid", 
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			} */
			else {
				Close();
				button_clicked = true;
			}
		}

		private void textBox_NameFirst_TextChanged(object sender, EventArgs e) {
			textBox_NameFirst.BackColor = SystemColors.Window;
		}

		private void textBox_NameLast_TextChanged(object sender, EventArgs e) {
			textBox_NameLast.BackColor = SystemColors.Window;
		}

		private void textBox_UMID_TextChanged(object sender, EventArgs e) {
			textBox_UMID.BackColor = SystemColors.Window;
		}

		private void textBox_Uniq_TextChanged(object sender, EventArgs e) {
			textBox_Uniq.BackColor = SystemColors.Window;
		}

		private void comboBox_ItemCat_SelectedIndexChanged(object sender, EventArgs e) {
			comboBox_ItemCat.BackColor = SystemColors.Window;
		}

		private void numericUpDown_Month_ValueChanged(object sender, EventArgs e) {
			numericUpDown_Month.BackColor = SystemColors.Window;
		}

		private void numericUpDown_Day_ValueChanged(object sender, EventArgs e) {
			numericUpDown_Day.BackColor = SystemColors.Window;
		}

		private void numericUpDown_Year_ValueChanged(object sender, EventArgs e) {
			numericUpDown_Year.BackColor = SystemColors.Window;
		}

		private void textBox_StaffOut_TextChanged(object sender, EventArgs e) {
			textBox_StaffOut.BackColor = SystemColors.Window;
		}

		#endregion
	}
}
