using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Max Trade Vol: The maximum trading volume for a security
    /// </summary>

    public unsafe struct MaxTradeVol
    {
        /// <summary>
        ///  Fix Tag for Max Trade Vol
        /// </summary>
        public const ushort FixTag = 1140;

        /// <summary>
        ///  Size of Max Trade Vol in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Max Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Max Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Max Trade Vol as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}