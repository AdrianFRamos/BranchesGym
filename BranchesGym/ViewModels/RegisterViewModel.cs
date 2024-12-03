using System;
using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using BranchesGym.Services;

namespace BranchesGym.ViewModels
{
    public class RegisterViewModel
    {
        private readonly AuthService _authService;
        private readonly WindowService _windowService;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public ICommand MinimizeCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand RegisterCommand { get; }

        public RegisterViewModel(AuthService authService, WindowService windowService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
            _windowService = windowService ?? throw new ArgumentNullException(nameof(windowService));

            MinimizeCommand = new RelayCommand(() => _windowService.Minimize(Application.Current.MainWindow));
            CloseCommand = new RelayCommand(() => _windowService.Close(Application.Current.MainWindow));
            RegisterCommand = new RelayCommand(ExecuteRegisterCommand);
        }

        private void ExecuteRegisterCommand()
        {
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Sobrenome) ||
                string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                _authService.Register(new Models.User
                {
                    Nome = Nome,
                    Sobrenome = Sobrenome,
                    Email = Email,
                    Senha = Senha,
                    TipoUsuario = "Cliente"
                });

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                _windowService.Close(Application.Current.MainWindow);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao registrar usuário: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
