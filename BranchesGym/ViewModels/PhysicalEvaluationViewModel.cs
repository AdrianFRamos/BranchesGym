using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;

namespace BranchesGym.ViewModels
{
    public class PhysicalEvaluationViewModel : INotifyPropertyChanged
    {
        private double _weight;
        private double _height;
        private double _bodyFat;
        private DateTime _evaluationDate;

        public double Weight
        {
            get => _weight;
            set { _weight = value; OnPropertyChanged(nameof(Weight)); }
        }

        public double Height
        {
            get => _height;
            set { _height = value; OnPropertyChanged(nameof(Height)); }
        }

        public double BodyFat
        {
            get => _bodyFat;
            set { _bodyFat = value; OnPropertyChanged(nameof(BodyFat)); }
        }

        public DateTime EvaluationDate
        {
            get => _evaluationDate;
            set { _evaluationDate = value; OnPropertyChanged(nameof(EvaluationDate)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
