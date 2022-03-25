using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct ListMultisigRequest
        : IEquatable<ListMultisigRequest>
    {
        [AlgoApiField("wallet_handle_token", null)]
        public FixedString128Bytes WalletHandleToken;

        public bool Equals(ListMultisigRequest other)
        {
            return WalletHandleToken.Equals(other.WalletHandleToken);
        }
    }
}
