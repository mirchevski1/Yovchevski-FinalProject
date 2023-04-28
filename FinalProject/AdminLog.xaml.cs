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
    /// <summary>
    /// Interaction logic for AdminLog.xaml
    /// </summary>
    public partial class AdminLog : Window
    {
        public AdminLog()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-U43FOB2\MSSQLSERVER01;Database=InformaticsFinalProject;Integrated Security=True");
                con.Open();
                string add_data = "SELECT * FROM [dbo].[adminAccount] WHERE email=@email AND password=@password";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@password", password.Password);
                cmd.ExecuteNonQuery();
                int count = Convert.ToInt32(cmd.ExecuteScalar());


                if (count > 0)
                {
                    AddCar obj = new AddCar();
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
