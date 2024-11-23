using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesGym.Models
{
    public class EASCycle
    {
        public int Id { get; set; }
        public string Substance { get; set; }
        public double Dosage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}

