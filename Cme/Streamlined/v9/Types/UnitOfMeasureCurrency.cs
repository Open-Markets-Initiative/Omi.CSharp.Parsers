using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Unit Of Measure Currency: Indicates the ISO Currency code if it is a currency product
    /// </summary>
    public unsafe struct UnitOfMeasureCurrency
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Currency
        /// </summary>
        public const ushort FixTag = 1716;

        /// <summary>
        ///  Length of Unit Of Measure Currency in bytes
        /// </summary>
        public const int Size = 3;

        /// <summary>
        ///  Read Unit Of Measure Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Unit Of Measure Currency
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
        ///  Unit Of Measure Currency as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}