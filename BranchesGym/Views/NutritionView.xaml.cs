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
    public partial class NutritionView : Window
    {
        public NutritionView()
        {
            InitializeComponent();
        }

        private void MealTypeTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MealTypeTextBox.Text == "Tipo de Refeição")
            {
                MealTypeTextBox.Text = "";
                MealTypeTextBox.Foreground = Brushes.Black;
            }
        }

        private void MealTypeTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(MealTypeTextBox.Text))
            {
                MealTypeTextBox.Text = "Tipo de Refeição";
                MealTypeTextBox.Foreground = Brushes.Gray;
            }
        }

        private void FoodTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FoodTextBox.Text == "Alimento")
            {
                FoodTextBox.Text = "";
                FoodTextBox.Foreground = Brushes.Black;
            }
        }

        private void FoodTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FoodTextBox.Text))
            {
                FoodTextBox.Text = "Alimento";
                FoodTextBox.Foreground = Brushes.Gray;
            }
        }

        private void CaloriesTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CaloriesTextBox.Text == "Calorias")
            {
                CaloriesTextBox.Text = "";
                CaloriesTextBox.Foreground = Brushes.Black;
            }
        }

        private void CaloriesTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CaloriesTextBox.Text))
            {
                CaloriesTextBox.Text = "Calorias";
                CaloriesTextBox.Foreground = Brushes.Gray;
            }
        }

        private void SaveNutritionButton_Click(object sender, RoutedEventArgs e)
        {
            string mealType = MealTypeTextBox.Text;
            string food = FoodTextBox.Text;
            string calories = CaloriesTextBox.Text;

            if (mealType == "Tipo de Refeição" || food == "Alimento" || calories == "Calorias")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            MessageBox.Show($"Refeição {mealType} cadastrada com sucesso!");
        }
    }
}

