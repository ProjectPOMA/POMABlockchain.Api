using POMABlockchain.Api.Service.Interfaces;
using POMABlockchain.Modules.JsonRpc.Client;
using POMABlockchain.Modules.RPC.DTOs;
using POMABlockchain.Modules.RPC.Services.Transactions;

namespace POMABlockchain.Api.Service
{
    public class TransactionService : ITransactionService
    {
        private readonly IClient _client;
        public TransactionService(IClient client)
        {
            _client = client;
        }

        public Transaction GetTransactionFromBlockchain(string txId)
        {
            var transaction = new POMABlockchainGetRawTransaction(_client);
            return transaction.SendRequestAsync(txId).Result;

        }
    }
}
