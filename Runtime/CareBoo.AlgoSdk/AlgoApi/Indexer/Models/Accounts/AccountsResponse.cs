using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct AccountsResponse
        : IEquatable<AccountsResponse>
        , IPaginatedResponse
    {
        [AlgoApiField("accounts", null)]
        public AccountInfo[] Accounts { get; set; }

        [AlgoApiField("current-round", null)]
        public ulong CurrentRound { get; set; }

        [AlgoApiField("next-token", null)]
        public FixedString128Bytes NextToken { get; set; }

        public bool Equals(AccountsResponse other)
        {
            return ArrayComparer.Equals(Accounts, other.Accounts)
                && CurrentRound.Equals(other.CurrentRound)
                && NextToken.Equals(other.NextToken)
                ;
        }
    }
}
