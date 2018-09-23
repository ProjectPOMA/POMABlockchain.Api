using System;
using System.Collections.Generic;
using System.Text;

namespace POMABlockchain.Api.Model
{
    public class Block : Modules.RPC.DTOs.Block
    {
        public string IdMongo { get; set; }
    }
}
