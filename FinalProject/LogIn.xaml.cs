using System;
using System.Collections.Generic;
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
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-U43FOB2\MSSQLSERVER01;Database=InformaticsFinalProject;Integrated Security=True");
                con.Open();
                string add_data = "SELECT * FROM [dbo].[userAccount] WHERE email=@email AND password=@password";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Password);
                cmd.ExecuteNonQuery();
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                //string countStr = count.ToString();

                //MessageBox.Show(countStr);

                if(count > 0)
                {
                    CarList obj = new CarList();
                    this.Close();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("User credentials are not correct.");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
