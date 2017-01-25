using System;
using System.Globalization;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace LendingLibrary
{
	public partial class HistoryForm : Form
	{
		public HistoryForm() {
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

        // Will also save an Excel sheet before Clearing
		private void button_ClearHistory_Click(object sender, EventArgs e) {
			MessageBoxText clearHist_Win = new MessageBoxText();
            string name = clearHist_Win.ClearHist_Dialog();
            if (!string.IsNullOrWhiteSpace(name)) {
                // TODO: Save into Excel
                var xlApp = new Excel.Application();
                try {
                    SaveFileDialog saveExcelDialog = new SaveFileDialog();
                    saveExcelDialog.Filter = "Excel Sheet (*.xlsx)|*.xlsx";
                    saveExcelDialog.Title = "Save History";
                    if (saveExcelDialog.ShowDialog() == DialogResult.OK) {
                        Excel.Workbook xlWorkBook;
                        Excel.Worksheet xlWorkSheet;
                        object mis = System.Reflection.Missing.Value;
                        xlWorkBook = xlApp.Workbooks.Add(mis);
                        var xlSheets = xlWorkBook.Sheets as Excel.Sheets;
                        xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                        DateTime thisDay = DateTime.Today;
                        xlWorkSheet.Name = "Items History " + thisDay.ToString("d").Replace('/', '-');
                        xlWorkSheet.Range["A1"].Value = "History cleared by: " + name;
                        xlWorkSheet.get_Range("A2", "K2").WrapText = true;
                        xlWorkSheet.get_Range("A2", "K2").Font.Bold = true;
                        xlWorkSheet.get_Range("A2", "K2").Font.Underline = true;
                        xlWorkSheet.get_Range("A2", "K2").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Range["A2"].Value = "Name (First)";
                        xlWorkSheet.Range["B2"].Value = "Name (Last)";
                        xlWorkSheet.Range["C2"].Value = "UMID";
                        xlWorkSheet.Range["D2"].Value = "Uniq";
                        xlWorkSheet.Range["E2"].Value = "Check Out Time";
                        xlWorkSheet.Range["F2"].Value = "Item Category";
                        xlWorkSheet.Range["G2"].Value = "Item Description";
                        xlWorkSheet.Range["H2"].Value = "Due Date";
                        xlWorkSheet.Range["I2"].Value = "Staff Out";
                        xlWorkSheet.Range["J2"].Value = "Check In Time";
                        xlWorkSheet.Range["K2"].Value = "Staff In";
                        xlWorkSheet.Columns["A"].ColumnWidth = 11.00;
                        xlWorkSheet.Columns["B"].ColumnWidth = 11.00;
                        xlWorkSheet.Columns["C"].ColumnWidth = 11.00;
                        xlWorkSheet.Columns["D"].ColumnWidth = 11.00;
                        xlWorkSheet.Columns["E"].ColumnWidth = 20.00;
                        xlWorkSheet.Columns["F"].ColumnWidth = 20.00;
                        xlWorkSheet.Columns["G"].ColumnWidth = 20.00;
                        xlWorkSheet.Columns["H"].ColumnWidth = 11.00;
                        xlWorkSheet.Columns["I"].ColumnWidth = 11.00;
                        xlWorkSheet.Columns["J"].ColumnWidth = 20.00;
                        xlWorkSheet.Columns["K"].ColumnWidth = 11.00;
                        int row = 3;
                        foreach (DataGridViewRow item in dataGridView1.Rows) {
                            xlWorkSheet.Range["A" + row].Value = item.Cells[0].Value.ToString();
                            xlWorkSheet.Range["B" + row].Value = item.Cells[1].Value.ToString();
                            xlWorkSheet.Range["C" + row].Value = item.Cells[2].Value.ToString();
                            xlWorkSheet.Range["D" + row].Value = item.Cells[3].Value.ToString();
                            xlWorkSheet.Range["E" + row].Value = item.Cells[4].Value.ToString();
                            xlWorkSheet.Range["F" + row].Value = item.Cells[5].Value.ToString();
                            xlWorkSheet.Range["G" + row].Value = item.Cells[6].Value.ToString();
                            xlWorkSheet.Range["H" + row].Value = item.Cells[7].Value.ToString();
                            xlWorkSheet.Range["I" + row].Value = item.Cells[8].Value.ToString();
                            xlWorkSheet.Range["J" + row].Value = item.Cells[9].Value.ToString();
                            xlWorkSheet.Range["K" + row].Value = item.Cells[10].Value.ToString();
                            row++;
                        }
                        releaseObject(xlWorkSheet);
                        string filename = saveExcelDialog.FileName;
                        try {
                            xlApp.DisplayAlerts = false;
                            xlWorkBook.SaveAs(filename);
                        }
                        catch (Exception ex) {
                            MessageBox.Show("Can't overwrite file. Please save it as another name." +
                                ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MessageBox.Show("History Cleared.", "Confirmed");
                        xlApp.Visible = true;
                        releaseObject(xlWorkBook);
                    }
                    else {
                        MessageBox.Show("No Excel sheet made. Returning to Window.",
                            "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        releaseObject(xlApp);
                        return;
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Failed to make an Excel sheet. Aborting.\nReason: " +
                        ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    releaseObject(xlApp);
                    return;
                }
                releaseObject(xlApp);
                // Update text
                DateTime localTime = DateTime.Now;
                var culture = new CultureInfo("en-US");
                string currTime = localTime.ToString(culture);
                Form1.LastHistoryClear = "Last History Clear: " + name + " at " + currTime;
                label_LastClear.Text = Form1.LastHistoryClear;
				// Clear DataGridView and List
				Form1.HistoryItems.Clear();
				dataGridView1.Rows.Clear();
				dataGridView1.Refresh();
				Empty_All_Labels();
			}
		}

        // For securing the Trash
        private static void releaseObject(object obj) {
            try {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex) {
                obj = null;
                throw ex;
            }
            finally {
                GC.Collect();
            }
        }

        #endregion
    }
}
