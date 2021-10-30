using CalculatorAppLogic.Container;
using CalculatorViewModel;
using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic.Creator
{
    public class VmCreator
    {
        #region Dekleration

        private readonly ICalculationViewModel calculationViewModel;
        private readonly IDisplayViewModel displayViewModel;
        private readonly IHeaderViewModel headerViewModel;
        private readonly IMathFunctionsViewModel mathFunctionsViewModel;
        private readonly INumberViewModel numberViewModel;

        #endregion Dekleration

        public VmCreator(BLContainer bLContainer)
        {
            displayViewModel = new DisplayViewModel(bLContainer.CalculatorManager);
            headerViewModel = new HeaderViewModel();
            numberViewModel = new NumberViewModel(bLContainer.Number0, bLContainer.Number1,bLContainer.Number2, bLContainer.Number3, bLContainer.Number4,
                                                  bLContainer.Number5, bLContainer.Number6, bLContainer.Number7, bLContainer.Number8, bLContainer.Number9,
                                                  bLContainer.Sign, bLContainer.Point);
            mathFunctionsViewModel = new MathFunctionsViewModel(numberViewModel);
            calculationViewModel = new CalculationViewModel(displayViewModel, headerViewModel, mathFunctionsViewModel);
        }

        public VmContainer ReturnVmContainer()
        {
            return new VmContainer(calculationViewModel);
        }
    }
}