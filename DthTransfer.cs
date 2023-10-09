using System.Net.Mail;
using Solid.Models;
using Solid.Models.SmsModel;

namespace Solid
{
    public class DthTransfer : BaseTransfer, ISmsSendable, IEmailSendable
    {
        public override double GetTariffRate()
        {
            return 0.05;
        }

        public void Control()
        {
            Console.WriteLine("DTH Transfer Inputs checking...");
        }

        public void Approval()
        {
            Console.WriteLine("Transfer success.");
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
