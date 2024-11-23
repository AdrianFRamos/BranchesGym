using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BranchesGym.ViewModels
{
    public class SidebarViewModel
    {
        public ObservableCollection<string> MenuItems { get; set; }

        public SidebarViewModel()
        {
            // Adiciona os itens do menu da sidebar
            MenuItems = new ObservableCollection<string>
            {
                "Editar Perfil",
                "Cadastro de Exercícios",
                "Lançamento de Treinos",
                "Avaliações Físicas",
                "Informações Nutricionais",
                "Ciclo de EAS"
            };
        }
    }
}

