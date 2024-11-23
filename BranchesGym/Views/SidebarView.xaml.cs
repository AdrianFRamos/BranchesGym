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
    public partial class SidebarView : UserControl
    {
        public SidebarView()
        {
            InitializeComponent();
        }

        private void NavigateToProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfileView profileView = new ProfileView();
            profileView.Show();
        }

        private void NavigateToExerciseRegistration_Click(object sender, RoutedEventArgs e)
        {
            ExerciseRegistrationView exerciseRegistrationView = new ExerciseRegistrationView();
            exerciseRegistrationView.Show();
        }

        private void NavigateToTraining_Click(object sender, RoutedEventArgs e)
        {
            TrainingEntryView trainingEntryView = new TrainingEntryView();
            trainingEntryView.Show();
        }

        private void NavigateToPhysicalEvaluation_Click(object sender, RoutedEventArgs e)
        {
            PhysicalEvaluationView physicalEvaluationView = new PhysicalEvaluationView();
            physicalEvaluationView.Show();
        }

        private void NavigateToNutrition_Click(object sender, RoutedEventArgs e)
        {
            NutritionView nutritionView = new NutritionView();
            nutritionView.Show();
        }

        private void NavigateToEAS_Click(object sender, RoutedEventArgs e)
        {
            EASView easView = new EASView();
            easView.Show();
        }
    }
}


