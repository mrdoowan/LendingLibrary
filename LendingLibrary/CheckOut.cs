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
	public partial class CheckOut : Form
	{
		private bool button_clicked;

		public CheckOut() {
			InitializeComponent();
			button_clicked = false;
		}

		#region Functions

		public void CheckOut_Dialog(ref DataGridView Main_Form) {
			ShowDialog();
			if (button_clicked) {
				string Date_Str = Date_To_String((int)numericUpDown_Month.Value,
					(int)numericUpDown_Day.Value, (int)numericUpDown_Year.Value);
				// Add to DataGridView
				Main_Form.Rows.Add(false, textBox_NameFirst.Text, 
					textBox_NameLast.Text, textBox_UMID.Text, textBox_Uniq.Text,
					comboBox_ItemCat.Text, textBox_ItemDesc.Text, Date_Str,
					textBox_StaffOut.Text);
				Main_Form.ClearSelection();
			}
		}

		public void EditItem_Dialog(ref DataGridView Main_Form) {
			Text = "Edit Item";
			button_CheckOut.Text = "Edit";
			string UMID = Main_Form.SelectedRows[0].Cells[3].Value.ToString();
			textBox_NameFirst.Text = Main_Form.SelectedRows[0].Cells[1].Value.ToString();
			textBox_NameLast.Text = Main_Form.SelectedRows[0].Cells[2].Value.ToString();
			textBox_UMID.Text = UMID;
			textBox_Uniq.Text = Main_Form.SelectedRows[0].Cells[4].Value.ToString();
			comboBox_ItemCat.Text = Main_Form.SelectedRows[0].Cells[5].Value.ToString();
			textBox_ItemDesc.Text = Main_Form.SelectedRows[0].Cells[6].Value.ToString();
			// Parse Dates
			string Old_Date_Str = Main_Form.SelectedRows[0].Cells[7].Value.ToString();
			string[] Dates = Old_Date_Str.Split('/');
			numericUpDown_Month.Value = int.Parse(Dates[0]);
			numericUpDown_Day.Value = int.Parse(Dates[1]);
			numericUpDown_Year.Value = int.Parse(Dates[2]);
			textBox_StaffOut.Text = Main_Form.SelectedRows[0].Cells[8].Value.ToString();
			ShowDialog();
			if (button_clicked) {
				string Date_Str = Date_To_String((int)numericUpDown_Month.Value,
					(int)numericUpDown_Day.Value, (int)numericUpDown_Year.Value);
				// Edit Form
				Main_Form.SelectedRows[0].Cells[1].Value = textBox_NameFirst.Text;
				Main_Form.SelectedRows[0].Cells[2].Value = textBox_NameLast.Text;
				Main_Form.SelectedRows[0].Cells[3].Value = textBox_UMID.Text;
				Main_Form.SelectedRows[0].Cells[4].Value = textBox_Uniq.Text;
				Main_Form.SelectedRows[0].Cells[5].Value = comboBox_ItemCat.Text;
				Main_Form.SelectedRows[0].Cells[6].Value = textBox_ItemDesc.Text;
				Main_Form.SelectedRows[0].Cells[7].Value = Date_Str;
				Main_Form.SelectedRows[0].Cells[8].Value = textBox_StaffOut.Text;
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
			if (string.IsNullOrWhiteSpace(textBox_ItemDesc.Text)) {
				textBox_ItemDesc.BackColor = Color.LightCoral;
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

		private void textBox_ItemDesc_TextChanged(object sender, EventArgs e) {
			textBox_ItemDesc.BackColor = SystemColors.Window;
		}

		private void textBox_StaffOut_TextChanged(object sender, EventArgs e) {
			textBox_StaffOut.BackColor = SystemColors.Window;
		}

		#endregion
	}
}
