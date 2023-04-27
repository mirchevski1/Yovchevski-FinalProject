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
    /// Interaction logic for AddCar.xaml
    /// </summary>
    public partial class AddCar : Window
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void UploadButton(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=DESKTOP-U43FOB2\MSSQLSERVER01;Database=InformaticsFinalProject;Integrated Security=True");
                con.Open();

                string add_data = "INSERT INTO [dbo].[vehicles] VALUES(@model,@make,@color_exterior,@color_interior, @range, @owner, @gearbox, @engine, @location, @yearOfProduction, @price, @accident)";
                SqlCommand cmd = new SqlCommand(add_data, con);
                cmd.Parameters.AddWithValue("@model", model.Text);
                cmd.Parameters.AddWithValue("@make", make.Text);
                cmd.Parameters.AddWithValue("@color_exterior", color_exterior.Text);
                cmd.Parameters.AddWithValue("@color_interior", color_interior.Text);
                cmd.Parameters.AddWithValue("@range", range.Text);
                cmd.Parameters.AddWithValue("@owner", owner.Text);
                cmd.Parameters.AddWithValue("@gearbox", gearbox.Text);
                cmd.Parameters.AddWithValue("@engine", engine.Text);
                cmd.Parameters.AddWithValue("@location", location.Text);
                cmd.Parameters.AddWithValue("@accident", accident.Text);
                cmd.Parameters.AddWithValue("@yearOfProduction", yearOfProduction.Text);
                cmd.Parameters.AddWithValue("@price", price.Text);
                cmd.ExecuteNonQuery();
                con.Close();

                model.Text = "";
                make.Text = "";
                color_exterior.Text = "";
                color_interior.Text = "";
                range.Text = "";
                owner.Text = "";
                gearbox.Text = "";
                engine.Text = "";
                location.Text = "";
                accident.Text = "";
                yearOfProduction.Text = "";
                price.Text = "";

                MessageBox.Show("Vehicle added succesfully.");

                CarList obj = new CarList();
                obj.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReviewButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
