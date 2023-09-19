using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Tick Rule: One Byte Fixed Width Integer
    /// </summary>

    public struct TickRule
    {
        /// <summary>
        ///  Fix Tag for Tick Rule
        /// </summary>
        public const ushort FixTag = 6350;

        /// <summary>
        ///  Length of Tick Rule in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Tick Rule
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Tick Rule
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

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