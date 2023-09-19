using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Market Set: Market Set defines the bilateral relationship and Self Match Prevention configuration for eligible markets
    /// </summary>
    public unsafe struct MarketSet
    {
        /// <summary>
        ///  Fix Tag for Market Set
        /// </summary>
        public const ushort FixTag = 37722;

        /// <summary>
        ///  Length of Market Set in bytes
        /// </summary>
        public const int Size = 6;

        /// <summary>
        ///  Read Market Set from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Market Set
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
            }
        }

        /// <summary>
        ///  Market Set as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}