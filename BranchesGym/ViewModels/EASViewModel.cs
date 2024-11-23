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
    public class EASViewModel : INotifyPropertyChanged
    {
        private string _substance;
        private double _dosage;
        private DateTime _startDate;
        private DateTime _endDate;

        public string Substance
        {
            get => _substance;
            set { _substance = value; OnPropertyChanged(nameof(Substance)); }
        }

        public double Dosage
        {
            get => _dosage;
            set { _dosage = value; OnPropertyChanged(nameof(Dosage)); }
        }

        public DateTime StartDate
        {
            get => _startDate;
            set { _startDate = value; OnPropertyChanged(nameof(StartDate)); }
        }

        public DateTime EndDate
        {
            get => _endDate;
            set { _endDate = value; OnPropertyChanged(nameof(EndDate)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
