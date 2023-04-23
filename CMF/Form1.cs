using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace CMF
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> _clients;
        public Form1()
        {
            InitializeComponent();
            InitializeClients();
            InitializeHistoryTextBox();
        }

        private void InitializeClients()
        {
            _clients = new Dictionary<string, string>
            {
                // Set up the client list with IDs and names
                {"0001", "Jake Decker"},
                {"0002", "Michaela Mercado"},
                {"0003", "Esther Owens"},
                {"0004", "Saira Cline"},
                {"0005", "Kaya Velazquez"},
                {"0006", "Francis Ashley"},
                {"0007", "Zachary Johnson"},
                {"0008", "Sahar Marquez"},
                {"0009", "Miles Lester"},
                {"0010", "Ruth Meadows"},
                {"0011", "Andrea Vega"},
                {"0012", "Zachariah Gray"},
                {"0013", "Ruairi Fisher"},
                {"0014", "Dorothy Ford"},
                {"0015", "Haseed Parker"},
                {"0016", "Maisha Holland"},
                {"0017", "Josephine Morales"},
                {"0018", "Jaxon Ochoa"},
            };

            // Populate the ComboBox with client names
            foreach (var client in _clients)
            {
                clientComboBox.Items.Add($"{client.Key} - {client.Value}");
            }
        }



        private void InitializeHistoryTextBox()
        {
            // Set the hard-coded history data
            string historyData = "ClientID - Name - Service Date - Service Type\n" +
                                 "0001 - Jake Decker - 2023-01-02 - Consultation\n" +
                                 "0005 - Kaya Velazquez - 2023-01-03 - Service A\n" +
                                 "0009 - Miles Lester - 2023-01-04 - Service B";
            HistoryTextBox.Text = historyData;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Handle form submission, validation, and any other required functionality here

            // Perform basic validation (e.g., check if text boxes are not empty)
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(lastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(memberIdTextBox.Text) ||
                string.IsNullOrWhiteSpace(emailTextBox.Text) ||
                string.IsNullOrWhiteSpace(birthdayTextBox.Text) ||
                string.IsNullOrWhiteSpace(genderTextBox.Text) ||
                string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneTextBox.Text) ||
                string.IsNullOrWhiteSpace(concessionTextBox.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Perform additional validation if necessary

            // Process form data
            // You can save the data to a file, database, or perform other actions as needed
            MessageBox.Show("Form submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear the text boxes for the next submission
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            memberIdTextBox.Clear();
            emailTextBox.Clear();
            birthdayTextBox.Clear();
            genderTextBox.Clear();
            addressTextBox.Clear();
            phoneTextBox.Clear();
            concessionTextBox.Clear();
        }

        private void clientComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected client ID and name
            string selectedClient = clientComboBox.SelectedItem.ToString();
            string[] clientData = selectedClient.Split(" - ");
            string clientId = clientData[0];
            string clientName = clientData[1];

            // Display the selected client's information in the clientInfoTextBox
            clientInfoTextBox.Text = $"Client ID: {clientId}\nClient Name: {clientName}";
        }
    }
}