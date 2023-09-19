using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Market Segment Id: One Byte Fixed Width Integer
    /// </summary>

    public struct MarketSegmentId
    {
        /// <summary>
        ///  Fix Tag for Market Segment Id
        /// </summary>
        public const ushort FixTag = 1300;

        /// <summary>
        ///  Length of Market Segment Id in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Market Segment Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Market Segment Id as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}