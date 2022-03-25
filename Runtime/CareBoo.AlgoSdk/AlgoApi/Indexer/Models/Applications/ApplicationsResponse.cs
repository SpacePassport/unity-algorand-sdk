using System;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct ApplicationsResponse
        : IEquatable<ApplicationsResponse>
        , IPaginatedResponse
    {
        [AlgoApiField("applications", null)]
        public Application[] Applications { get; set; }

        [AlgoApiField("current-round", null)]
        public ulong CurrentRound { get; set; }

        [AlgoApiField("next-token", null)]
        public FixedString128Bytes NextToken { get; set; }

        public bool Equals(ApplicationsResponse other)
        {
            return ArrayComparer.Equals(Applications, other.Applications)
                && CurrentRound.Equals(other.CurrentRound)
                && NextToken.Equals(other.NextToken)
                ;
        }
    }
}
