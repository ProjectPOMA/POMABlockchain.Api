using POMABlockchain.Modules.RPC.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace POMABlockchain.Api.Service
{
    public interface IBlockService
    {
        Block GetBlockFromBlockchain(int index);
    }
}
