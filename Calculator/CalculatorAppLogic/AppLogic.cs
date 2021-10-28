using CalculatorAppLogic.Creator.ViewModelCreator;
using CalculatorBL.BO;
using CalculatorBL.BO.Interface;
using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic
{
    public class AppLogic
    {
        private readonly VmCreator vmCreator;
        private readonly ICalculatorManager calculatorManager;

        public AppLogic()
        {

            calculatorManager = new CalculatorManager();
            vmCreator = new VmCreator(calculatorManager);
        }

        public ICalculationViewModel GetCalculationViewModel()
        {
            return vmCreator.ReturnCalculationViewModel();
        }
    }
}