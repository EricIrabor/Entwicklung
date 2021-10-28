using CalculatorAppLogic;
using CalculatorViewModel.Interfaces;
using System.Windows;

namespace CalculatorDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppLogic appLogic = new AppLogic();

            ICalculationViewModel calculationViewModel = appLogic.GetCalculationViewModel();
            DataContext = new MainWindowViewModel(calculationViewModel);
        }
    }
}