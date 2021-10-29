using CalculatorAppLogic.Container;
using CalculatorAppLogic.Creator;
using CalculatorViewModel.Interfaces;

namespace CalculatorAppLogic
{
    public class AppLogic
    {
        private readonly VmContainer vmContainer;

        public AppLogic()
        {
            BLCreator bLCreator = new BLCreator();
            BLContainer bLContainer = bLCreator.ReturnBOContainer();

            VmCreator vmCreator = new VmCreator(bLContainer);
            vmContainer = vmCreator.ReturnVmContainer();
        }

        public ICalculationViewModel GetCalculationViewModel()
        {
            return vmContainer.CalculationViewModel;
        }
    }
}