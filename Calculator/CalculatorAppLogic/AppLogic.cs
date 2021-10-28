using CalculatorAppLogic.Creator.ViewModelCreator;
using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic
{
    public class AppLogic
    {
        private readonly VMCreator vMCreator;

        public AppLogic()
        {
            vMCreator = new VMCreator();
        }

        public ICalculationViewModel GetCalculationViewModel()
        {
            return vMCreator.ReturnCalculationViewModel();
        }
    }
}