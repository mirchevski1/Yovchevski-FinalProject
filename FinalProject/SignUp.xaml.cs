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

                string check_data = "SELECT COUNT(*) FROM [dbo].[userAccount] WHERE email=@email";
                SqlCommand cmd_check = new SqlCommand(check_data, con);
                cmd_check.Parameters.AddWithValue("@email", email.Text);
                int count = Convert.ToInt32(cmd_check.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("An account with these credentials already exists. Please log in");
                    LogIn w1 = new LogIn();
                    w1.Show();
                    this.Close();
                }
                else
                {
                    string add_data = "INSERT INTO [dbo].[userAccount] VALUES(@first_name,@last_name,@password,@email)";
                    SqlCommand cmd = new SqlCommand(add_data, con);
                    cmd.Parameters.AddWithValue("@first_name", first_name.Text);
                    cmd.Parameters.AddWithValue("@last_name", last_name.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@password", password.Password);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    CarList obj = new CarList();
                    obj.Show();
                    this.Close();

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
