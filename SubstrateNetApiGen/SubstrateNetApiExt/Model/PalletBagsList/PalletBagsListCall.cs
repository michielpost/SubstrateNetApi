//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Calls;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletBagsList
{
    
    
    /// <summary>
    /// >> 306 - Variant[pallet_bags_list.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class PalletBagsListCall
    {
        
        /// <summary>
        /// >> rebag
        /// </summary>
        public GenericExtrinsicCall Rebag(SubstrateNetApi.Model.SpCore.AccountId32 dislocated)
        {
            return new GenericExtrinsicCall("BagsList", "rebag", dislocated);
        }
    }
}
