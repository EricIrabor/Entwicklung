using CalculatorViewModel;
using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic.Creator.ViewModelCreator
{
    public class VMCreator
    {
        private readonly ICalculationViewModel calculationViewModel;
        private readonly IDisplayViewModel displayViewModel;
        private readonly IHeaderViewModel headerViewModel;
        private readonly IMathFunctionsViewModel mathFunctionsViewModel;
        private readonly INumberViewModel numberViewModel;

        public VMCreator()
        {
            headerViewModel = new HeaderViewModel();
            displayViewModel = new DisplayViewModel();
            numberViewModel = new NumberViewModel();
            mathFunctionsViewModel = new MathFunctionsViewModel(numberViewModel);
            calculationViewModel = new CalculationViewModel(displayViewModel, headerViewModel, mathFunctionsViewModel);
        }

        public ICalculationViewModel ReturnCalculationViewModel()
        {
            return calculationViewModel;
        }
    }
}