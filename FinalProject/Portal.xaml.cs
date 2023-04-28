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
    public partial class Portal : Window
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void UserButtonClick(object sender, RoutedEventArgs e)
        {
            LogIn r1 = new LogIn();
            this.Close();
            r1.Show();

        }

        private void AdminButtonClick(object sender, RoutedEventArgs e)
        {
            AdminLog r2 = new AdminLog();
            this.Close();
            r2.Show();

        }
    }
}
