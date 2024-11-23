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
    public partial class TrainingEntryView : Window
    {
        public TrainingEntryView()
        {
            InitializeComponent();
        }

        private void LoadTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LoadTextBox.Text == "Carga (kg)")
            {
                LoadTextBox.Text = "";
                LoadTextBox.Foreground = Brushes.Black;
            }
        }

        private void LoadTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoadTextBox.Text))
            {
                LoadTextBox.Text = "Carga (kg)";
                LoadTextBox.Foreground = Brushes.Gray;
            }
        }

        private void RepetitionsTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RepetitionsTextBox.Text == "Repetições")
            {
                RepetitionsTextBox.Text = "";
                RepetitionsTextBox.Foreground = Brushes.Black;
            }
        }

        private void RepetitionsTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RepetitionsTextBox.Text))
            {
                RepetitionsTextBox.Text = "Repetições";
                RepetitionsTextBox.Foreground = Brushes.Gray;
            }
        }

        private void MethodTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MethodTextBox.Text == "Método")
            {
                MethodTextBox.Text = "";
                MethodTextBox.Foreground = Brushes.Black;
            }
        }

        private void MethodTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MethodTextBox.Text))
            {
                MethodTextBox.Text = "Método";
                MethodTextBox.Foreground = Brushes.Gray;
            }
        }

        private void ExecutionTimeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ExecutionTimeTextBox.Text == "Tempo de Execução (s)")
            {
                ExecutionTimeTextBox.Text = "";
                ExecutionTimeTextBox.Foreground = Brushes.Black;
            }
        }

        private void ExecutionTimeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExecutionTimeTextBox.Text))
            {
                ExecutionTimeTextBox.Text = "Tempo de Execução (s)";
                ExecutionTimeTextBox.Foreground = Brushes.Gray;
            }
        }

        private void RestTimeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (RestTimeTextBox.Text == "Descanso (s)")
            {
                RestTimeTextBox.Text = "";
                RestTimeTextBox.Foreground = Brushes.Black;
            }
        }

        private void RestTimeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RestTimeTextBox.Text))
            {
                RestTimeTextBox.Text = "Descanso (s)";
                RestTimeTextBox.Foreground = Brushes.Gray;
            }
        }

        private void SaveTrainingButton_Click(object sender, RoutedEventArgs e)
        {
            string load = LoadTextBox.Text;
            string repetitions = RepetitionsTextBox.Text;
            string method = MethodTextBox.Text;
            string executionTime = ExecutionTimeTextBox.Text;
            string restTime = RestTimeTextBox.Text;

            if (load == "Carga (kg)" || repetitions == "Repetições" || method == "Método" ||
                executionTime == "Tempo de Execução (s)" || restTime == "Descanso (s)")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            MessageBox.Show($"Treino salvo com sucesso!");
        }
    }
}

