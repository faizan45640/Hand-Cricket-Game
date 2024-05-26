using System.Diagnostics;
using System.Data.SqlClient;

namespace handcricket2
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
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
            usernamealreadylabel.Visible = false;
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
            string gender;
            if (MaleRdioBTN.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            if(username=="" || password=="")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            //check for already existing username
            string query = "select * from Player where userName='"+username+"'";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                usernamealreadylabel.Visible = true;
                return;
            }
            connection.Close();
            connection.Open();
            query = "insert into Player(userName,password,gender) VALUES('" + username + "','"+password+"','"+gender+"')"; 
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User Registered Successfully");


            //OPEN LOGIN form
          
        }
    }
}
