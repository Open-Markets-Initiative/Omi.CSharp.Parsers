using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Tick Rule: VTT code referencing variable tick table
    /// </summary>

    public struct TickRule
    {
        /// <summary>
        ///  Fix Tag for Tick Rule
        /// </summary>
        public const ushort FixTag = 6350;

        /// <summary>
        ///  Size of Tick Rule in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Tick Rule
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Tick Rule
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

        /// <summary>
        ///  Tick Rule as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}