using CalculatorBL.BO.Interface;
using System.Windows.Input;

namespace CalculatorAppLogic.Container
{
    public class BLContainer
    {
        public BLContainer(ICalculatorManager calculatorManager, ICommand number0, ICommand number1)
        {
            CalculatorManager = calculatorManager;
            Number0 = number0;
            Number1 = number1;
        }

        public ICalculatorManager CalculatorManager { get; }
        public ICommand Number0 { get; }
        public ICommand Number1 { get; }
    }
}