using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibrary
{
    [Serializable()]
    public class EmailSettings
    {

        // Member variables
        private string emailAddress;
        private string password;
        private string emailFrom;
        private string emailSubject;
        private string emailBody;

        // Default Constructor
        public EmailSettings() { }

        // Constructor
        public EmailSettings(string address_, string pw_,
            string from_, string subject_, string body_) {
            set_Settings(address_, pw_, from_, subject_, body_);
        }

        // Public getter functions
        public string get_Address() {
            return emailAddress;
        }

        public string get_Password() {
            return password;
        }

        public string get_From() {
            return emailFrom;
        }

        public string get_Subject() {
            return emailSubject;
        }

        public string get_Body() {
            return emailBody;
        }

        // Set entirety functions (copy and paste of constructor)
        public void set_Settings(string address_, string pw_,
            string from_, string subject_, string body_) {
            emailAddress = address_;
            password = pw_;
            emailFrom = from_;
            emailSubject = subject_;
            emailBody = body_;
        }
    }
}
