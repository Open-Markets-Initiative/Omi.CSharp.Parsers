using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Security Alt Id: Expanded instrument description. Will contain either ISIN or CUSIP
    /// </summary>
    public struct SecurityAltId
    {
        /// <summary>
        ///  Fix Tag for Security Alt Id
        /// </summary>
        public const ushort FixTag = 455;

        /// <summary>
        ///  Length of Security Alt Id in bytes
        /// </summary>
        public const int Length = 12;

        /// <summary>
        ///  Read Security Alt Id from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Security Alt Id
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
        ///  Security Alt Id as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}