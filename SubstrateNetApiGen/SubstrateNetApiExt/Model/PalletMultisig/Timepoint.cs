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


namespace SubstrateNetApi.Model.PalletMultisig
{
    
    
    /// <summary>
    /// >> 80 - Composite[pallet_multisig.Timepoint]
    /// </summary>
    public sealed class Timepoint : BaseType
    {
        
        /// <summary>
        /// >> height
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _height;
        
        /// <summary>
        /// >> index
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _index;
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Height
        {
            get
            {
                return this._height;
            }
            set
            {
                this._height = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Index
        {
            get
            {
                return this._index;
            }
            set
            {
                this._index = value;
            }
        }
        
        public override string TypeName()
        {
            return "Timepoint";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Height.Encode());
            result.AddRange(Index.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Height = new SubstrateNetApi.Model.Types.Primitive.U32();
            Height.Decode(byteArray, ref p);
            Index = new SubstrateNetApi.Model.Types.Primitive.U32();
            Index.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
