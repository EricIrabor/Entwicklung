using CalculatorViewModel.Interfaces;
using System.Windows.Input;

namespace CalculatorViewModel
{
    public class NumberViewModel : INumberViewModel
    {
        public NumberViewModel(ICommand number0, ICommand number1, ICommand number2,
                               ICommand number3, ICommand number4, ICommand number5,
                               ICommand number6, ICommand number7, ICommand number8,
                               ICommand number9, ICommand sign, ICommand point)
        {
            Number0 = number0;
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
            Number4 = number4;
            Number5 = number5;
            Number6 = number6;
            Number7 = number7;
            Number8 = number8;
            Number9 = number9;
            Sign = sign;
            Point = point;
        }

        public ICommand Number0 { get; }
        public ICommand Number1 { get; }
        public ICommand Number2 { get; }
        public ICommand Number3 { get; }
        public ICommand Number4 { get; }
        public ICommand Number5 { get; }
        public ICommand Number6 { get; }
        public ICommand Number7 { get; }
        public ICommand Number8 { get; }
        public ICommand Number9 { get; }
        public ICommand Sign { get; }
        public ICommand Point { get; }
    }
}