using CalculatorViewModel.Interfaces;

namespace CalculatorViewModel
{
    public class MathFunctionsViewModel : IMathFunctionsViewModel
    {
        public MathFunctionsViewModel(INumberViewModel numberViewModel)
        {
            NumberViewModel = numberViewModel;
        }

        public INumberViewModel NumberViewModel { get; }
    }
}