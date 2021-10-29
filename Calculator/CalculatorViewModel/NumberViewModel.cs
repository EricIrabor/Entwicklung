using CalculatorViewModel.Interfaces;
using System.Windows.Input;

namespace CalculatorViewModel
{
    public class NumberViewModel : INumberViewModel
    {
        public NumberViewModel(ICommand number0, ICommand number1)
        {
            Number0 = number0;
            Number1 = number1;
        }

        public ICommand Number0 { get; }

        public ICommand Number1 { get; }
    }
}