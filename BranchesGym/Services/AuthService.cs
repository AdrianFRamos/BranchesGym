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

        public User Login(string username, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}

