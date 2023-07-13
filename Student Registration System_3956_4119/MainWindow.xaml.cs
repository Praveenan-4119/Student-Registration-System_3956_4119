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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Student_Registration_System_3956_4119
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            var aw = new Admin_login_Window();
            aw.Show();
        }

        private void User_Click(object sender, RoutedEventArgs e)
        {
            var uw = new User_login_Window();
            uw.Show();
        }
    }
}
