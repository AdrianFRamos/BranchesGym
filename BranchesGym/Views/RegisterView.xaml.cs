using System.Windows;
using System.Windows.Controls;
using BranchesGym.ViewModels;

namespace BranchesGym.Views
{
    public partial class RegisterView : Window
    {
        public RegisterView(RegisterViewModel viewModel)
        {
            InitializeComponent();
            DataContext = viewModel ?? throw new ArgumentNullException(nameof(viewModel), "O ViewModel não foi injetado corretamente.");
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is RegisterViewModel viewModel && sender is PasswordBox passwordBox)
            {
                viewModel.Senha = passwordBox.Password;
            }
        }
    }
}
