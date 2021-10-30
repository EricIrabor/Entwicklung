using System.Windows.Input;

namespace CalculatorViewModel.Interfaces
{
    public interface INumberViewModel
    {
        ICommand Number0 { get; }
        ICommand Number1 { get; }
        ICommand Number2 { get; }
        ICommand Number3 { get; }
        ICommand Number4 { get; }
        ICommand Number5 { get; }
        ICommand Number6 { get; }
        ICommand Number7 { get; }
        ICommand Number8 { get; }
        ICommand Number9 { get; }
    }
}