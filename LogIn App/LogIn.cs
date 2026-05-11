using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;
using Microsoft.VisualBasic.Logging;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace LogIn_App
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_BackColorChanged(object sender, EventArgs e)
        {

        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtpassword.Text;

            //setting account 
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("LogIn successfull");
                new LogIn().Show();
               
                
            }
            else
            {
               MessageBox.Show("Your Password or UserName is wrong." +
                "Try again or create new account");
            }
            

        }
        private void SaveUserData(string username, string password)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   //code for exit button
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {      //code for openinh new form
            CreateAccount createA = new CreateAccount();
            createA.Show();
            this.Hide();

        }

        private void checkbxshowpass_CheckedChanged(object sender, EventArgs e)
        {   //code for checkbox
            if (checkbxshowpass.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
 