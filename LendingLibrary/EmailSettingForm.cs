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
    public partial class EmailSettingForm : Form
    {
        private bool button_clicked;

        public EmailSettingForm() {
            InitializeComponent();
            button_clicked = false;
        }

        public void EmailSetting_Dialog(ref EmailSettings settings) {
            textBox_Address.Text = settings.get_Address();
            textBox_Password.Text = settings.get_Password();
            textBox_Subject.Text = settings.get_Subject();
            richTextBox_Body.Text = settings.get_Body();
            ShowDialog();
            if (button_clicked) {
                // Save the settings
                settings.set_Settings(
                    textBox_Address.Text,
                    textBox_Password.Text,
                    textBox_Subject.Text,
                    richTextBox_Body.Text
                    );
            }
        }

        // Event Handler
        private void button_Save_Click(object sender, EventArgs e) {
            Close();
            button_clicked = true;
        }
    }
}
