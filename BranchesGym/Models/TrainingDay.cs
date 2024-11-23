using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace BranchesGym.Models
{
    public class TrainingDay
    {
        public int Id { get; set; }
        public string DayOfWeek { get; set; }
        public List<Exercise> Exercises { get; set; } = new List<Exercise>();
    }
}

