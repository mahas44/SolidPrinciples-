using Solid.Models.SmsModel;
using Solid.Models;
using System.Net.Mail;

namespace Solid
{
    public abstract class BaseTransfer
    {
        public double Amount { get; set; }

        public abstract double GetTariffRate();

        //public void SendTransferInfoEmailToClient(TransferInfo transfer)
        //{
        //    if (!string.IsNullOrEmpty(transfer.EmailAddress))
        //    {
        //        var mailMessage = new MailMessage();
        //        mailMessage.To.Add(transfer.EmailAddress);

        //        var client = new SmtpClient("mail.transfer.com", 587);
        //        client.Send(mailMessage);
        //    }
        //}

        //public void SendTransferInfoSmsToClient(TransferInfo transfer)
        //{
        //    if (!string.IsNullOrEmpty(transfer.PhoneNumber))
        //    {
        //        var smsSender = new SmsSender();
        //        smsSender.SendSms(new SmsModel()
        //        {
        //            Message = "Your transfer success.",
        //            PhoneNumber = transfer.PhoneNumber,
        //            SendTime = DateTime.Now
        //        });

        //    }
        //}
    }
}
