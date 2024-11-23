using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BranchesGym.Models
{
    public class PhysicalEvaluation
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BodyFat { get; set; }
        public DateTime Date { get; set; }
    }
}

