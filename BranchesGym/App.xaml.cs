using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
using BranchesGym.Services;
using BranchesGym.Data;
using BranchesGym.ViewModels;
using BranchesGym.Views;

namespace BranchesGym
{
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            try
            {
                    // Configurar os serviços
                    var serviceCollection = new ServiceCollection();

                ConfigureServices(serviceCollection);

                // Construir o ServiceProvider
                ServiceProvider = serviceCollection.BuildServiceProvider();

                // Inicializar a primeira janela (LoginView)
                var mainWindow = ServiceProvider.GetRequiredService<LoginView>();
                if (mainWindow == null)
                {
                    throw new InvalidOperationException("A LoginView não foi resolvida corretamente.");
                }
                mainWindow.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar a aplicação: {ex.Message}", "Erro Fatal", MessageBoxButton.OK, MessageBoxImage.Error);
                Shutdown();
            }
        }

        private void ConfigureServices(IServiceCollection services)
        {
            try
            {
                // Registrar DatabaseContext (Escopo Controlado)
                services.AddScoped<DatabaseContext>();

                // Registrar Serviços
                services.AddSingleton<AuthService>();
                services.AddSingleton<WindowService>();

                // Registrar ViewModels
                services.AddTransient<LoginViewModel>();
                services.AddTransient<RegisterViewModel>();

                // Registrar Views
                services.AddTransient<LoginView>();
                services.AddTransient<RegisterView>();

                Console.WriteLine("Serviços registrados com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao configurar serviços: {ex.Message}");
                throw;
            }
        }

    }
}
