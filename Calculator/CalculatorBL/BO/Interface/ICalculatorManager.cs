using System.ComponentModel;

namespace CalculatorBL.BO.Interface
{
    public interface ICalculatorManager
    {
        event PropertyChangedEventHandler PropertyChanged;

        string Input { get; set; }
        string Output { get; set; }
    }
}