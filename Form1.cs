using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;

namespace ProApp
{
    public partial class Form1 : Form
    {
        static bool loaded = false;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2062678\Desktop\ProApp\ProApp\Database1.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            if (!loaded)
            {
                SaveXml.LoadAll();
                loaded = true;
            }

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            SaveXml.SaveAll();
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {



            var user = GetUser(userBox.Text, pssBox.Text);

            if (user != null)
            {
                switch (user.Membership)
                {
                    case 1:
                        MainUser mainUser = new MainUser(user);
                        this.Hide();
                        mainUser.Show();
                        break;
                    case 2:
                        SpplierMain supplierForm = new SpplierMain(user);
                        this.Hide();
                        supplierForm.Show();
                        break;
                    case 3:
                        MainStaff staffForm = new MainStaff(user);
                        this.Hide();
                        staffForm.Show();
                        break;
                }
            }

            /*
            if (userBox.Text == "Staff" && pssBox.Text == "staff123")
            {
                MainStaff staffForm = new MainStaff();
                this.Hide();
                staffForm.Show();
            }
            else if (userBox.Text == "Supplier" && pssBox.Text == "supplier123")
            {
                SpplierMain staffForm = new SpplierMain();
                this.Hide();
                staffForm.Show();
            }
            else if (userBox.Text == "User" && pssBox.Text == "user123") { 
                MainUser mainUser = new MainUser();
                this.Hide();
                mainUser.Show();
            }

            
            else
            {

                Con.Open();
                string query = "select UserID from UserTabel where Username = '" + userBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Con);
                int userId = (int)cmd.ExecuteScalar();
                Con.Close();
                if (userId == 15)
                {
                    MainUser staffForm = new MainUser();
                    this.Hide();
                    staffForm.Show();
                }
                else if (userId == 16)
                {
                    User2 staffForm = new User2();
                    this.Hide();
                    staffForm.Show();
                }
            }
            */
        }

        public User GetUser(string userName, string passWord)
        {
            StreamReader reader = new StreamReader("users.txt");

            while (!reader.EndOfStream)
            {
                var profile = reader.ReadLine().Split(",", 3);
                if (profile[0].Equals(userName))
                {
                    if (profile[1].Equals(passWord))
                    {
                        return new User(profile[0], profile[1], int.Parse(profile[2]));
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                }
            }
            MessageBox.Show("Username not found. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return null;
        }

        private void viewButton_Click_2(object sender, EventArgs e)
        {
            if (pssBox.PasswordChar == '*')
            {
                hideButton.BringToFront();
                pssBox.PasswordChar = '\0';
            }
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            if (pssBox.PasswordChar == '\0')
            {
                viewButton.BringToFront();
                pssBox.PasswordChar = '*';
            }
        }

        private void ClearFiledLabel_Click_1(object sender, EventArgs e)
        {
            userBox.Clear();
            pssBox.Clear();
        }
    }

}


