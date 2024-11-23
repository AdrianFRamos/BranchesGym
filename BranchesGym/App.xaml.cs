using System.Windows;
using BranchesGym.Data;

namespace BranchesGym
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Inicializar o banco de dados
            using (var context = new DatabaseContext())
            {
                DatabaseHelper.EnsureDatabaseCreated(context);
            }
        }
    }
}
