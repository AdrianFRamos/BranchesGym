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

namespace BranchesGym.Views
{
    public partial class RegisterView : Window
    {
        public RegisterView()
        {
            InitializeComponent();
        }

        // Placeholder para TextBox de Usuário
        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox.Text == "Usuário")
            {
                UsernameTextBox.Text = "";
                UsernameTextBox.Foreground = Brushes.Black;
            }
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
            {
                UsernameTextBox.Text = "Usuário";
                UsernameTextBox.Foreground = Brushes.Gray;
            }
        }

        // Placeholder para TextBox de Email
        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTextBox.Text == "Email")
            {
                EmailTextBox.Text = "";
                EmailTextBox.Foreground = Brushes.Black;
            }
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "Email";
                EmailTextBox.Foreground = Brushes.Gray;
            }
        }

        // Placeholder para PasswordBox de Senha
        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Tag.ToString() == "Senha" && PasswordBox.Password == "")
            {
                PasswordBox.Foreground = Brushes.Black;
                PasswordBox.Tag = ""; // Remove o placeholder
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password == "")
            {
                PasswordBox.Foreground = Brushes.Gray;
                PasswordBox.Tag = "Senha"; // Restaura o placeholder
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = UsernameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordBox.Password;

            if (username == "Usuário" || email == "Email" || password == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            MessageBox.Show($"Usuário {username} cadastrado com sucesso!");
            this.Close();
        }
    }
}
