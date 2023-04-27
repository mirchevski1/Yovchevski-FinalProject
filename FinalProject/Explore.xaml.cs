using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
public partial class Explore : Window
    {
        private string connectionString = (@"Server=DESKTOP-U43FOB2\MSSQLSERVER01;Database=InformaticsFinalProject;Integrated Security=True");

        public Explore()
        {
            InitializeComponent();
            ObservableCollection<Vehicle> vehicles = new ObservableCollection<Vehicle>(GetVehiclesFromDatabase());
            myItemsControl.ItemsSource = vehicles;
        }

        private List<Vehicle> GetVehiclesFromDatabase()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM vehicles", connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Vehicle vehicle = new Vehicle
                    {
                        Id = (int)reader["id"],
                        Model = (string)reader["model"],
                        Make = (string)reader["make"],
                        ColorExterior = (string)reader["color_exterior"],
                        ColorInterior = (string)reader["color_interior"],
                        Range = (int)reader["range"],
                        Owner = (int)reader["owner"],
                        Gearbox = (string)reader["gearbox"],
                        Engine = (string)reader["engine"],
                        Location = (string)reader["location"],
                        Accident = (int)reader["accident"],
                        Year = (int)reader["yearOfProduction"],
                        Price = (int)reader["price"]
                    };
                    vehicles.Add(vehicle);
                }
            }
            return vehicles;
        }

        public class Vehicle
        {
            public int Id { get; set; }
            public string Model { get; set; }
            public string Make { get; set; }
            public string ColorExterior { get; set; }
            public string ColorInterior { get; set; }
            public int Range { get; set; }
            public int Owner { get; set; }
            public string Gearbox { get; set; }
            public string Engine { get; set; }
            public string Location { get; set; }
            public int Accident { get; set; }
            public int Year { get; set; }
            public int Price { get; set; }
        }
    }
}

