using System;
using System.Collections.Generic;
using System.Text;

namespace POMABlockchain.Api.Model
{
    public interface IBlockRepository
    {
        Block GetByHash(string hash);
        void Insert(Block entity);
        void Delete(string hash);
    }
}
