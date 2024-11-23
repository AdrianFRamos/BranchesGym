using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var user = new User { Username = Username, Password = Password, Email = Email };
            _authService.Register(user);
        }
    }
}

