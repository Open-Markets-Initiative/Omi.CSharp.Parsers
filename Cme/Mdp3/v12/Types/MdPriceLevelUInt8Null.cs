using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Md Price Level u Int 8 Null: Aggregate book level
    /// </summary>

    public struct MdPriceLevelUInt8Null
    {
        /// <summary>
        ///  Fix Tag for Md Price Level u Int 8 Null
        /// </summary>
        public const ushort FixTag = 1023;

        /// <summary>
        ///  Length of Md Price Level u Int 8 Null in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Md Price Level u Int 8 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Md Price Level u Int 8 Null
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Md Price Level u Int 8 Null as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}