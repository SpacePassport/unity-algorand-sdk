using System;
using AlgoSdk.Crypto;
using AlgoSdk.LowLevel;
using Unity.Collections;

namespace AlgoSdk
{
    [AlgoApiObject]
    public partial struct Multisig
        : ISignature
        , IEquatable<Multisig>
    {
        public static readonly byte[] AddressPrefix = System.Text.Encoding.UTF8.GetBytes("MultisigAddr");

        /// <summary>
        /// Subsignatures representing this multisig.
        /// </summary>
        [AlgoApiField("subsig", "subsig")]
        public Subsig[] Subsigs;

        /// <summary>
        /// Number of signatures required for the multisig to be valid.
        /// </summary>
        [AlgoApiField("thr", "thr")]
        public byte Threshold;

        /// <summary>
        /// Version of the multisig.
        /// </summary>
        [AlgoApiField("v", "v")]
        public byte Version;

        /// <summary>
        /// Create a new multisig
        /// </summary>
        /// <param name="version">The version of the msig protocol. The latest version is version 1.</param>
        /// <param name="threshold">The number of signatures required for this msig to be valid.</param>
        /// <param name="addresses">The addresses or public keys composing this msig. Order matters!</param>
        public Multisig(
            byte version,
            byte threshold,
            Address[] addresses
        )
        {
            Version = version;
            Threshold = threshold;
            if (addresses == null)
            {
                Subsigs = null;
            }
            else
            {
                Subsigs = new Subsig[addresses.Length];
                for (var i = 0; i < Subsigs.Length; i++)
                    Subsigs[i] = new Subsig { PublicKey = addresses[i] };
            }
        }

        public bool Equals(Multisig other)
        {
            return ArrayComparer.Equals(Subsigs, other.Subsigs)
                && Threshold.Equals(other.Threshold)
                && Version.Equals(other.Version)
                ;
        }

        /// <summary>
        /// Verify this msig against the message.
        /// </summary>
        /// <param name="message">The message that was signed.</param>
        /// <typeparam name="TMessage">The type of the bytearray the message is contained in.</typeparam>
        /// <returns>true if a threshold of signatures were valid, fals otherwise</returns>
        public bool Verify<TMessage>(TMessage message)
            where TMessage : IByteArray
        {
            byte verified = 0;
            if (Subsigs != null)
            {
                for (var i = 0; i < Subsigs.Length; i++)
                {
                    var pk = Subsigs[i].PublicKey;
                    var sig = Subsigs[i].Sig;
                    if (sig.Verify(message, pk))
                        verified++;
                }
            }
            return verified >= Threshold;
        }

        /// <summary>
        /// Generate the address for this <see cref="Multisig"/>.
        /// </summary>
        /// <returns>An <see cref="Address"/> made from hashing the addresses in this subsig.</returns>
        public Address GetAddress()
        {
            var result = Address.Empty;
            if (Subsigs == null)
                return result;

            using (var listBytes = new NativeList<byte>(Allocator.Temp))
            {
                using var addrPrefix = new NativeArray<byte>(AddressPrefix, Allocator.Temp);
                listBytes.AddRange(addrPrefix);
                listBytes.Add(Version);
                listBytes.Add(Threshold);
                for (var i = 0; i < Subsigs.Length; i++)
                {
                    using var subsigPk = Subsigs[i].PublicKey.ToNativeArray(Allocator.Temp);
                    listBytes.AddRange(subsigPk);
                }
                var bytes = new NativeByteArray(listBytes.AsArray());
                Sha512.Hash256Truncated(bytes).CopyTo(ref result);
            }
            return result;
        }

        [AlgoApiObject]
        public partial struct Subsig
            : IEquatable<Subsig>
        {
            /// <summary>
            /// The address for this subsig.
            /// </summary>
            [AlgoApiField("pk", "pk")]
            public Ed25519.PublicKey PublicKey;

            /// <summary>
            /// The signed message if it exists.
            /// </summary>
            [AlgoApiField("s", "s")]
            public Sig Sig;

            public bool Equals(Subsig other)
            {
                return Sig.Equals(other.Sig);
            }

            public static implicit operator Subsig(Address address)
            {
                return new Subsig { PublicKey = address };
            }

            public static implicit operator Address(Subsig subsig)
            {
                return subsig.PublicKey;
            }
        }
    }
}
