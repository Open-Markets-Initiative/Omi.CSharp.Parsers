using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Lot Type: One Byte Fixed Width Integer
    /// </summary>

    public struct LotType
    {
        /// <summary>
        ///  Fix Tag for Lot Type
        /// </summary>
        public const ushort FixTag = 1093;

        /// <summary>
        ///  Length of Lot Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Lot Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Lot Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Lot Type as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}