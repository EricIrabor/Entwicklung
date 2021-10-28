using System.ComponentModel;

namespace CalculatorViewModel.Interfaces
{
    public interface IDisplayViewModel
    {
        event PropertyChangedEventHandler PropertyChanged;

        string Input {get; set;}
       string Output { set; }


    }
}