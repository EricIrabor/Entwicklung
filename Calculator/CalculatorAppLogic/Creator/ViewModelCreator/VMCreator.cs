using CalculatorBL.BO.Interface;
using CalculatorViewModel;
using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic.Creator.ViewModelCreator
{
    public class VmCreator
    {
        private readonly ICalculationViewModel calculationViewModel;
        private readonly IDisplayViewModel displayViewModel;
        private readonly IHeaderViewModel headerViewModel;
        private readonly IMathFunctionsViewModel mathFunctionsViewModel;
        private readonly INumberViewModel numberViewModel;

      

        public VmCreator(ICalculatorManager calculatorManager)
        {
            headerViewModel = new HeaderViewModel();
            displayViewModel = new DisplayViewModel(calculatorManager);
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