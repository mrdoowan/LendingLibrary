using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;
using System.Globalization;
using System.Xml.Serialization;
using System.Net.Mail;

namespace LendingLibrary
{
	public partial class Form1 : Form
	{
		public Form1() {
			InitializeComponent();
		}

		private const string version = "1.2.0";
		private const string website = "https://github.com/mrdoowan/LendingLibrary/releases";
		private static bool upgrading = false;

		[Serializable()] // For serializing into a string to save
		public struct Item
		{
		    public string nameFirst;
			public string nameLast;
			public string UMID;
			public string uniq;
			public string checkOutTime;
			public string itemCat;
			public string itemDesc;
			public string dueDate;
			public string staffOut;
			public string checkInTime;
			public string staffIn;

			// For DataItems
			public Item(string nameFirst_, string nameLast_, string UMID_, 
				string uniq_, string checkOut_, string cat_, string desc_, string due_, string staffOut_) {
				nameFirst = nameFirst_;
				nameLast = nameLast_;
				UMID = UMID_;
				uniq = uniq_;
				checkOutTime = checkOut_;
				itemCat = cat_;
				itemDesc = desc_;
				dueDate = due_;
				staffOut = staffOut_;
				checkInTime = "";
				staffIn = "";
			}

			// For HistoryItems
			public Item(string nameFirst_, string nameLast_, string UMID_,
				string uniq_, string checkOut_, string cat_, string desc_, string due_, 
				string staffOut_, string inTime_, string staffIn_) {
				nameFirst = nameFirst_;
				nameLast = nameLast_;
				UMID = UMID_;
				uniq = uniq_;
				checkOutTime = checkOut_;
				itemCat = cat_;
				itemDesc = desc_;
				dueDate = due_;
				staffOut = staffOut_;
				checkInTime = inTime_;
				staffIn = staffIn_;
			}
		}
        
        public EmailSettings emailSettings = new EmailSettings();

		// Variables for save.
		// public static List<Item> DataItems = new List<Item>(); // (This isn't needed anymore)
		public static List<Item> HistoryItems = new List<Item>();
		public static string LastHistoryClear = "Last History Clear: None";

		#region Functions

		// Returns true if overdue
		// Returns false if fine.
		static public bool Is_Overdue(string dueDateStr) {
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

		// Version follows the following format:
		// Major.Minor.Revision (only 3)
		// Very temporary Update Check that simply leads to the Github page.
		private void Check_Update() {
			WebClient WC = new WebClient();
			try {
				string[] current = version.Split('.');
				// Get latest version from site
				string header_msg = "LendingLirary " + Assembly.GetExecutingAssembly().GetName().Version.ToString() + " UpdateCheck " + Environment.OSVersion;
				WC.Headers.Add("Content-Type", header_msg);
				string version_page = WC.DownloadString("https://raw.githubusercontent.com/mrdoowan/LendingLibrary/master/CurrentVersion.txt");
				string[] latest = version_page.Split('.');
				// Since we are looping through Current length, Current should not be bigger than Latest
				if (current.Length > latest.Length) {
					MessageBox.Show("The current Length is greater than latest Length.", "Report Bug", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				for (int i = 0; i < current.Length; ++i) {
					// We do nothing if the current version is greater than latest version
					if (int.Parse(current[i]) > int.Parse(latest[i])) {
						return;
					}
					else if (i == current.Length - 1 && (int.Parse(current[i]) >= int.Parse(latest[i]))) { // Last number check.
						return;
					}
				}
				// If we've arrived at this point, that means it needs updating.
				if (MessageBox.Show("An update to v" + version_page + " is available. Would you like to close this application and download the newest version?" + 
					"\nNOTE: You will need to re-check out every items in this current Application.", "New Version",
					MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) {
					Process.Start(website);
					upgrading = true;
					Application.Exit();
				}
			}
			catch (Exception e) {
				MessageBox.Show("Error in checking for an update.\nReason: " + e.Message, "OPRP Char Builder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

        // Functions that need to make the Label visible or not
        private void Update_OverdueMsgLabel() {
            if (dataGridView1.SelectedRows.Count > 0) {
                if (dataGridView1.SelectedRows[0].Cells[0].Style.BackColor == Color.LightCoral) {
                    // Item is overdue
                    label_OverdueMsg.Visible = true;
                    label_OverdueMsg.Text = "Resident has not been Emailed yet for Overdue Item.";
                    label_OverdueMsg.ForeColor = Color.DarkRed;
                    return;
                }
                else if (dataGridView1.SelectedRows[0].Cells[0].Style.BackColor == Color.LightSeaGreen) {
                    label_OverdueMsg.Visible = true;
                    label_OverdueMsg.Text = "Resident has been Emailed today for Overdue Item.";
                    label_OverdueMsg.ForeColor = Color.DarkGreen;
                    return;
                }
            }
            label_OverdueMsg.Visible = false;
        }

        // Send Email with SMTP (with Google)
        private void send_Email(string firstName, string lastName, string itemCat, string itemDesc,
            string dueDate, string uniqname) {
            // Need to replace the Map literals
            string subject = emailSettings.get_Subject();
            subject = map_EmailMessage(subject, firstName, lastName, itemCat, itemDesc, dueDate);
            string body = emailSettings.get_Body();
            body = map_EmailMessage(body, firstName, lastName, itemCat, itemDesc, dueDate);
            // Mail Configuration
            var fromAddress = new MailAddress(
                emailSettings.get_Address() + "@gmail.com", "Bursley CC");
            var toAddress = new MailAddress(
                uniqname + "@umich.edu", firstName + ' ' + lastName);
            var smtp = new SmtpClient {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(
                    fromAddress.Address, emailSettings.get_Password())
            };
            using (var message = new MailMessage(fromAddress, toAddress) {
                Subject = subject,
                Body = body
            }) {
                smtp.Send(message);
            }
        }

		#endregion

		#region Event Handlers

		// For Check Out Items
		private void button_CheckOut_Click(object sender, EventArgs e) {
			CheckOut checkOut_Win = new CheckOut();
			checkOut_Win.CheckOut_Dialog(ref dataGridView1);
		}

		// For Check In Item.
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
			DataGridView Grid = (DataGridView)sender;
			DataGridViewRow item = Grid.Rows[e.RowIndex];
			if (Grid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0) {
				//Button Clicked for that row.
				MessageBoxText checkIn_Win = new MessageBoxText();
				if (checkIn_Win.CheckIn_Dialog(item)) {
					Grid.Rows.RemoveAt(item.Index);
					Grid.Refresh();
					MessageBox.Show("Item checked in!", "Success");
				}
			}
		}

        private string map_EmailMessage(string message, string first, string last,
            string itemCat, string itemDesc, string dueDate) {
            message = message.Replace("<1>", first);
            message = message.Replace("<2>", last);
            message = message.Replace("<3>", itemCat);
            message = message.Replace("<4>", itemDesc);
            message = message.Replace("<5>", dueDate);
            return message;
        }

        // Emailing Residents for overdue items. Given though, it should be automatically done
        private void button_Email_Click(object sender, EventArgs e) {
            if (dataGridView1.SelectedRows.Count > 0) {
                string dueDate = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                string firstName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                if (!Is_Overdue(dueDate) && 
                    MessageBox.Show("The item is not yet overdue. " +
                    "Are you sure you want to send an Email?", "Prompt",
                    MessageBoxButtons.YesNo) == DialogResult.No) {
                    return;
                }
                else if (MessageBox.Show("Do you want to send an overdue notice Email to " + firstName + "?",
                    "Prompt", MessageBoxButtons.YesNo) == DialogResult.No) {
                    return;
                }
                try {
                    string lastName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    string uniqname = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                    string itemCat = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                    string itemDesc = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                    send_Email(firstName, lastName, itemCat, itemDesc, dueDate, uniqname);
                    // Change color
                    foreach (DataGridViewCell cell in dataGridView1.SelectedRows[0].Cells) {
                        cell.Style.BackColor = Color.LightSeaGreen;
                    }
                    MessageBox.Show("Email Sent!", "Sent",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) {
                    MessageBox.Show("Email failed to send.\nReason: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Help_Click(object sender, EventArgs e) {
            string message = "Welcome to the UMich Housing Lending Library!\n\n" +
                "This tool is mainly used for the University of Michigan Housing to " +
                "keep track of items that are Checked Out and Checked In.\n\n" +
                "- Press the \"Check Out\" button to add an Item for lending.\n" +
                "- Press the \"In\" button that is on the row of each Item to check it in" +
                ". You will have to sign it off. Checking in an item will " +
                "add it to the History.\n" +
                "- Double click on an Item to edit the information.\n" +
                "- You can check the History through the \"History\" button " +
                "All items will be logged appropriately with its specified time and date. " +
                "You are also able to Clear the History.\n" +
                "Open-Source: https://github.com/mrdoowan/LendingLibrary \n" +
                "Created by Steven Duan. Contact sduans@umich.edu for any questions.";
            MessageBox.Show(message, "Help", MessageBoxButtons.OK);
        }

        private void button_History_Click(object sender, EventArgs e) {
            HistoryForm History_Win = new HistoryForm();
            History_Win.History_Dialog();
        }

        // This will pull up another Email configuring Email settings
        private void button_EmailSetting_Click(object sender, EventArgs e) {
            EmailSettingForm Email_Win = new EmailSettingForm();
            Email_Win.EmailSetting_Dialog(ref emailSettings);
        }

        // To edit the Checked Out Item
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
			CheckOut EditItem_Win = new CheckOut();
			EditItem_Win.EditItem_Dialog(ref dataGridView1);
		}

        // To display the information in the labels
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            try { }
            catch { } // Used if resizing the columns
            Update_OverdueMsgLabel();
        }

		// Save Functions for the Default
		private void SaveItems(List<Item> dataItems, List<Item> histItems) {
            // Save current Items
			using (MemoryStream ms = new MemoryStream()) {
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(ms, dataItems);
				ms.Position = 0;
				byte[] buffer = new byte[(int)ms.Length];
				ms.Read(buffer, 0, buffer.Length);
				Properties.Settings.Default.SaveDataItems = Convert.ToBase64String(buffer);
				Properties.Settings.Default.Save();
			}
            // Save History Items
			using (MemoryStream ms = new MemoryStream()) {
				BinaryFormatter bf = new BinaryFormatter();
				bf.Serialize(ms, histItems);
				ms.Position = 0;
				byte[] buffer = new byte[(int)ms.Length];
				ms.Read(buffer, 0, buffer.Length);
				Properties.Settings.Default.SaveHistoryItems = Convert.ToBase64String(buffer);
				Properties.Settings.Default.Save();
			}
			Properties.Settings.Default.LastHistClear = LastHistoryClear;
            // Saving Emailsettings
            Properties.Settings.Default.EmailAddress = emailSettings.get_Address();
            Properties.Settings.Default.EmailPassword = emailSettings.get_Password();
            Properties.Settings.Default.EmailSubject = emailSettings.get_Subject();
            Properties.Settings.Default.EmailBody = emailSettings.get_Body();
            Properties.Settings.Default.Save();
        }

		// To load Data Items
		List<Item> LoadDataItems() {
            try {
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.SaveDataItems)) {
                    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(
                        Properties.Settings.Default.SaveDataItems))) {
                        BinaryFormatter bf = new BinaryFormatter();
                        return (List<Item>)bf.Deserialize(ms);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message + "\nThe application will proceed as normal.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return new List<Item>();
		}

		// To load History Items
		List<Item> LoadHistoryItems() {
            try {
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.SaveHistoryItems)) {
                    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(
                        Properties.Settings.Default.SaveHistoryItems))) {
                        BinaryFormatter bf = new BinaryFormatter();
                        return (List<Item>)bf.Deserialize(ms);
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message + "\nThe application will proceed as normal.", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
			return new List<Item>();
		}

        // To load EmailSettings
        EmailSettings LoadEmailSettings() {
            EmailSettings loadSettings = new EmailSettings(
                Properties.Settings.Default.EmailAddress,
                Properties.Settings.Default.EmailPassword,
                Properties.Settings.Default.EmailSubject,
                Properties.Settings.Default.EmailBody
                );
            return loadSettings;
        }

		// Save the objects
		private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
			if (!upgrading) {
				// Make a List<Item> for DataItems first.
				List<Item> DataItems = new List<Item>();
				foreach (DataGridViewRow item in dataGridView1.Rows) {
					string firstName = item.Cells[1].Value.ToString();
					string lastName = item.Cells[2].Value.ToString();
					string UMID = item.Cells[3].Value.ToString();
					string Uniq = item.Cells[4].Value.ToString();
					string checkoutTime = item.Cells[5].Value.ToString();
					string itemCat = item.Cells[6].Value.ToString();
					string itemDesc = item.Cells[7].Value.ToString();
					string dueDate = item.Cells[8].Value.ToString();
					string staffOut = item.Cells[9].Value.ToString();
					DataItems.Add(new Item(firstName, lastName, UMID, Uniq, checkoutTime,
						itemCat, itemDesc, dueDate, staffOut));
				}
				// Now save the items.
				SaveItems(DataItems, HistoryItems);
			}
		}

		// Also checks for Updates
		// Opens the objects
		// Also flags a row red when an item is overdue.
		private void Form1_Load(object sender, EventArgs e) {
			// Check Update
			Check_Update();
			// Open/Load objects into Lists / string / DataGridView
			LastHistoryClear = Properties.Settings.Default.LastHistClear;
			HistoryItems = LoadHistoryItems();
			List<Item> DataItems = LoadDataItems();
			foreach (Item item in DataItems) {
				DataGridViewButtonColumn button = new DataGridViewButtonColumn();
				string firstName = item.nameFirst;
				string lastName = item.nameLast;
				string UMID = item.UMID;
				string Uniq = item.uniq;
				string checkoutTime = item.checkOutTime;
				string itemCat = item.itemCat;
				string itemDesc = item.itemDesc;
				string dueDate = item.dueDate;
				string staffOut = item.staffOut;
				// Adding to the dataGridView
				dataGridView1.Rows.Add(button, firstName, lastName, UMID, 
					Uniq, checkoutTime, itemCat, itemDesc, dueDate, staffOut);
				int end_index = dataGridView1.Rows.Count - 1;
				dataGridView1.Rows[end_index].Cells[0].Value = "In";
			}
			dataGridView1.ClearSelection();
            // Load Email Settings
            emailSettings = LoadEmailSettings();
		}

        // Prompt when the form is being shown
        private void Form1_Shown(object sender, EventArgs e) {
            // Check each item if overdue. If so, mark entire row red.
            int overdueItems = 0;
            foreach (DataGridViewRow item in dataGridView1.Rows) {
                string dueDate = item.Cells[8].Value.ToString();
                if (Is_Overdue(dueDate)) {
                    // Mark every cell in the row as Red.
                    foreach (DataGridViewCell cell in item.Cells) {
                        cell.Style.BackColor = Color.LightCoral;
                        overdueItems++;
                    }
                }
            }
            // Send Emails right away upon launch.
            if (overdueItems > 0) {
                if (MessageBox.Show("There are overdue items! Would you like to send Emails?", "Send Emails",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    // Loop through and mark
                    foreach (DataGridViewRow item in dataGridView1.Rows) {
                        string dueDate = item.Cells[8].Value.ToString();
                        if (Is_Overdue(dueDate)) {
                            // Mark every cell in the row as Red.
                            foreach (DataGridViewCell cell in item.Cells) {
                                cell.Style.BackColor = Color.LightSeaGreen;
                            }
                            // Send Email function
                            string firstName = item.Cells[1].Value.ToString();
                            string lastName = item.Cells[2].Value.ToString();
                            string uniq = item.Cells[4].Value.ToString();
                            string itemCat = item.Cells[6].Value.ToString();
                            string itemDesc = item.Cells[7].Value.ToString();
                            send_Email(firstName, lastName, itemCat, itemDesc, dueDate, uniq);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
