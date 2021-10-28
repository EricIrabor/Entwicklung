using CalculatorBL.BO.Interface;
using CalculatorViewModel.Interfaces;
using System.ComponentModel;

namespace CalculatorViewModel
{
    public class DisplayViewModel : IDisplayViewModel, INotifyPropertyChanged
    {
        private readonly ICalculatorManager calculatorManager;



        public event PropertyChangedEventHandler PropertyChanged;

        public DisplayViewModel(ICalculatorManager calculatorManager)
        {
            this.calculatorManager = calculatorManager;
            calculatorManager.PropertyChanged += CalculatorManager_PropertyChanged;  //Event Abboniert 
        }



        public string Input
        {
            get 
            {
                return calculatorManager.Input;
            }
            set
            {
                calculatorManager.Input = value;
            }
        }

        public string Output { set; }



        public void CalculatorManager_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            UpdateView();
        }

        public void UpdateView()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Input)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Output)));
        }

    }
}