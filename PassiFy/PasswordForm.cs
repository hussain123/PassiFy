using System;
using System.Windows.Forms;


namespace PassiFy
{
    public partial class PasswordForm : Form
    {

        public PasswordForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var passwordGenerator = new PasswordGenerator();
            var desiredLength = int.Parse(passwordLengthTextBox.Text);
            var password = passwordGenerator.GeneratePassword(desiredLength);
            SetResultText(password);
        }

        private void SetResultText(string password)
        {
            generatedPaswordTextBox.Clear();
            generatedPaswordTextBox.Text += password;
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
