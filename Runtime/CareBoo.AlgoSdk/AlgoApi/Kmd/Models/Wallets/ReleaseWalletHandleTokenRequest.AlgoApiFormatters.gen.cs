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
    
    
    public partial struct ReleaseWalletHandleTokenRequest
    {
        
        private static bool @__generated__IsValid = ReleaseWalletHandleTokenRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            AlgoSdk.AlgoApiFormatterLookup.Add<AlgoSdk.ReleaseWalletHandleTokenRequest>(new AlgoSdk.AlgoApiObjectFormatter<AlgoSdk.ReleaseWalletHandleTokenRequest>().Assign("wallet_handle_token", null, (AlgoSdk.ReleaseWalletHandleTokenRequest x) => x.WalletHandleToken, (ref AlgoSdk.ReleaseWalletHandleTokenRequest x, Unity.Collections.FixedString128Bytes value) => x.WalletHandleToken = value, false));
            return true;
        }
    }
}
