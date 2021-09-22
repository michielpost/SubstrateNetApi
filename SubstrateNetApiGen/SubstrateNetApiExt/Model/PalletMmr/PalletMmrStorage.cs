//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.PrimitiveTypes;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletMmr
{
    
    
    public sealed class PalletMmrStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateNetApi.SubstrateClient _client;
        
        public PalletMmrStorage(SubstrateNetApi.SubstrateClient client)
        {
            this._client = client;
        }
        
        /// <summary>
        /// >> RootHash
        /// </summary>
        public async Task<SubstrateNetApi.Model.PrimitiveTypes.H256> RootHash(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("Mmr", "RootHash", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PrimitiveTypes.H256>(parameters, token);
        }
        
        /// <summary>
        /// >> NumberOfLeaves
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U64> NumberOfLeaves(CancellationToken token)
        {
            var parameters = RequestGenerator.GetStorage("Mmr", "NumberOfLeaves", Storage.Type.Plain);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U64>(parameters, token);
        }
        
        /// <summary>
        /// >> Nodes
        /// </summary>
        public async Task<SubstrateNetApi.Model.PrimitiveTypes.H256> Nodes(SubstrateNetApi.Model.Types.Primitive.U64 key, CancellationToken token)
        {
            var keyParams = new IType[] { key };
            var parameters = RequestGenerator.GetStorage("Mmr", "Nodes", Storage.Type.Map, new[] {Storage.Hasher.Identity}, keyParams);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.PrimitiveTypes.H256>(parameters, token);
        }
    }
}