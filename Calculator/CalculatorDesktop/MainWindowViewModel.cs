using CalculatorViewModel.Interfaces;

namespace CalculatorDesktop
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel(ICalculationViewModel calculationViewModel)
        {
            CalculationViewModel = calculationViewModel;
        }

        public ICalculationViewModel CalculationViewModel { get; }
    }
}