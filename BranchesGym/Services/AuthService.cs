using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BranchesGym.Data;
using BranchesGym.Models;
using System.Linq;

namespace BranchesGym.Services
{
    public class AuthService
    {
        private readonly DatabaseContext _context;

        public AuthService(DatabaseContext context)
        {
            _context = context;
        }

        // Cadastro de usuário
        public void Register(User user)
        {
            if (_context.Users.Any(u => u.Username == user.Username))
                throw new Exception("O nome de usuário já está em uso.");

            if (_context.Users.Any(u => u.Email == user.Email))
                throw new Exception("O email já está em uso.");

            _context.Users.Add(user);
            _context.SaveChanges();
        }

        // Login de usuário
        public User Login(string username, string senha)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Senha == senha);

            if (user == null)
                throw new Exception("Usuário ou senha inválidos.");

            return user; // Retorna o usuário autenticado
        }

        public void EnviarEmailRedefinicaoSenha(string emailDestino)
        {
            var fromAddress = new System.Net.Mail.MailAddress("seuemail@exemplo.com", "Branches Gym");
            var toAddress = new System.Net.Mail.MailAddress(emailDestino);
            const string fromPassword = "senha-do-email";
            const string subject = "Redefinição de Senha";
            const string body = "Clique no link abaixo para redefinir sua senha:\n\nhttps://seu-site.com/redefinir-senha";

            var smtp = new System.Net.Mail.SmtpClient
            {
                Host = "smtp.seuprovedor.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new System.Net.Mail.MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
