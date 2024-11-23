using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace BranchesGym.ViewModels
{
    public class TrainingEntryViewModel : INotifyPropertyChanged
    {
        private int _load;
        private int _repetitions;
        private string _method;
        private int _executionTime;
        private int _restTime;

        public int Load
        {
            get => _load;
            set { _load = value; OnPropertyChanged(nameof(Load)); }
        }

        public int Repetitions
        {
            get => _repetitions;
            set { _repetitions = value; OnPropertyChanged(nameof(Repetitions)); }
        }

        public string Method
        {
            get => _method;
            set { _method = value; OnPropertyChanged(nameof(Method)); }
        }

        public int ExecutionTime
        {
            get => _executionTime;
            set { _executionTime = value; OnPropertyChanged(nameof(ExecutionTime)); }
        }

        public int RestTime
        {
            get => _restTime;
            set { _restTime = value; OnPropertyChanged(nameof(RestTime)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
