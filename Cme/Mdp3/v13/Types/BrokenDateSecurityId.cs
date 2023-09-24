using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Broken Date Security Id: Broken date Instrument Globex Security ID
    /// </summary>

    public unsafe struct BrokenDateSecurityId
    {
        /// <summary>
        ///  Fix Tag for Broken Date Security Id
        /// </summary>
        public const ushort FixTag = 39027;

        /// <summary>
        ///  Size of Broken Date Security Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Broken Date Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Broken Date Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Broken Date Security Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}