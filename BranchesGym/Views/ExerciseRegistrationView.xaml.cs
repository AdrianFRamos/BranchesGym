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
    public partial class ExerciseRegistrationView : Window
    {
        public ExerciseRegistrationView()
        {
            InitializeComponent();
        }

        private void ExerciseNameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ExerciseNameTextBox.Text == "Nome do Exercício")
            {
                ExerciseNameTextBox.Text = "";
                ExerciseNameTextBox.Foreground = Brushes.Black;
            }
        }

        private void ExerciseNameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ExerciseNameTextBox.Text))
            {
                ExerciseNameTextBox.Text = "Nome do Exercício";
                ExerciseNameTextBox.Foreground = Brushes.Gray;
            }
        }

        private void MuscleGroupTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MuscleGroupTextBox.Text == "Grupo Muscular")
            {
                MuscleGroupTextBox.Text = "";
                MuscleGroupTextBox.Foreground = Brushes.Black;
            }
        }

        private void MuscleGroupTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MuscleGroupTextBox.Text))
            {
                MuscleGroupTextBox.Text = "Grupo Muscular";
                MuscleGroupTextBox.Foreground = Brushes.Gray;
            }
        }

        private void RegisterExerciseButton_Click(object sender, RoutedEventArgs e)
        {
            string exerciseName = ExerciseNameTextBox.Text;
            string muscleGroup = MuscleGroupTextBox.Text;

            if (exerciseName == "Nome do Exercício" || muscleGroup == "Grupo Muscular")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            MessageBox.Show($"Exercício {exerciseName} para o grupo {muscleGroup} cadastrado com sucesso!");
        }
    }
}

