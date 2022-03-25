using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct ImportKeyRequest
        : IEquatable<ImportKeyRequest>
    {
        [AlgoApiField("private_key", null)]
        public PrivateKey PrivateKey;

        [AlgoApiField("wallet_handle_token", null)]
        public FixedString128Bytes WalletHandleToken;

        public bool Equals(ImportKeyRequest other)
        {
            return PrivateKey.Equals(other.PrivateKey)
                && WalletHandleToken.Equals(other.WalletHandleToken)
                ;
        }
    }
}
