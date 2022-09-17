using Microsoft.Extensions.DependencyInjection;
using Registro.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using Registro.Service.IRepositories;
using Registro.Core.Repositories;
using Registro.Service.IConfiguration;

namespace Registro_22
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>

    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTg2MTc1QDMxMzkyZTM0MmUzMExiaEV6RjdONDlJNG9mOWtWZTNUekttWXRudndFZmFwTEVFemFXZU5ZS3M9");
        }
        private void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<RegistroDBContext>(options =>
            {
                options.UseSqlServer("Data Source = Employee.db");
            });
            services.AddSingleton<MainWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

        public void DataServices(ServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
            
        }
    }
}
