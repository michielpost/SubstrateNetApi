//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletGrandpa
{
    
    
    public enum StoredState
    {
        
        Live,
        
        PendingPause,
        
        Paused,
        
        PendingResume,
    }
    
    /// <summary>
    /// >> 393 - Variant[pallet_grandpa.StoredState]
    /// </summary>
    public sealed class EnumStoredState : BaseEnumExt<StoredState, BaseVoid, BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>, BaseVoid, BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.Types.Primitive.U32>>
    {
    }
}
