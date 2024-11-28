using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using System.Linq;
using System.Windows;
using BranchesGym.Data;
using BranchesGym.Services;

namespace BranchesGym.Views
{
    public partial class LoginView : Window
    {
        private readonly WindowService _windowService;
        public LoginView()
        {
            InitializeComponent();
            _windowService = new WindowService();
        }

        private void MinimizeWindow(object sender, RoutedEventArgs e)
        {
            _windowService.Minimize(this);
        }

        // Método para fechar a janela
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            _windowService.Close(this);
        }
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as System.Windows.Controls.PasswordBox;
            if (passwordBox != null && passwordBox.Tag?.ToString() == "Senha")
            {
                passwordBox.Password = string.Empty; // Limpa o campo de senha
                passwordBox.Tag = null; // Remove o placeholder
                passwordBox.Foreground = System.Windows.Media.Brushes.Black; // Define o texto como preto
            }
        }

        // Método para tratar a perda de foco do PasswordBox
        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as System.Windows.Controls.PasswordBox;
            if (passwordBox != null && string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = string.Empty; // Reseta o campo
                passwordBox.Tag = "Senha"; // Adiciona o placeholder de volta
                passwordBox.Foreground = System.Windows.Media.Brushes.Gray; // Define o texto como cinza
            }
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;
            if (textBox != null && textBox.Text == "Usuário")
            {
                textBox.Text = string.Empty;
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        // Método para tratar a perda de foco do TextBox
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Usuário";
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = EmailTextBox.Text.Trim();
            string senha = PasswordBox.Password.Trim();

            // Validação dos campos
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using (var context = new DatabaseContext())
            {
                // Verificar usuário no banco
                var user = context.Users
                    .FirstOrDefault(u => u.Email == email && u.Senha == senha);

                if (user == null)
                {
                    MessageBox.Show("Email ou senha inválidos.");
                    return;
                }

                // Exibir mensagem e redirecionar para o dashboard
                MessageBox.Show($"Bem-vindo, {user.Nome}!");
                DashboardView dashboard = new DashboardView();
                dashboard.Show();
                this.Close();
            }
        }
    }
}
