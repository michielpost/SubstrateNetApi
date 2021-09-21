//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.SpRuntime;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletUtility
{
    
    
    /// <summary>
    /// >> 28 - Variant[pallet_utility.pallet.Event]
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletUtilityEvent
    {
        
        /// <summary>
        /// >> BatchInterrupted
        /// </summary>
        public sealed class BatchInterrupted : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32, SubstrateNetApi.Model.SpRuntime.EnumDispatchError>
        {
        }
        
        /// <summary>
        /// >> BatchCompleted
        /// </summary>
        public sealed class BatchCompleted : BaseTuple
        {
        }
        
        /// <summary>
        /// >> ItemCompleted
        /// </summary>
        public sealed class ItemCompleted : BaseTuple
        {
        }
    }
}
