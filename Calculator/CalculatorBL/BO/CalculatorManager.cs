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

        public event PropertyChangedEventHandler PropertyChanged;

        public string Input
        {
            get => input;
            set
            {
                if (input != value)
                {
                    input = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Input)));
                }
            }
        }

        public string Output
        {
            set
            {
                output = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Output)));
            }
        }
    }
}