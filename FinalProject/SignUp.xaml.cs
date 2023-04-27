using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private SqlConnection dbConnection;

        private void SignupButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-U43FOB2\MSSQLSERVER01;Database=InformaticsFinalProject;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[userAccount] VALUES(@first_name,@last_name,@password,@email)";
                SqlCommand cmd = new SqlCommand(add_data, con);
                cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Password);
                cmd.ExecuteNonQuery();
                con.Close();

                LogIn obj = new LogIn();
                obj.Show();
                this.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
            //if (passwordBox.Password != repeatBox.Password)
            //{
            //    MessageBox.Show("Passwords don't match.");
            //}
            //else
            //{
            //    string email = emailBox.Text.Trim();
            //    string firstName = firstBox.Text.Trim();
            //    string lastName = lastBox.Text.Trim();
            //    string password = passwordBox.Password;

            //    if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            //    {
            //        MessageBox.Show("Please fill in all fields.");
            //        return;
            //    }



            //    using (var checkCommand = new SqlCommand("SELECT COUNT(*) FROM userAccount WHERE email=@email", dbConnection))
            //    {
            //        checkCommand.Parameters.AddWithValue("@email", email);
            //        object result = checkCommand.ExecuteScalar();
            //        int count = Convert.ToInt32(result);

            //        if (count > 0)
            //        {
            //            MessageBox.Show("Email already exists. Please choose a different username.");
            //            return;
            //        }
            //    }



            //    using (var insertCommand = new SqlCommand("INSERT INTO userAccount(first_name, last_name, password, gender, email) VALUES (@email, @password)", dbConnection))
            //    {
            //        insertCommand.Parameters.AddWithValue("@first_name", firstName);
            //        insertCommand.Parameters.AddWithValue("@last_name", lastName);
            //        insertCommand.Parameters.AddWithValue("@email", email);
            //        insertCommand.Parameters.AddWithValue("@password", password);
            //        insertCommand.ExecuteNonQuery();
            //    }


            //    dbConnection.Close();

            //    // Show a message box to indicate success
            //    //MessageBox.Show("Account created successfully!");

            //    LogIn obj = new LogIn();
            //    obj.Show();
            //    this.Close();
            //}
        }
    }
}
