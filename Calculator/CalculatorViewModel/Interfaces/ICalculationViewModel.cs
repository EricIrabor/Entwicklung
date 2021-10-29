namespace CalculatorViewModel.Interfaces
{
    public interface ICalculationViewModel
    {
        IDisplayViewModel DisplayViewModel { get; }
        IHeaderViewModel HeaderViewModel { get; }
        IMathFunctionsViewModel MathFunctionsViewModel { get; }
    }
}