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
    
    
    public partial struct EvalDeltaKeyValue
    {
        
        private static bool @__generated__IsValid = EvalDeltaKeyValue.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.EvalDeltaKeyValue>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.EvalDeltaKeyValue>().Assign("key", "key", (AlgoSdk.EvalDeltaKeyValue x) => x.Key, (ref AlgoSdk.EvalDeltaKeyValue x, Unity.Collections.FixedString64Bytes value) => x.Key = value, false).Assign("value", "value", (AlgoSdk.EvalDeltaKeyValue x) => x.Value, (ref AlgoSdk.EvalDeltaKeyValue x, AlgoSdk.EvalDelta value) => x.Value = value, false));
            return true;
        }
    }
}
