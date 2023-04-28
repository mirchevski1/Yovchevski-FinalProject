using System;
using System.Collections.Generic;
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
    public partial class CarList : Window
    {
        public CarList()
        {
            InitializeComponent();
        }

        public static string myModel;

        private void Button_911(object sender, RoutedEventArgs e)
        {
            myModel = "911";
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }

        private void Button_718(object sender, RoutedEventArgs e)
        {
            myModel = "718";
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }

        private void Button_Taycan(object sender, RoutedEventArgs e)
        {
            myModel = "Taycan";
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }

        private void Button_Panamera(object sender, RoutedEventArgs e)
        {
            myModel = "Panamera";
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }

        private void Button_Cayenne(object sender, RoutedEventArgs e)
        {
            myModel = "Cayenne";
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }

        private void Button_Macan(object sender, RoutedEventArgs e)
        {
            myModel = "Macan";
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }
    }
}
