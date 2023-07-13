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

namespace Student_Registration_System_3956_4119
{
    
    public partial class User_Details : Window
    {
        public User_Details()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {


            using (Login_Data_Context context = new Login_Data_Context())
            {
                var Uname = Usertxt.Text;
                var Upassword = pwd.Text;

                if (Uname != null && Upassword != null)
                {
                    context.Users.Add(new User() { Username = Uname, Password = Upassword });
                    context.SaveChanges();
                    MessageBox.Show("Account has successfully Created.");
                }

            }


        }

        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Usertxt.Text) && Usertxt.Text.Length > 0)
            {
                textName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textName.Visibility = Visibility.Visible;
            }
        }

        private void textName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Usertxt.Focus();
        }


        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            pwd.Focus();
        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(pwd.Text) && pwd.Text.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }

        }


    }
}
