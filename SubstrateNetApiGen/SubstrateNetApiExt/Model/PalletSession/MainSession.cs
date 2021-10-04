//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SubstrateNetApi.Model.Extrinsics;
using SubstrateNetApi.Model.Meta;
using SubstrateNetApi.Model.NodeRuntime;
using SubstrateNetApi.Model.SpCore;
using SubstrateNetApi.Model.Types;
using SubstrateNetApi.Model.Types.Base;
using SubstrateNetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace SubstrateNetApi.Model.PalletSession
{
    
    
    public sealed class SessionStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SessionStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "Validators"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "CurrentIndex"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "QueuedChanged"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "QueuedKeys"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "DisabledValidators"), new System.Tuple<Storage.Hasher[],Type>(null, null));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "NextKeys"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(SubstrateNetApi.Model.SpCore.AccountId32)));
            _client.StorageKeyDict.Add(new System.Tuple<string,string>("Session", "KeyOwner"), new System.Tuple<Storage.Hasher[],Type>(new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                            SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(BaseTuple<SubstrateNetApi.Model.SpCore.KeyTypeId,BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>>)));
        }
        
        /// <summary>
        /// >> ValidatorsParams
        ///  The current set of validators.
        /// </summary>
        public static string ValidatorsParams()
        {
            return RequestGenerator.GetStorage("Session", "Validators", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Validators
        ///  The current set of validators.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>> Validators(CancellationToken token)
        {
            string parameters = SessionStorage.ValidatorsParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.SpCore.AccountId32>>(parameters, token);
        }
        
        /// <summary>
        /// >> CurrentIndexParams
        ///  Current index of the session.
        /// </summary>
        public static string CurrentIndexParams()
        {
            return RequestGenerator.GetStorage("Session", "CurrentIndex", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> CurrentIndex
        ///  Current index of the session.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.U32> CurrentIndex(CancellationToken token)
        {
            string parameters = SessionStorage.CurrentIndexParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> QueuedChangedParams
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public static string QueuedChangedParams()
        {
            return RequestGenerator.GetStorage("Session", "QueuedChanged", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueuedChanged
        ///  True if the underlying economic identities or weighting behind the validators
        ///  has changed in the queued validator set.
        /// </summary>
        public async Task<SubstrateNetApi.Model.Types.Primitive.Bool> QueuedChanged(CancellationToken token)
        {
            string parameters = SessionStorage.QueuedChangedParams();
            return await _client.GetStorageAsync<SubstrateNetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
        
        /// <summary>
        /// >> QueuedKeysParams
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public static string QueuedKeysParams()
        {
            return RequestGenerator.GetStorage("Session", "QueuedKeys", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> QueuedKeys
        ///  The queued keys for the next session. When the next session begins, these keys
        ///  will be used to determine the validator's session keys.
        /// </summary>
        public async Task<BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.NodeRuntime.SessionKeys>>> QueuedKeys(CancellationToken token)
        {
            string parameters = SessionStorage.QueuedKeysParams();
            return await _client.GetStorageAsync<BaseVec<BaseTuple<SubstrateNetApi.Model.SpCore.AccountId32,SubstrateNetApi.Model.NodeRuntime.SessionKeys>>>(parameters, token);
        }
        
        /// <summary>
        /// >> DisabledValidatorsParams
        ///  Indices of disabled validators.
        /// 
        ///  The set is cleared when `on_session_ending` returns a new set of identities.
        /// </summary>
        public static string DisabledValidatorsParams()
        {
            return RequestGenerator.GetStorage("Session", "DisabledValidators", SubstrateNetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> DisabledValidators
        ///  Indices of disabled validators.
        /// 
        ///  The set is cleared when `on_session_ending` returns a new set of identities.
        /// </summary>
        public async Task<BaseVec<SubstrateNetApi.Model.Types.Primitive.U32>> DisabledValidators(CancellationToken token)
        {
            string parameters = SessionStorage.DisabledValidatorsParams();
            return await _client.GetStorageAsync<BaseVec<SubstrateNetApi.Model.Types.Primitive.U32>>(parameters, token);
        }
        
        /// <summary>
        /// >> NextKeysParams
        ///  The next session keys for a validator.
        /// </summary>
        public static string NextKeysParams(SubstrateNetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Session", "NextKeys", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> NextKeys
        ///  The next session keys for a validator.
        /// </summary>
        public async Task<SubstrateNetApi.Model.NodeRuntime.SessionKeys> NextKeys(SubstrateNetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SessionStorage.NextKeysParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.NodeRuntime.SessionKeys>(parameters, token);
        }
        
        /// <summary>
        /// >> KeyOwnerParams
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public static string KeyOwnerParams(BaseTuple<SubstrateNetApi.Model.SpCore.KeyTypeId,BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> key)
        {
            return RequestGenerator.GetStorage("Session", "KeyOwner", SubstrateNetApi.Model.Meta.Storage.Type.Map, new SubstrateNetApi.Model.Meta.Storage.Hasher[] {
                        SubstrateNetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new SubstrateNetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> KeyOwner
        ///  The owner of a key. The key is the `KeyTypeId` + the encoded key.
        /// </summary>
        public async Task<SubstrateNetApi.Model.SpCore.AccountId32> KeyOwner(BaseTuple<SubstrateNetApi.Model.SpCore.KeyTypeId,BaseVec<SubstrateNetApi.Model.Types.Primitive.U8>> key, CancellationToken token)
        {
            string parameters = SessionStorage.KeyOwnerParams(key);
            return await _client.GetStorageAsync<SubstrateNetApi.Model.SpCore.AccountId32>(parameters, token);
        }
    }
    
    public sealed class SessionCalls
    {
        
        /// <summary>
        /// >> set_keys
        /// Dispatchable calls.
        /// 
        /// Each variant of this enum maps to a dispatchable function from the associated module.
        /// </summary>
        public static Method SetKeys(SubstrateNetApi.Model.NodeRuntime.SessionKeys keys, BaseVec<SubstrateNetApi.Model.Types.Primitive.U8> proof)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(keys.Encode());
            byteArray.AddRange(proof.Encode());
            return new Method(10, "Session", 0, "set_keys", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> purge_keys
        /// Dispatchable calls.
        /// 
        /// Each variant of this enum maps to a dispatchable function from the associated module.
        /// </summary>
        public static Method PurgeKeys()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(10, "Session", 1, "purge_keys", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> NewSession
    /// New session has happened. Note that the argument is the \[session_index\], not the
    /// block number as the type might suggest.
    /// </summary>
    public sealed class EventNewSession : BaseTuple<SubstrateNetApi.Model.Types.Primitive.U32>
    {
    }
    
    public enum SessionErrors
    {
        
        /// <summary>
        /// >> InvalidProof
        /// Invalid ownership proof.
        /// </summary>
        InvalidProof,
        
        /// <summary>
        /// >> NoAssociatedValidatorId
        /// No associated validator ID for account.
        /// </summary>
        NoAssociatedValidatorId,
        
        /// <summary>
        /// >> DuplicatedKey
        /// Registered duplicate key.
        /// </summary>
        DuplicatedKey,
        
        /// <summary>
        /// >> NoKeys
        /// No keys are associated with this account.
        /// </summary>
        NoKeys,
        
        /// <summary>
        /// >> NoAccount
        /// Key setting account is not live, so it's impossible to associate keys.
        /// </summary>
        NoAccount,
    }
}
