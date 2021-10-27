using CalculatorViewModel.Interfaces;

namespace CalculatorViewModel
{
    public class MathFunctionsViewModel : IMathFunctionsViewModel
    {
        public INumberViewModel NumberViewModel { get; }
    }
}