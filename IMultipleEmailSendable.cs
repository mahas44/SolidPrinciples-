using Solid.Models;

namespace Solid
{
    public interface IMultipleEmailSendable
    {
        void SendTransferInfoEmailToClients(List<TransferInfo> transfer);

    }
}
