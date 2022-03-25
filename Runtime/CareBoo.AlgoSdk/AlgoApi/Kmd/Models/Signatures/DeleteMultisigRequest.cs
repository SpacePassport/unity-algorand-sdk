using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct DeleteMultisigRequest
        : IEquatable<DeleteMultisigRequest>
    {
        [AlgoApiField("address", null)]
        public Address Address;

        [AlgoApiField("wallet_handle_token", null)]
        public FixedString128Bytes WalletHandleToken;

        [AlgoApiField("wallet_password", null)]
        public FixedString128Bytes WalletPassword;

        public bool Equals(DeleteMultisigRequest other)
        {
            return Address.Equals(other.Address)
                && WalletHandleToken.Equals(other.WalletHandleToken)
                && WalletPassword.Equals(other.WalletPassword)
                ;
        }
    }
}
