using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Leg Security Id: Leg Security ID
    /// </summary>

    public unsafe struct LegSecurityId
    {
        /// <summary>
        ///  Fix Tag for Leg Security Id
        /// </summary>
        public const ushort FixTag = 602;

        /// <summary>
        ///  Size of Leg Security Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Leg Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Leg Security Id as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}