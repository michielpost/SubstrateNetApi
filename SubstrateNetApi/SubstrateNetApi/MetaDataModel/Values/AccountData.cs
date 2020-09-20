﻿using Newtonsoft.Json;
using System;
using System.Numerics;

namespace SubstrateNetApi.MetaDataModel.Values
{
    public class AccountData
    {
        public Balance Free { get; }

        public Balance Reserved { get; }

        public Balance MiscFrozen { get; }

        public Balance FeeFrozen { get; }

        public AccountData(string str) : this(Utils.HexToByteArray(str).AsMemory())
        {
        }

        internal AccountData(Memory<byte> memory)
        {
            Free = new Balance(memory.Slice(0, 16).ToArray());
            Reserved = new Balance(memory.Slice(16, 16).ToArray());
            MiscFrozen = new Balance(memory.Slice(32, 16).ToArray());
            FeeFrozen = new Balance(memory.Slice(48, 16).ToArray());
        }

        override
        public string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}