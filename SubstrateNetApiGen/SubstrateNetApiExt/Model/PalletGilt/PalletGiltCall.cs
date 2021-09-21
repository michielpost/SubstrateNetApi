//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.SpArithmetic;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletGilt
{
    
    
    /// <summary>
    /// >> 298 - Variant[pallet_gilt.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletGiltCall
    {
        
        /// <summary>
        /// >> place_bid
        /// </summary>
        public GenericExtrinsicCall PlaceBid(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> amount, SubstrateNetApi.Model.Types.Primitive.U32 duration)
        {
            return new GenericExtrinsicCall("Gilt", "place_bid", amount, duration);
        }
        
        /// <summary>
        /// >> retract_bid
        /// </summary>
        public GenericExtrinsicCall RetractBid(BaseCom<SubstrateNetApi.Model.Types.Primitive.U128> amount, SubstrateNetApi.Model.Types.Primitive.U32 duration)
        {
            return new GenericExtrinsicCall("Gilt", "retract_bid", amount, duration);
        }
        
        /// <summary>
        /// >> set_target
        /// </summary>
        public GenericExtrinsicCall SetTarget(BaseCom<SubstrateNetApi.Model.SpArithmetic.Perquintill> target)
        {
            return new GenericExtrinsicCall("Gilt", "set_target", target);
        }
        
        /// <summary>
        /// >> thaw
        /// </summary>
        public GenericExtrinsicCall Thaw(BaseCom<SubstrateNetApi.Model.Types.Primitive.U32> index)
        {
            return new GenericExtrinsicCall("Gilt", "thaw", index);
        }
    }
}
