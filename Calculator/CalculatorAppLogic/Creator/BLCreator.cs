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
        private readonly ICommand number2;
        private readonly ICommand number3;
        private readonly ICommand number4;
        private readonly ICommand number5;
        private readonly ICommand number6;
        private readonly ICommand number7;
        private readonly ICommand number8;
        private readonly ICommand number9;
        private readonly ICommand sign;
        private readonly ICommand point;

        public BLCreator()
        {
            calculatorManager = new CalculatorManager();
            number0 = new PressedNumber(calculatorManager, "0");
            number1 = new PressedNumber(calculatorManager, "1");
            number2 = new PressedNumber(calculatorManager, "2");
            number3 = new PressedNumber(calculatorManager, "3");
            number4 = new PressedNumber(calculatorManager, "4");
            number5 = new PressedNumber(calculatorManager, "5");
            number6 = new PressedNumber(calculatorManager, "6");
            number7 = new PressedNumber(calculatorManager, "7");
            number8 = new PressedNumber(calculatorManager, "8");
            number9 = new PressedNumber(calculatorManager, "9");           
            sign = new PressedNumber(calculatorManager, "-");           
            point = new PressedNumber(calculatorManager, ".");           
        }

        public BLContainer ReturnBOContainer()
        {
            return new BLContainer(calculatorManager, number0, number1,
                                   number2, number3, number4, number5, number6,
                                   number7, number8, number9, sign, point);
        }
    }
}