using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesGym.Models
{
    public class Nutrition
    {
        public int Id { get; set; }
        public string MealType { get; set; }
        public string Food { get; set; }
        public int Calories { get; set; }
        public DateTime Date { get; set; }
    }
}

