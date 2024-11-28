using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesGym.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } // Nome de usuário
        public string Email { get; set; }    // Email do usuário
        public string Senha { get; set; }    // Senha do usuário
        public string TipoUsuario { get; set; } // Tipo de usuário: 'Admin', 'Professor', etc.
        public string Nome { get; set; }    // Nome completo do usuário
        public string Sobrenome { get; set; } // Sobrenome do usuário
        public string Numero { get; set; }
    }
}

