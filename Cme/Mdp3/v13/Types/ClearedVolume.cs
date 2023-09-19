using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Cleared Volume: The total cleared volume of instrument traded during the prior trading session.
    /// </summary>

    public unsafe struct ClearedVolume
    {
        /// <summary>
        ///  Fix Tag for Cleared Volume
        /// </summary>
        public const ushort FixTag = 5791;

        /// <summary>
        ///  Length of Cleared Volume in bytes
        /// </summary>
        public const int Length = 4;

        /// <summary>
        ///  Sentinel null value for Cleared Volume
        /// </summary>
        public const int NoValue = 2147483647;

        /// <summary>
        ///  Size of Cleared Volume in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Cleared Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Cleared Volume
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Cleared Volume as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}