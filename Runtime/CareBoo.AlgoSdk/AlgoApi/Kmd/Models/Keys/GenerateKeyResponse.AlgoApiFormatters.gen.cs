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
    
    
    public partial struct GenerateKeyResponse
    {
        
        private static bool @__generated__IsValid = GenerateKeyResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.GenerateKeyResponse>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.GenerateKeyResponse>().Assign("address", null, (AlgoSdk.GenerateKeyResponse x) => x.Address, (ref AlgoSdk.GenerateKeyResponse x, AlgoSdk.Address value) => x.Address = value, false).Assign("error", null, (AlgoSdk.GenerateKeyResponse x) => x.Error, (ref AlgoSdk.GenerateKeyResponse x, AlgoSdk.Optional<System.Boolean> value) => x.Error = value, false).Assign("message", null, (AlgoSdk.GenerateKeyResponse x) => x.Message, (ref AlgoSdk.GenerateKeyResponse x, System.String value) => x.Message = value, AlgoSdk.StringComparer.Instance, false));
            return true;
        }
    }
}
