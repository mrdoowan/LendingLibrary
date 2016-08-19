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
		private bool button_clicked = false;

		public History() {
			InitializeComponent();
		}

		#region Dialog Functions to Prompt Form

		public void NewDialog() {

		}

		#endregion

		#region Event Handlers

		// Show Item Info
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void button_ClearHistory_Click(object sender, EventArgs e) {

		}

		#endregion
	}
}
