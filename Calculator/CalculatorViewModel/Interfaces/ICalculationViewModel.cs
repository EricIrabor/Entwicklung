﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorViewModel.Interfaces
{
    public interface ICalculationViewModel
    {
        IMathFunctionsViewModel calculatorMathFunctionsViewModel { get; }
        IDisplayViewModel calculatorDisplayViewModel { get; }
    }
}