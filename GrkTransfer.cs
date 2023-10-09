using Solid.Models;
using System.Net.Mail;

namespace Solid
{
    public class GrkTransfer : BaseTransfer, IEmailSendable, IMultipleEmailSendable
    {
        public override double GetTariffRate()
        {
            return 0.1;
        }

        public void SendTransferInfoEmailToClient(TransferInfo transfer)
        {
            if (!string.IsNullOrEmpty(transfer.EmailAddress))
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(transfer.EmailAddress);

                var client = new SmtpClient("mail.transfer.com", 587);
                client.Send(mailMessage);
            }
        }

        public void SendTransferInfoEmailToClients(List<TransferInfo> transfers)
        {
            foreach (var transfer in transfers)
            {
                SendTransferInfoEmailToClient(transfer);
            }
        }
    }
}
