namespace Solid
{
    public class CommissionCalculator
    {
        public double Calculate(BaseTransfer transfer)
        {
            return transfer.Amount * transfer.GetTariffRate();
        }
    }
}
