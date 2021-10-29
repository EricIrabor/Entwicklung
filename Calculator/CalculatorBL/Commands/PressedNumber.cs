using CalculatorBL.BO.Interface;
using System;
using System.Windows.Input;

namespace CalculatorBL.Commands
{
    public class PressedNumber : ICommand
    {
        private readonly ICalculatorManager calculatorManager;
        private readonly string keyNumber;

        public PressedNumber(ICalculatorManager calculatorManager, string keyNumber)
        {
            this.calculatorManager = calculatorManager;
            this.keyNumber = keyNumber;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            calculatorManager.Input = keyNumber;
        }
    }
}