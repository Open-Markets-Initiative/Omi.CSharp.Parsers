using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Premium Price: Represents The Price Of An Option Contract Determined In The Competitive Marketplace Which The Buyer Of The Option Pays To The Option Writer For The Rights Conveyed By The Option Contract
    /// </summary>

    public struct PremiumPrice
    {
        /// <summary>
        ///  Size of Premium Price in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Premium Price value
        /// </summary>
        public readonly int Value
            => Decode();

        /// <summary>
        ///  Read Premium Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly int Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Premium Price
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Premium Price as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal int Underlying;
    }
}