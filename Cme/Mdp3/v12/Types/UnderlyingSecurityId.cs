using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Underlying Security Id: Unique Instrument ID as qualified by the exchange per tag 305-UnderlyingSecurityIDSource
    /// </summary>

    public unsafe struct UnderlyingSecurityId
    {
        /// <summary>
        ///  Fix Tag for Underlying Security Id
        /// </summary>
        public const ushort FixTag = 309;

        /// <summary>
        ///  Size of Underlying Security Id in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Read Underlying Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int Decode()
        {
            fixed (byte* pointer = Bytes) { return (int)pointer; }
        }

        /// <summary>
        ///  Write Underlying Security Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(int value)
        {
            fixed (byte* pointer = Bytes) { *(int *)pointer = value; }
        }

        /// <summary>
        ///  Underlying Security Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}