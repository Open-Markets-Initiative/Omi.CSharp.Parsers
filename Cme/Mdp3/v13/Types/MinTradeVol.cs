using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Min Trade Vol: The minimum trading volume for a security
    /// </summary>

    public unsafe struct MinTradeVol
    {
        /// <summary>
        ///  Fix Tag for Min Trade Vol
        /// </summary>
        public const ushort FixTag = 562;

        /// <summary>
        ///  Size of Min Trade Vol in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Min Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Min Trade Vol
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Min Trade Vol as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}