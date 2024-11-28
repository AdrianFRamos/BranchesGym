using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;
using BranchesGym.Services;
using BranchesGym.Models;

namespace BranchesGym.ViewModels
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _email;
        private string _tipoUsuario;
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

        public string Email
        {
            get => _email;
            set { _email = value; OnPropertyChanged(nameof(Email)); }
        }

        public string TipoUsuario
        {
            get => _tipoUsuario;
            set { _tipoUsuario = value; OnPropertyChanged(nameof(TipoUsuario)); }
        }

        public RegisterViewModel(AuthService authService)
        {
            _authService = authService;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Register()
        {
            if (string.IsNullOrWhiteSpace(Username))
                throw new Exception("O nome de usuário é obrigatório.");

            if (string.IsNullOrWhiteSpace(Password))
                throw new Exception("A senha é obrigatória.");

            if (string.IsNullOrWhiteSpace(Email))
                throw new Exception("O email é obrigatório.");

            if (!Email.Contains("@"))
                throw new Exception("O email fornecido não é válido.");

            if (string.IsNullOrWhiteSpace(TipoUsuario))
                throw new Exception("O tipo de usuário é obrigatório.");

            var user = new User
            {
                Username = Username,
                Senha = Password,
                Email = Email,
                TipoUsuario = TipoUsuario, // Define o tipo do usuário
                Nome = "Nome Exemplo",
                Sobrenome = "Sobrenome Exemplo"
            };

            _authService.Register(user);
        }
    }
}

