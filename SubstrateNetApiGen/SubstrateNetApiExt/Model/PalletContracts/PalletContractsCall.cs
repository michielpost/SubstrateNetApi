//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.PrimitiveTypes;
using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletContracts
{
    
    
    /// <summary>
    /// >> 232 - Variant[pallet_contracts.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletContractsCall
    {
        
        /// <summary>
        /// >> call
        /// </summary>
        public GenericExtrinsicCall Call(SubstrateNetApi.Model.SpRuntime.EnumMultiAddress dest, BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> value, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> gas_limit, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data)
        {
            return new GenericExtrinsicCall("Contracts", "call", dest, value, gas_limit, data);
        }
        
        /// <summary>
        /// >> instantiate_with_code
        /// </summary>
        public GenericExtrinsicCall InstantiateWithCode(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> endowment, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> gas_limit, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> code, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> salt)
        {
            return new GenericExtrinsicCall("Contracts", "instantiate_with_code", endowment, gas_limit, code, data, salt);
        }
        
        /// <summary>
        /// >> instantiate
        /// </summary>
        public GenericExtrinsicCall Instantiate(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> endowment, BaseCom<SubstrateNetApi.Model.Types.Primitive.U64> gas_limit, SubstrateNetApi.Model.PrimitiveTypes.H256 code_hash, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> data, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> salt)
        {
            return new GenericExtrinsicCall("Contracts", "instantiate", endowment, gas_limit, code_hash, data, salt);
        }
    }
}