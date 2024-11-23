using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace BranchesGym.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> DashboardData { get; set; }

        public DashboardViewModel()
        {
            // Dados simulados para exibição
            DashboardData = new ObservableCollection<string>
            {
                "Esforço Muscular - 80%",
                "Treinos Concluídos - 5",
                "Tempo Médio de Treino - 45 min",
                "Calorias Consumidas - 2000 kcal"
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
