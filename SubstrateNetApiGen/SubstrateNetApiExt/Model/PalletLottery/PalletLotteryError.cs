//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletLottery
{
    
    
    /// <summary>
    /// >> 487 - Variant[pallet_lottery.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://substrate.dev/docs/en/knowledgebase/runtime/errors)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum PalletLotteryError
    {
        
        /// <summary>
        /// >> NotConfigured
        /// </summary>
        NotConfigured,
        
        /// <summary>
        /// >> InProgress
        /// </summary>
        InProgress,
        
        /// <summary>
        /// >> AlreadyEnded
        /// </summary>
        AlreadyEnded,
        
        /// <summary>
        /// >> InvalidCall
        /// </summary>
        InvalidCall,
        
        /// <summary>
        /// >> AlreadyParticipating
        /// </summary>
        AlreadyParticipating,
        
        /// <summary>
        /// >> TooManyCalls
        /// </summary>
        TooManyCalls,
        
        /// <summary>
        /// >> EncodingFailed
        /// </summary>
        EncodingFailed,
    }
}
