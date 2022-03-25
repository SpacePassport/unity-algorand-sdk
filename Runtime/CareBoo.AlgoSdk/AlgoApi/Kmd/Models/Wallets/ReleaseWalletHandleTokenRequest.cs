using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct ReleaseWalletHandleTokenRequest
        : IEquatable<ReleaseWalletHandleTokenRequest>
    {
        [AlgoApiField("wallet_handle_token", null)]
        public FixedString128Bytes WalletHandleToken;

        public bool Equals(ReleaseWalletHandleTokenRequest other)
        {
            return WalletHandleToken.Equals(other.WalletHandleToken);
        }
    }
}
