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
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletSudo
{
    
    
    /// <summary>
    /// >> 56 - Variant[pallet_sudo.pallet.Event]
    /// 
    ///			The [event](https://substrate.dev/docs/en/knowledgebase/runtime/events) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class PalletSudoEvent
    {
        
        /// <summary>
        /// >> Sudid
        /// </summary>
        public sealed class Sudid : BaseTuple<BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
        {
        }
        
        /// <summary>
        /// >> KeyChanged
        /// </summary>
        public sealed class KeyChanged : BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32>
        {
        }
        
        /// <summary>
        /// >> SudoAsDone
        /// </summary>
        public sealed class SudoAsDone : BaseTuple<BaseTuple<BaseTuple,  SubstrateNetApi.Model.SpRuntime.EnumDispatchError>>
        {
        }
    }
}