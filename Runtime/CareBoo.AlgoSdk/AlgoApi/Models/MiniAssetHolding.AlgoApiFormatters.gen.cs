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
    
    
    public partial struct MiniAssetHolding
    {
        
        private static bool @__generated__IsValid = MiniAssetHolding.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.MiniAssetHolding>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.MiniAssetHolding>().Assign("address", null, (AlgoSdk.MiniAssetHolding x) => x.Address, (ref AlgoSdk.MiniAssetHolding x, AlgoSdk.Address value) => x.Address = value, false).Assign("amount", null, (AlgoSdk.MiniAssetHolding x) => x.Amount, (ref AlgoSdk.MiniAssetHolding x, System.UInt64 value) => x.Amount = value, false).Assign("deleted", null, (AlgoSdk.MiniAssetHolding x) => x.Deleted, (ref AlgoSdk.MiniAssetHolding x, AlgoSdk.Optional<System.Boolean> value) => x.Deleted = value, false).Assign("is-frozen", null, (AlgoSdk.MiniAssetHolding x) => x.IsFrozen, (ref AlgoSdk.MiniAssetHolding x, AlgoSdk.Optional<System.Boolean> value) => x.IsFrozen = value, false).Assign("opted-in-at-round", null, (AlgoSdk.MiniAssetHolding x) => x.OptedInAtRound, (ref AlgoSdk.MiniAssetHolding x, System.UInt64 value) => x.OptedInAtRound = value, false).Assign("opted-out-at-round", null, (AlgoSdk.MiniAssetHolding x) => x.OptedOutAtRound, (ref AlgoSdk.MiniAssetHolding x, System.UInt64 value) => x.OptedOutAtRound = value, false));
            return true;
        }
    }
}