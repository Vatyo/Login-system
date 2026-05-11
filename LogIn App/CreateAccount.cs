using Microsoft.VisualBasic.Logging;

namespace LogIn_App
{
    public partial class CreateAccount : Form
    {
        private object txtpassword;
        private object txtPassword;
        private string filePath;

        

        public CreateAccount()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        { }


        private void CreateAccount_Load(object sender, EventArgs e)
        {


        }

        private void txtUsername1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {   //code for Create Account
            string newPassword = txtpassword1.Text;
            string configPass = txtconfpass2.Text;
            string username = txtUsername.Text;           
            try
            {   //check if the box are empty
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(configPass) || string.IsNullOrEmpty(newPassword))
                {
                    MessageBox.Show("Please fields the empty box");
                }
                else if (newPassword == configPass)
                {
                    MessageBox.Show("Account created!");
                }
                else
                    MessageBox.Show("Password do not match!");

            }
            catch { }




        }


        private void txtpassword1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconfpass2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Close();
        }

    }
}

