using System.Windows.Input;

namespace CalculatorViewModel.Interfaces
{
    public interface INumberViewModel
    {
        ICommand Number0 { get; }
        ICommand Number1 { get; }
    }
}