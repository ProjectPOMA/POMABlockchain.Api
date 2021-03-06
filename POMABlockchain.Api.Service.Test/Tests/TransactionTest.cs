﻿using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class TransactionTest : BaseTest
    {
    
        [Fact]
        public void ShouldReturnBlockCount()
        {
            var transaction = _transactionService.GetTransactionFromBlockchain("0x6a2c1e629599f2ab61a7b195aeb026bb0ff98ebc09f72c6d53618c48712433b1");
            Assert.True(transaction != null);
        }
    }
}
