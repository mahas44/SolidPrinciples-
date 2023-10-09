using Solid.Models;

namespace Solid
{
    public interface IEmailSendable
    {
        void SendTransferInfoEmailToClient(TransferInfo transfer);
    }
}
