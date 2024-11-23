using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BranchesGym.Data
{
    public static class DatabaseHelper
    {
        public static void EnsureDatabaseCreated(DatabaseContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}

