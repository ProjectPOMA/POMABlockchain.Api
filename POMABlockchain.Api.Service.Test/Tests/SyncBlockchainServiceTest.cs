using POMABlockchain.Api.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace POMABlockchain.Api.Service.Test
{
    public class SyncBlockchainServiceTest : BaseTest
    {
        [Fact]
        public void ShoudlSyncBlockchain()
        {
            try
            {
                _syncBlockchainService.SyncBlockchain();
                Assert.True(true);
            }
            catch (Exception ex)
            {

                Assert.False(false, ex.Message);
            }
            

        }
    }
}
