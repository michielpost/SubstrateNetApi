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


namespace SubstrateNetApi.Model.PalletBounties
{
    
    
    /// <summary>
    /// >> 81 - Variant[pallet_bounties.RawEvent]
    /// Events for this module.
    /// 
    /// </summary>
    public sealed class PalletBountiesEvent
    {
        
        /// <summary>
        /// >> BountyProposed
        /// </summary>
        public sealed class BountyProposed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> BountyRejected
        /// </summary>
        public sealed class BountyRejected : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U128>
        {
        }
        
        /// <summary>
        /// >> BountyBecameActive
        /// </summary>
        public sealed class BountyBecameActive : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> BountyAwarded
        /// </summary>
        public sealed class BountyAwarded : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> BountyClaimed
        /// </summary>
        public sealed class BountyClaimed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U128, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> BountyCanceled
        /// </summary>
        public sealed class BountyCanceled : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> BountyExtended
        /// </summary>
        public sealed class BountyExtended : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
    }
}
