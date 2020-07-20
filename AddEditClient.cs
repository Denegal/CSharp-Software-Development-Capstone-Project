using Backend_DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Development_Capstone
{
    public partial class AddEditClient : Form
    {
        private bool WaiverChecked = false;
        private bool MedicalChecked = false;
        private bool PregnantChecked = false;
        private bool InjuryChecked = false;
        private bool HistoryChecked = false;

        private int modifyClientID = -1;

        // Default constructor used when adding a new client
        public AddEditClient()
        {
            InitializeComponent();

            label_Title.Text = "New Client";
        }

        // Overloaded constructor used when editing an existing client
        public AddEditClient(int id)
        {
            InitializeComponent();

            label_Title.Text = "Existing Client";
            modifyClientID = id;

            using (var context = new Backend_DB.DBEntities())
            {

                var modify_client = (from clients in context.Clients where clients.ClientId == modifyClientID select clients).First();

                textbox_FName.Text = modify_client.FName.Trim(' ');
                textbox_LName.Text = modify_client.LName.Trim(' ');
                textbox_Phone.Text = modify_client.Phone.Trim(' ');
                textbox_Email.Text = modify_client.Email.Trim(' ');

                textbox_EContact.Text = modify_client.EmergencyContact.Trim(' ');
                textbox_EContactPhone.Text = modify_client.EmergencyContactPhone.Trim(' ');

                if (modify_client.Waiver == 1) { checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; WaiverChecked = true; }
                if (modify_client.Pregnant == 1) { checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; PregnantChecked = true; }
                if (modify_client.MedicalCare == 1) { checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox; MedicalChecked = true; }

                if (modify_client.Injuries != "")
                {
                    InjuryChecked = true;
                    checkbox_Injury.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
                    textbox_Injuries.Enabled = true;
                    textbox_Injuries.Text = modify_client.Injuries;
                }

                if (modify_client.MedicalHistory != "")
                {
                    HistoryChecked = true;
                    checkbox_History.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
                    combo_History.Enabled = true;
                    button_Add.Enabled = true;
                    button_Remove.Enabled = true;
                    textbox_MedicalHistory.Text = modify_client.MedicalHistory;
                }
            }
                


        }

        // Code for enabling checkbox functionality
        private void checkbox_Waiver_Click(object sender, EventArgs e)
        {
            if (WaiverChecked)
            {
                checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Waiver.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            WaiverChecked = !WaiverChecked;
        }

        private void checkbox_Pregnant_Click(object sender, EventArgs e)
        {
            if (PregnantChecked)
            {
                checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Pregnant.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            PregnantChecked = !PregnantChecked;
        }

        private void checkbox_Medical_Click(object sender, EventArgs e)
        {
            if (MedicalChecked)
            {
                checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_Medical.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            MedicalChecked = !MedicalChecked;
        }

        private void checkbox_Injury_Click(object sender, EventArgs e)
        {
            if (InjuryChecked)
            {
                checkbox_Injury.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
                
            }
            else
            {
                checkbox_Injury.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            InjuryChecked = !InjuryChecked;

            textbox_Injuries.Enabled = InjuryChecked;
        }

        private void checkbox_History_Click(object sender, EventArgs e)
        {
            if (HistoryChecked)
            {
                checkbox_History.BackgroundImage = Software_Development_Capstone.Properties.Resources.empty_checkbox;
            }
            else
            {
                checkbox_History.BackgroundImage = Software_Development_Capstone.Properties.Resources.checked_checkbox;
            }
            HistoryChecked = !HistoryChecked;

            combo_History.Enabled = HistoryChecked;
            button_Add.Enabled = HistoryChecked;
            button_Remove.Enabled = HistoryChecked;
        }
        // End of code for enabling checkbox functionality


        private void button_Add_Click(object sender, EventArgs e)
        {
            if (combo_History.SelectedItem != null && !textbox_MedicalHistory.Text.Contains(combo_History.SelectedItem.ToString()))
            {
                textbox_MedicalHistory.Text += combo_History.SelectedItem.ToString() + "\r\n";
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (combo_History.SelectedItem != null && textbox_MedicalHistory.Text.Contains(combo_History.SelectedItem.ToString()))
            {
                textbox_MedicalHistory.Text = textbox_MedicalHistory.Text.Replace(combo_History.SelectedItem.ToString() + "\r\n","");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEditClient_Load(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            using (var context = new Backend_DB.DBEntities())
            {
                // Perform form validation
                try { validate_form(); }
                catch (Exception error) { MessageBox.Show(error.Message); return; }

                // If modifyClientID == -1 then this is a new client to add to the database
                if (modifyClientID == -1)
                {
                    Backend_DB.Client newClient = new Backend_DB.Client
                    {
                        FName = textbox_FName.Text,
                        LName = textbox_LName.Text,
                        Phone = textbox_Phone.Text,
                        Email = textbox_Email.Text,
                        EmergencyContact = textbox_EContact.Text,
                        EmergencyContactPhone = textbox_EContactPhone.Text,

                        Waiver = WaiverChecked ? 1 : 0,
                        Pregnant = PregnantChecked ? 1 : 0,
                        MedicalCare = MedicalChecked ? 1 : 0,

                        Injuries = InjuryChecked ? textbox_Injuries.Text : "",
                        MedicalHistory = HistoryChecked ? textbox_MedicalHistory.Text : "",

                        ClassCredit = 0,
                        
                    };

                    context.Clients.Add(newClient);
                    context.SaveChanges();
                }
                else // If modifyClientID != -1 we are editing an existing client
                {
                    var modifyClient = from clients in context.Clients where clients.ClientId == modifyClientID select clients;

                    foreach (Backend_DB.Client client in modifyClient)
                    {
                        client.FName = textbox_FName.Text;
                        client.LName = textbox_LName.Text;
                        client.Phone = textbox_Phone.Text;
                        client.Email = textbox_Email.Text;
                        client.EmergencyContact = textbox_EContact.Text;
                        client.EmergencyContactPhone = textbox_EContactPhone.Text;

                        client.Waiver = WaiverChecked ? 1 : 0;
                        client.Pregnant = PregnantChecked ? 1 : 0;
                        client.MedicalCare = MedicalChecked ? 1 : 0;

                        client.Injuries = InjuryChecked ? textbox_Injuries.Text : "";
                        client.MedicalHistory = HistoryChecked ? textbox_MedicalHistory.Text : "";
                    }

                    context.SaveChanges();
                }

            }

            this.Close();
        }

        // Validate all the fields in the form to ensure it can be added to the database without issue.
        private void validate_form()
        {

            // Check if any required fields were left blank
            if (textbox_FName.Text == "" || textbox_LName.Text == "" || textbox_EContact.Text == "" || textbox_EContactPhone.Text == "")
            {
                throw new MissingFieldException("Client First and Last Name, and Emergency Contact information are required.");
            }

            // Check to ensure that Phone fields only have integer values
            try
            {
                if (textbox_Phone.Text != "")
                {
                    long.Parse(textbox_Phone.Text);
                }
                long.Parse(textbox_EContactPhone.Text);
            }
            catch
            {
                throw new ArgumentException("Phone or Emergency Contact Phone field is not valid. Please ensure field contains only numbers. Ex: 1234567890");
            }

            // Check to ensure that the email field is valid IF it is not empty
            if (textbox_Email.Text != "" && !validEmail(textbox_Email.Text))
            {
                throw new ArgumentException("Email not valid.");
            }

            // Check to make sure either phone OR email is provided
            if (textbox_Phone.Text == "" && textbox_Email.Text == "")
            {
                throw new MissingFieldException("Either Phone or Email must be provided.");
            }


            return;
        }

        private bool validEmail(string entry)
        {
            // MicrosoftDocs recommended RegEx expression to check for valid email address.
            // Taken from: https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            try
            {
                return Regex.IsMatch(entry,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // Only allow numbers to be put into the phone fields
        private void textbox_Phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox_EContactPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
