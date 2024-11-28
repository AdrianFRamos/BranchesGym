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

using System.Windows;
using BranchesGym.Data;
using BranchesGym.Models;

namespace BranchesGym.Views
{
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;
            if (textBox.Text == textBox.Tag?.ToString())
            {
                textBox.Text = "";
                textBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = textBox.Tag?.ToString();
                textBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as System.Windows.Controls.PasswordBox;
            if (passwordBox.Tag.ToString() == "Senha" && passwordBox.Password == "")
            {
                passwordBox.Tag = ""; // Remove o placeholder
                passwordBox.Foreground = System.Windows.Media.Brushes.Black;
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            var passwordBox = sender as System.Windows.Controls.PasswordBox;
            if (passwordBox.Password == "")
            {
                passwordBox.Tag = "Senha"; // Adiciona o placeholder novamente
                passwordBox.Foreground = System.Windows.Media.Brushes.Gray;
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text.Trim();
            string lastName = LastNameTextBox.Text.Trim();
            string phoneNumber = PhoneNumberTextBox.Text.Trim();
            string email = EmailTextBox.Text.Trim();
            string password = PasswordBox.Password.Trim();
            string confirmPassword = ConfirmPasswordBox.Password.Trim();

            // Validação dos campos
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("As senhas não correspondem.");
                return;
            }

            // Gerar username automaticamente
            string username = $"{firstName.ToLower()}.{lastName.ToLower()}";

            // Salvar no banco de dados
            using (var context = new DatabaseContext())
            {
                if (context.Users.Any(u => u.Email == email))
                {
                    MessageBox.Show("Já existe um usuário com este email.");
                    return;
                }

                var newUser = new User
                {
                    Nome = username,
                    Senha = password,
                    Email = email,
                    Numero = phoneNumber,
                    TipoUsuario = "CoTreinador" // ou outro tipo, conforme necessário
                };

                context.Users.Add(newUser);
                context.SaveChanges();
            }

            MessageBox.Show("Usuário cadastrado com sucesso!");
            this.Close();
        }
    }
}

