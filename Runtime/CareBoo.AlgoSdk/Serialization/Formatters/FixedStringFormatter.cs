using AlgoSdk.Json;
using AlgoSdk.MessagePack;
using Unity.Collections;

namespace AlgoSdk.Formatters
{
    public sealed class FixedStringFormatter<T> : IAlgoApiFormatter<T>
        where T : unmanaged, IUTF8Bytes, INativeList<byte>
    {
        public T Deserialize(ref JsonReader reader)
        {
            T result = default;
            reader.ReadString(ref result)
                .ThrowIfError(reader.Char, reader.Position);
            return result;
        }

        public T Deserialize(ref MessagePackReader reader)
        {
            T result = default;
            reader.ReadString(ref result);
            return result;
        }

        public void Serialize(ref JsonWriter writer, T value)
        {
            writer.WriteString(value);
        }

        public void Serialize(ref MessagePackWriter writer, T value)
        {
            writer.WriteString(value);
        }
    }
}
