using Solid.Models.SmsModel;
using Solid.Models;

namespace Solid
{
    public class IthTransfer : BaseTransfer, ISmsSendable
    {
        public override double GetTariffRate()
        {
            return 0.15;
        }

        public void SendTransferInfoSmsToClient(TransferInfo transfer)
        {
            if (!string.IsNullOrEmpty(transfer.PhoneNumber))
            {
                var smsSender = new SmsSender();
                smsSender.SendSms(new SmsModel()
                {
                    Message = "Your transfer success.",
                    PhoneNumber = transfer.PhoneNumber,
                    SendTime = DateTime.Now
                });

            }
        }
    }
}
