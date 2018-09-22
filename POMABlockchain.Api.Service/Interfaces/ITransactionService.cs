using POMABlockchain.Modules.RPC.DTOs;

namespace POMABlockchain.Api.Service.Interfaces
{
    public interface ITransactionService
    {
        Transaction GetTransactionFromBlockchain(string txId);
    }
}
