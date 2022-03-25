using System;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct SignTransactionResponse
        : IEquatable<SignTransactionResponse>
    {
        [AlgoApiField("signed_transaction", null)]
        public byte[] SignedTransaction;

        [AlgoApiField("error", null)]
        public Optional<bool> Error;

        [AlgoApiField("message", null)]
        public string Message;

        public bool Equals(SignTransactionResponse other)
        {
            return ArrayComparer.Equals(SignedTransaction, other.SignedTransaction)
                && Error.Equals(other.Error)
                && Message.Equals(other.Message)
                ;
        }
    }
}
