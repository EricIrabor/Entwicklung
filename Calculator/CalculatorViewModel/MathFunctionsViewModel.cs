using CalculatorViewModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorViewModel
{
    public class MathFunctionsViewModel : IMathFunctionsViewModel
    {
        public INumberViewModel calculatorNumberViewModel { get; }
    }
}