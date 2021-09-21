//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.PalletIdentity;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletIdentity
{
    
    
    /// <summary>
    /// >> 424 - Composite[pallet_identity.types.RegistrarInfo]
    /// </summary>
    public sealed class RegistrarInfo : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _account;
        
        /// <summary>
        /// >> fee
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U128 _fee;
        
        /// <summary>
        /// >> fields
        /// </summary>
        private SubstrateNetApi.Model.PalletIdentity.BitFlags _fields;
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Account
        {
            get
            {
                return this._account;
            }
            set
            {
                this._account = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U128 Fee
        {
            get
            {
                return this._fee;
            }
            set
            {
                this._fee = value;
            }
        }
        
        public SubstrateNetApi.Model.PalletIdentity.BitFlags Fields
        {
            get
            {
                return this._fields;
            }
            set
            {
                this._fields = value;
            }
        }
        
        public override string TypeName()
        {
            return "RegistrarInfo";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(Fields.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new SubstrateNetApi.Model.SpCore.AccountId32();
            Account.Decode(byteArray, ref p);
            Fee = new SubstrateNetApi.Model.Types.Primitive.U128();
            Fee.Decode(byteArray, ref p);
            Fields = new SubstrateNetApi.Model.PalletIdentity.BitFlags();
            Fields.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
