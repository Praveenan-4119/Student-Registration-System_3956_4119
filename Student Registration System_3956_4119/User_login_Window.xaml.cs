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
   
    public partial class User_login_Window : Window
    {
        public User_login_Window()
        {
            InitializeComponent();
        }

        private void Normal_User_Login_Click(object sender, RoutedEventArgs e)
        {

            {
                var NormalUsername = NormalUser.Text;
                var NormalPassword = NormalPwd.Password;

                using (Login_Data_Context context = new Login_Data_Context())
                {
                    bool userfound = context.Users.Any(user => user.Username == NormalUsername && user.Password == NormalPassword);

                    if (userfound)
                    {
                        GrantAccess_User();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong User Name or Password");
                    }
                }
            }

            void GrantAccess_User()
            {
                StudentRegistration_Window Student_Registration = new StudentRegistration_Window();
                Student_Registration.Show();
            }
        }

        

        private void textName_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NormalUser.Focus();
        }


        private void textPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            NormalPwd.Focus();
        }

        


        private void User_txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NormalUser.Text) && NormalUser.Text.Length > 0)
            {
                textName.Visibility = Visibility.Collapsed;
            }
            else
            {
                textName.Visibility = Visibility.Visible;
            }

        }

        private void User_txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(NormalPwd.Password) && NormalPwd.Password.Length > 0)
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
            NormalPwd.Visibility = Visibility.Collapsed;
            ShowPasswordButton.Visibility = Visibility.Collapsed;
            HidePasswordButton.Visibility = Visibility.Visible;
            textPassword.Text = NormalPwd.Password;
            textPassword.Visibility = Visibility.Visible;
        }

        private void HidePasswordButton_Click(object sender, RoutedEventArgs e)
        {
            textPassword.Visibility = Visibility.Collapsed;
            HidePasswordButton.Visibility = Visibility.Collapsed;
            ShowPasswordButton.Visibility = Visibility.Visible;
            //NormalPwd.Password = textPassword.Text;
            NormalPwd.Visibility = Visibility.Visible;
        }


    }
}
