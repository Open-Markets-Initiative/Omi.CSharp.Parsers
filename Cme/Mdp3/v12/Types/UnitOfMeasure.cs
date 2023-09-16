using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Unit Of Measure: Unit of measure for the products' original contract size. This will be populated for all products listed on CME Globex
    /// </summary>
    public struct UnitOfMeasure
    {
        /// <summary>
        ///  Fix Tag for Unit Of Measure
        /// </summary>
        public const ushort FixTag = 996;

        /// <summary>
        ///  Length of Unit Of Measure in bytes
        /// </summary>
        public const int Length = 30;

        /// <summary>
        ///  Read Unit Of Measure from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Unit Of Measure
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
        ///  Unit Of Measure as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}