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


namespace SubstrateNetApi.Model.SpSession
{
    
    
    /// <summary>
    /// >> 128 - Composite[sp_session.MembershipProof]
    /// </summary>
    public sealed class MembershipProof : BaseType
    {
        
        /// <summary>
        /// >> session
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _session;
        
        /// <summary>
        /// >> trie_nodes
        /// </summary>
        private BaseVec<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> _trieNodes;
        
        /// <summary>
        /// >> validator_count
        /// </summary>
        private SubstrateNetApi.Model.Types.Primitive.U32 _validatorCount;
        
        public SubstrateNetApi.Model.Types.Primitive.U32 Session
        {
            get
            {
                return this._session;
            }
            set
            {
                this._session = value;
            }
        }
        
        public BaseVec<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> TrieNodes
        {
            get
            {
                return this._trieNodes;
            }
            set
            {
                this._trieNodes = value;
            }
        }
        
        public SubstrateNetApi.Model.Types.Primitive.U32 ValidatorCount
        {
            get
            {
                return this._validatorCount;
            }
            set
            {
                this._validatorCount = value;
            }
        }
        
        public override string TypeName()
        {
            return "MembershipProof";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Session.Encode());
            result.AddRange(TrieNodes.Encode());
            result.AddRange(ValidatorCount.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Session = new SubstrateNetApi.Model.Types.Primitive.U32();
            Session.Decode(byteArray, ref p);
            TrieNodes = new BaseVec<BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>();
            TrieNodes.Decode(byteArray, ref p);
            ValidatorCount = new SubstrateNetApi.Model.Types.Primitive.U32();
            ValidatorCount.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
