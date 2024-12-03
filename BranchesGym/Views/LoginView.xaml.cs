using System.Windows;
using System.Windows.Controls;
using BranchesGym.Services;
using BranchesGym.ViewModels;

namespace BranchesGym.Views
{
    public partial class LoginView : Window
    {
        public LoginView(LoginViewModel viewModel)
        {
            InitializeComponent();

            if (viewModel == null)
                throw new ArgumentNullException(nameof(viewModel), "O ViewModel não foi injetado corretamente.");

            DataContext = viewModel;
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is LoginViewModel viewModel && sender is PasswordBox passwordBox)
            {
                viewModel.Password = passwordBox.Password;
            }
        }

    }
}
