using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Trade Link Id: Contains the workup ID; unique per instrument per day
    /// </summary>

    public unsafe struct TradeLinkId
    {
        /// <summary>
        ///  Fix Tag for Trade Link Id
        /// </summary>
        public const ushort FixTag = 820;

        /// <summary>
        ///  Size of Trade Link Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Trade Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint Decode()
        {
            fixed (byte* pointer = Bytes) { return (uint)pointer; }
        }

        /// <summary>
        ///  Write Trade Link Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
        {
            fixed (byte* pointer = Bytes) { *(uint *)pointer = value; }
        }

        /// <summary>
        ///  Trade Link Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}