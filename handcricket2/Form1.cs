using System.Diagnostics;

namespace handcricket2
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            RegisterUser registerUser = new RegisterUser();
            registerUser.Show();
            this.Hide();
        }
    }
}
