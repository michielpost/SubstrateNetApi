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


namespace SubstrateNetApi.Model.PalletAssets
{
    
    
    /// <summary>
    /// >> 83 - Variant[pallet_assets.pallet.Event]
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletAssetsEvent
    {
        
        /// <summary>
        /// >> Created
        /// </summary>
        public sealed class Created : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> Issued
        /// </summary>
        public sealed class Issued : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
        {
        }
        
        /// <summary>
        /// >> Transferred
        /// </summary>
        public sealed class Transferred : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
        {
        }
        
        /// <summary>
        /// >> Burned
        /// </summary>
        public sealed class Burned : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
        {
        }
        
        /// <summary>
        /// >> TeamChanged
        /// </summary>
        public sealed class TeamChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> OwnerChanged
        /// </summary>
        public sealed class OwnerChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> Frozen
        /// </summary>
        public sealed class Frozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> Thawed
        /// </summary>
        public sealed class Thawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> AssetFrozen
        /// </summary>
        public sealed class AssetFrozen : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> AssetThawed
        /// </summary>
        public sealed class AssetThawed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> Destroyed
        /// </summary>
        public sealed class Destroyed : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> ForceCreated
        /// </summary>
        public sealed class ForceCreated : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> MetadataSet
        /// </summary>
        public sealed class MetadataSet : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>, SubstrateNetApi.Model.Types.Primitive.U8, SubstrateNetApi.Model.Types.Primitive.Bool>
        {
        }
        
        /// <summary>
        /// >> MetadataCleared
        /// </summary>
        public sealed class MetadataCleared : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
        
        /// <summary>
        /// >> ApprovedTransfer
        /// </summary>
        public sealed class ApprovedTransfer : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
        {
        }
        
        /// <summary>
        /// >> ApprovalCancelled
        /// </summary>
        public sealed class ApprovalCancelled : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> TransferredApproved
        /// </summary>
        public sealed class TransferredApproved : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.SpCore.AccountId32, SubstrateNetApi.Model.Types.Primitive.U64>
        {
        }
        
        /// <summary>
        /// >> AssetStatusChanged
        /// </summary>
        public sealed class AssetStatusChanged : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
        {
        }
    }
}