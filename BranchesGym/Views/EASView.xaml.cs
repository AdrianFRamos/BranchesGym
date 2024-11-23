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
    public partial class EASView : Window
    {
        public EASView()
        {
            InitializeComponent();
        }

        private void SubstanceTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SubstanceTextBox.Text == "Substância")
            {
                SubstanceTextBox.Text = "";
                SubstanceTextBox.Foreground = Brushes.Black;
            }
        }

        private void SubstanceTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SubstanceTextBox.Text))
            {
                SubstanceTextBox.Text = "Substância";
                SubstanceTextBox.Foreground = Brushes.Gray;
            }
        }

        private void DosageTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (DosageTextBox.Text == "Dosagem (mg)")
            {
                DosageTextBox.Text = "";
                DosageTextBox.Foreground = Brushes.Black;
            }
        }

        private void DosageTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DosageTextBox.Text))
            {
                DosageTextBox.Text = "Dosagem (mg)";
                DosageTextBox.Foreground = Brushes.Gray;
            }
        }

        private void SaveCycleButton_Click(object sender, RoutedEventArgs e)
        {
            string substance = SubstanceTextBox.Text;
            string dosage = DosageTextBox.Text;

            if (substance == "Substância" || dosage == "Dosagem (mg)")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            MessageBox.Show($"Ciclo de EAS salvo com sucesso!\nSubstância: {substance}\nDosagem: {dosage} mg");
        }
    }
}

