using CalculatorBL.BO.Interface;
using System;
using System.ComponentModel;

namespace CalculatorBL.BO
{
    public class CalculatorManager : ICalculatorManager
    {
        private string input;
        private string output;

        public CalculatorManager()
        {
            Input = "0";
            Output = String.Empty;
        }

        public string Input
        {
            get => input;
            set
            {
                if (input != value)
                {
                    input = value;
                }
            }
        }

        public string Output
        {
            get => output;
            set
            {
                output = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}