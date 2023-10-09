using Solid.Models;

namespace Solid
{
    public interface ISmsSendable
    {
        void SendTransferInfoSmsToClient(TransferInfo transfer);
    }
}
