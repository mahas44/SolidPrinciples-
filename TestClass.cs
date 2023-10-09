using Solid.CustomException;
using Solid.Models;

namespace Solid
{
    public class TestClass
    {
        public TestClass()
        {

            /*
            
                S ingle Responsibility Principle  (SRP) OK
                O pen-Close Principle             (OCP) OK
                L iskov Substitution Principle    (LSP) OK
                I nterface Segregation Principle  (ISP) OK
                D ependency Inversion Principle   (DIP) OK                

            */

        }


        public void CalculateCommission()
        {
            var calculator = new CommissionCalculator();

            var commission = calculator.Calculate(new DthTransfer());

            Console.WriteLine($"Total commission for this transfer is {commission}");
        }


        public void SendTransfers()
        {
            try
            {
                var dthTransfer = new DthTransfer();

                dthTransfer.Control();

                dthTransfer.Approval();

                dthTransfer.SendTransferInfoEmailToClient(new TransferInfo());
            }
            catch (TransferControlException ex)
            {
                new TransferInfoLogger(new ELKLogger()).Log(ex.Message);
            }
            catch (CommissionException ex)
            {
                new TransferInfoLogger(new LocaleStorageLogger()).Log(ex.Message);
            }
            catch (Exception ex)
            {
                new TransferInfoLogger(new MasterLogger()).Log(ex.Message);
            }
        }
    }
}
