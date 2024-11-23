using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;
using BranchesGym.Models;

namespace BranchesGym.ViewModels
{
    public class NutritionViewModel : INotifyPropertyChanged
    {
        private string _mealType;
        private string _food;
        private int _calories;
        private DateTime _date;

        public string MealType
        {
            get => _mealType;
            set { _mealType = value; OnPropertyChanged(nameof(MealType)); }
        }

        public string Food
        {
            get => _food;
            set { _food = value; OnPropertyChanged(nameof(Food)); }
        }

        public int Calories
        {
            get => _calories;
            set { _calories = value; OnPropertyChanged(nameof(Calories)); }
        }

        public DateTime Date
        {
            get => _date;
            set { _date = value; OnPropertyChanged(nameof(Date)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
