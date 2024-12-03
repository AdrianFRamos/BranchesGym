using System.Windows;
using BranchesGym.Views;
using Microsoft.Extensions.DependencyInjection;

namespace BranchesGym.Services
{
    public class WindowService
    {
        private readonly IServiceProvider _serviceProvider;

        public WindowService(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void Minimize(Window window)
        {
            if (window != null)
            {
                window.WindowState = WindowState.Minimized;
            }
        }

        public void Close(Window window)
        {
            window?.Close();
        }

        public void OpenDashboard()
        {
            // Abre a janela do Dashboard
            var dashboard = new DashboardView();
            dashboard.Show();
        }

        public void OpenRegisterView()
        {
            var registerView = _serviceProvider.GetRequiredService<RegisterView>();
            registerView.Show();
        }
    }
}
