//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlgoSdk
{
    
    
    public partial struct AccountParticipation
    {
        
        private static bool @__generated__IsValid = AccountParticipation.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.AccountParticipation>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.AccountParticipation>().Assign("vote-participation-key", "votekey", (AlgoSdk.AccountParticipation x) => x.VoteParticipationKey, (ref AlgoSdk.AccountParticipation x, AlgoSdk.Crypto.Ed25519.PublicKey value) => x.VoteParticipationKey = value, false).Assign("selection-participation-key", "selkey", (AlgoSdk.AccountParticipation x) => x.SelectionParticipationKey, (ref AlgoSdk.AccountParticipation x, AlgoSdk.VrfPubKey value) => x.SelectionParticipationKey = value, false).Assign("vote-first-valid", "votefst", (AlgoSdk.AccountParticipation x) => x.VoteFirst, (ref AlgoSdk.AccountParticipation x, System.UInt64 value) => x.VoteFirst = value, false).Assign("vote-last-valid", "votelst", (AlgoSdk.AccountParticipation x) => x.VoteLast, (ref AlgoSdk.AccountParticipation x, System.UInt64 value) => x.VoteLast = value, false).Assign("vote-key-dilution", "votekd", (AlgoSdk.AccountParticipation x) => x.VoteKeyDilution, (ref AlgoSdk.AccountParticipation x, System.UInt64 value) => x.VoteKeyDilution = value, false));
            return true;
        }
    }
}
