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
    public partial class PhysicalEvaluationView : Window
    {
        public PhysicalEvaluationView()
        {
            InitializeComponent();
        }

        private void WeightTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (WeightTextBox.Text == "Peso (kg)")
            {
                WeightTextBox.Text = "";
                WeightTextBox.Foreground = Brushes.Black;
            }
        }

        private void WeightTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(WeightTextBox.Text))
            {
                WeightTextBox.Text = "Peso (kg)";
                WeightTextBox.Foreground = Brushes.Gray;
            }
        }

        private void HeightTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (HeightTextBox.Text == "Altura (cm)")
            {
                HeightTextBox.Text = "";
                HeightTextBox.Foreground = Brushes.Black;
            }
        }

        private void HeightTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(HeightTextBox.Text))
            {
                HeightTextBox.Text = "Altura (cm)";
                HeightTextBox.Foreground = Brushes.Gray;
            }
        }

        private void BodyFatTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (BodyFatTextBox.Text == "Gordura Corporal (%)")
            {
                BodyFatTextBox.Text = "";
                BodyFatTextBox.Foreground = Brushes.Black;
            }
        }

        private void BodyFatTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BodyFatTextBox.Text))
            {
                BodyFatTextBox.Text = "Gordura Corporal (%)";
                BodyFatTextBox.Foreground = Brushes.Gray;
            }
        }

        private void SaveEvaluationButton_Click(object sender, RoutedEventArgs e)
        {
            string weight = WeightTextBox.Text;
            string height = HeightTextBox.Text;
            string bodyFat = BodyFatTextBox.Text;

            if (weight == "Peso (kg)" || height == "Altura (cm)" || bodyFat == "Gordura Corporal (%)")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            MessageBox.Show($"Avaliação Física salva com sucesso!");
        }
    }
}

