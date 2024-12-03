using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;
using BranchesGym.Services;
using System.ComponentModel;

namespace BranchesGym.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private readonly AuthService _authService;
        private readonly WindowService _windowService;

        private string _email;
        private string _password;

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                // Notificar mudanças para bindings (INotifyPropertyChanged recomendado)
                OnPropertyChanged(nameof(Email));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                // Notificar mudanças para bindings (INotifyPropertyChanged recomendado)
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand MinimizeCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand EsqueciSenhaCommand { get; }
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }

        public LoginViewModel(AuthService authService, WindowService windowService)
        {
            _authService = authService ?? throw new ArgumentNullException(nameof(authService));
            _windowService = windowService ?? throw new ArgumentNullException(nameof(windowService));

            // Inicializar comandos
            LoginCommand = new RelayCommand(ExecuteLoginCommand);
            MinimizeCommand = new RelayCommand(() => _windowService.Minimize(Application.Current.MainWindow));
            CloseCommand = new RelayCommand(() => _windowService.Close(Application.Current.MainWindow));
            EsqueciSenhaCommand = new RelayCommand(ExecuteEsqueciSenhaCommand);
            RegisterCommand = new RelayCommand(ExecuteRegisterCommand);
        }

        private void ExecuteLoginCommand()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                var user = _authService.Login(Email, Password);

                if (user == null)
                {
                    MessageBox.Show("Email ou senha inválidos.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                MessageBox.Show($"Bem-vindo, {user.Nome}!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);

                _windowService.OpenDashboard();
                Application.Current.MainWindow.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar login: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ExecuteRegisterCommand()
        {
            // Chama o serviço para abrir a tela de registro
            _windowService.OpenRegisterView();

            // Opcional: Fechar a tela de login
            Application.Current.MainWindow.Close();
        }

        private void ExecuteEsqueciSenhaCommand()
        {
            // Abre uma janela para o usuário inserir o e-mail
            string email = PromptForEmail();

            // Valida se o e-mail foi inserido
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, insira um e-mail válido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Valida o formato do e-mail
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Formato de e-mail inválido.", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // Chama o serviço de envio de e-mail
                _authService.EnviarEmailRedefinicaoSenha(email);

                MessageBox.Show("Um e-mail foi enviado com as instruções para redefinição de senha.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar o e-mail: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private string PromptForEmail()
        {
            return Microsoft.VisualBasic.Interaction.InputBox(
                "Digite seu e-mail para redefinir a senha:",
                "Esqueci minha senha",
                string.Empty
            );
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
