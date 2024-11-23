using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BranchesGym.Models;

namespace BranchesGym.Services
{
    public class TrainingAnalysisService
    {
        public double CalculateEffort(TrainingDay trainingDay)
        {
            // Simplificação do cálculo de esforço
            return trainingDay.Exercises.Count * 10; // Exemplo de pontuação por exercício
        }
    }
}
