using System.Diagnostics;
using System.Data.SqlClient;

namespace handcricket2
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string target = "https://www.github.com/faizan45640";


            Process.Start(new ProcessStartInfo { FileName = target, UseShellExecute = true });




        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            WrongCredentials.Visible = false;
            MissingUsername.Visible = false;
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            //connect to database

            SqlConnection connection = DatabseConnection.GetConnection();
            //open connection
            connection.Open();
            //insert data
            string username = UsernnameTXT.Text;
            string password = PasswordTXT.Text;
            
            
            if (username == "" || password == "")
            {
                if (username == "")
                {
                    MissingUsername.Visible = true;
                    

                }
                if (password == "")
                {
                    MissingPassword.Visible = true;
                }
                return;
            }
            
           //verify credentials
           string query = "select * from Player where userName='" + username + "' and password='" + password + "'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                //OPEN MAIN FORM
              //  Main f = new Main();
              //  f.Show();
              //  this.Hide();
              MessageBox.Show("Login Successful");
                //open main screen
            }
            else
            {
                //show error
                WrongCredentials.Visible = true;
            }


            //OPEN LOGIN form

        }

        private void PasswordTXT_TextChanged(object sender, EventArgs e)
        {
            MissingPassword.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 f=new Form1();
            f.Show();
            this.Hide();

        }
    }
}
