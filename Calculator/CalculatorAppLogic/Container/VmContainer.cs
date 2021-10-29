using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic.Container
{
    public class VmContainer
    {
        public VmContainer(ICalculationViewModel calculationViewModel)
        {
            CalculationViewModel = calculationViewModel;
        }

        public ICalculationViewModel CalculationViewModel { get; }
    }
}