using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;

namespace BranchesGym.Services
{
    public class WindowService
    {
        // Método para minimizar a janela
        public void Minimize(Window window)
        {
            if (window != null)
                window.WindowState = WindowState.Minimized;
        }

        // Método para maximizar ou restaurar a janela
        public void ToggleMaximize(Window window)
        {
            if (window != null)
            {
                if (window.WindowState == WindowState.Maximized)
                    window.WindowState = WindowState.Normal;
                else
                    window.WindowState = WindowState.Maximized;
            }
        }

        // Método para fechar a janela
        public void Close(Window window)
        {
            if (window != null)
                window.Close();
        }
    }
}

