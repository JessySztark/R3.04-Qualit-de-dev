using Calculatrice;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfCalculatriveV2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ServiceProvider Services { get; }
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<ICalcul, Calcul2>();
            Services = services.BuildServiceProvider();
        }
        public new static App Current => (App)Application.Current;
    }
}
