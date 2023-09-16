using System;
using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Unit Of Measure Currency: Indicates the ISO Currency code if it is a currency product
    /// </summary>
    public struct UnitOfMeasureCurrency
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure Currency
        /// </summary>
        public const ushort FixTag = 1716;

        /// <summary>
        ///  Length of Unit Of Measure Currency in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Unit Of Measure Currency from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Unit Of Measure Currency
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Length);

            for (var i = 0; i < end; i++)
            {
                Buffer[i] = (byte)value[i];
            }

            for (var i = end; i < Length; i++)
            {
                Buffer[i] = 0;
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
        internal unsafe fixed byte Buffer[Length];
    }
}