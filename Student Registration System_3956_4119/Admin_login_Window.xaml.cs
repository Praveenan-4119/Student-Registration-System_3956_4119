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
    
    public partial class Admin_login_Window : Window
    {
        public Admin_login_Window()
        {
            InitializeComponent();
        }

        private void Admin_Login_Click(object sender, RoutedEventArgs e)
        {
            var AdminUsername = AdminUser.Text;
            var AdminPassword = AdminPwd.Password;

            using (Login_Data_Context context = new Login_Data_Context())
            {
                bool Adminfound = context.Users.Any(user => user.Username == AdminUsername && user.Password == AdminPassword);

                if (Adminfound)
                {
                    GrantAccess_Admin();
                    Close();
                }
                else
                {
                    MessageBox.Show("Wrong User Name or Password");
                }
            }
        }

        public void GrantAccess_Admin()
        {
            User_Details user_Details = new User_Details();
            user_Details.Show();
        }

        private void Admin_txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AdminUser.Text) && AdminUser.Text.Length > 0)
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
            AdminUser.Focus();
        }


        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AdminPwd.Focus();
        }



        private void Admin_txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(AdminPwd.Password) && AdminPwd.Password.Length > 0)
            {
                textPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                textPassword.Visibility = Visibility.Visible;
            }
        }

        private void ShowPasswordButton_Click(object sender, RoutedEventArgs e)
        {
            AdminPwd.Visibility = Visibility.Collapsed;
            ShowPasswordButton.Visibility = Visibility.Collapsed;
            HidePasswordButton.Visibility = Visibility.Visible;
            textPassword.Text = AdminPwd.Password;
            textPassword.Visibility = Visibility.Visible;

            
        }

        private void HidePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            textPassword.Visibility = Visibility.Collapsed;
            HidePasswordButton.Visibility = Visibility.Collapsed;
            ShowPasswordButton.Visibility = Visibility.Visible;
            AdminPwd.Password = textPassword.Text;
            AdminPwd.Visibility = Visibility.Visible;
        }
    }
}
