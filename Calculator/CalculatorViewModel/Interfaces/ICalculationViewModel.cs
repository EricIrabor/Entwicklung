namespace CalculatorViewModel.Interfaces
{
    public interface ICalculationViewModel
    {
        IHeaderViewModel HeaderViewModel { get; }
        IMathFunctionsViewModel MathFunctionsViewModel { get; }
        IDisplayViewModel DisplayViewModel { get; }
    }
}