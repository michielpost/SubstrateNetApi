//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletRecovery
{
    
    
    /// <summary>
    /// >> 444 - Composite[pallet_recovery.ActiveRecovery]
    /// </summary>
    public sealed class ActiveRecovery : BaseType
    {
        
        /// <summary>
        /// >> created
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _created;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> friends
        /// </summary>
        private BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> _friends;
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Created
        {
            get
            {
                return this._created;
            }
            set
            {
                this._created = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public BaseVec<SubstrateNetApi.Model.SpCore.AccountId32> Friends
        {
            get
            {
                return this._friends;
            }
            set
            {
                this._friends = value;
            }
        }
        
        public override string TypeName()
        {
            return "ActiveRecovery";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Created.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Friends.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Created = new SubstrateNetApi.Model.Types.Primitive.U32();
            Created.Decode(byteArray, ref p);
            Deposit = new SubstrateNetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Friends = new BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>();
            Friends.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
