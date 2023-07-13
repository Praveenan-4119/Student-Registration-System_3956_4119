using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Student_Registration_System_3956_4119
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new Login_Data_Context());
            facade.EnsureCreated();
            DatabaseFacade facade1 = new DatabaseFacade(new Student_Data_Context());
            facade1.EnsureCreated();

        }
    }
}
