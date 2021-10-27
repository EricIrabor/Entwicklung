using CalculatorViewModel.Interfaces;

namespace CalculatorViewModel
{
    public class CalculationViewModel : ICalculationViewModel
    {
        public CalculationViewModel(IDisplayViewModel displayViewModel, IHeaderViewModel headerViewModel, IMathFunctionsViewModel mathFunctionsViewModel)
        {
            DisplayViewModel = displayViewModel;
            HeaderViewModel = headerViewModel;
            MathFunctionsViewModel = mathFunctionsViewModel;
        }

        public IDisplayViewModel DisplayViewModel { get; }
        public IHeaderViewModel HeaderViewModel { get; }
        public IMathFunctionsViewModel MathFunctionsViewModel { get; }
    }
}