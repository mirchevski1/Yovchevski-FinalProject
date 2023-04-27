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

        private void Button_911(object sender, RoutedEventArgs e)
        {
            Explore obj = new Explore();
            this.Close();
            obj.Show();
        }
    }
}
