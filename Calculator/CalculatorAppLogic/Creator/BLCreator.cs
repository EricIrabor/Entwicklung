using CalculatorAppLogic.Container;
using CalculatorBL.BO;
using CalculatorBL.BO.Interface;
using CalculatorBL.Commands;
using System.Windows.Input;

namespace CalculatorAppLogic.Creator
{
    public class BLCreator
    {
        private readonly ICalculatorManager calculatorManager;
        private readonly ICommand number0;
        private readonly ICommand number1;

        public BLCreator()
        {
            calculatorManager = new CalculatorManager();
            number0 = new PressedNumber(calculatorManager, "0");
            number1 = new PressedNumber(calculatorManager, "1");
        }

        public BLContainer ReturnBOContainer()
        {
            return new BLContainer(calculatorManager, number0, number1);
        }
    }
}