//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.NodeRuntime;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace SubstrateNetApi.Model.PalletProxy
{
    
    
    /// <summary>
    /// >> 462 - Composite[pallet_proxy.ProxyDefinition]
    /// </summary>
    public sealed class ProxyDefinition : BaseType
    {
        
        /// <summary>
        /// >> delegate
        /// </summary>
        private SubstrateNetApi.Model.SpCore.AccountId32 _delegate;
        
        /// <summary>
        /// >> proxy_type
        /// </summary>
        private SubstrateNetApi.Model.NodeRuntime.EnumProxyType _proxyType;
        
        /// <summary>
        /// >> delay
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _delay;
        
        public SubstrateNetApi.Model.SpCore.AccountId32 Delegate
        {
            get
            {
                return this._delegate;
            }
            set
            {
                this._delegate = value;
            }
        }
        
        public SubstrateNetApi.Model.NodeRuntime.EnumProxyType ProxyType
        {
            get
            {
                return this._proxyType;
            }
            set
            {
                this._proxyType = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Delay
        {
            get
            {
                return this._delay;
            }
            set
            {
                this._delay = value;
            }
        }
        
        public override string TypeName()
        {
            return "ProxyDefinition";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Delegate.Encode());
            result.AddRange(ProxyType.Encode());
            result.AddRange(Delay.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Delegate = new SubstrateNetApi.Model.SpCore.AccountId32();
            Delegate.Decode(byteArray, ref p);
            ProxyType = new SubstrateNetApi.Model.NodeRuntime.EnumProxyType();
            ProxyType.Decode(byteArray, ref p);
            Delay = new SubstrateNetApi.Model.Types.Primitive.U32();
            Delay.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
