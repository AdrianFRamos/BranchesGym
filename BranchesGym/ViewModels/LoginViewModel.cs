using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchesGym.Services;
using System.ComponentModel;

using System;
using System.ComponentModel;
using BranchesGym.Services;
using BranchesGym.Models;

namespace BranchesGym.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _tipoUsuario; // Novo campo para armazenar o tipo de usuário após o login
        private readonly AuthService _authService;

        public string Username
        {
            get => _username;
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public string Password
        {
            get => _password;
            set { _password = value; OnPropertyChanged(nameof(Password)); }
        }

        public string TipoUsuario
        {
            get => _tipoUsuario;
            private set { _tipoUsuario = value; OnPropertyChanged(nameof(TipoUsuario)); }
        }

        public LoginViewModel(AuthService authService)
        {
            _authService = authService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public bool Login()
        {
            try
            {
                // Chama o AuthService para autenticar o usuário
                var user = _authService.Login(Username, Password);

                if (user != null)
                {
                    // Armazena o tipo de usuário após o login bem-sucedido
                    TipoUsuario = user.TipoUsuario;
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log de erros ou tratamento de exceções
                Console.WriteLine($"Erro no login: {ex.Message}");
            }

            return false; // Login falhou
        }
    }
}

