using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Unit Of Measure: Unit of measure for the products' original contract size. This will be populated for all products listed on CME Globex
    /// </summary>
    public unsafe struct UnitOfMeasure
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure
        /// </summary>
        public const ushort FixTag = 996;

        /// <summary>
        ///  Size of Unit Of Measure underlying field in bytes
        /// </summary>
        public const int Size = 30;

        /// <summary>
        ///  Read Unit Of Measure from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Unit Of Measure
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
        ///  Unit Of Measure as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}