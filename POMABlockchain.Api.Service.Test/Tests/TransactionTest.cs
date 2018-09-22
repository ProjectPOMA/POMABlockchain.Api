using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class TransactionTest
    {
        private readonly TransactionService _transactionService;
        public TransactionTest()
        {
            _transactionService = new TransactionService(ClientFactory.GetClient(new TestSettings()));
        }

        [Fact]
        public void ShouldReturnBlockCount()
        {
            var transaction = _transactionService.GetTransactionFromBlockchain("0xc5bc3cfe0d7aa08b9a86f5a351bf5540f0e2eceb6a30b4667382f6c41529fd3f");
            Assert.True(transaction != null);
        }
    }
}
