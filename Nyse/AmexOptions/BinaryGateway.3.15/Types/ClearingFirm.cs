using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Clearing Firm: Clearing number of CMTA.
    /// </summary>
    public struct ClearingFirm
    {
        /// <summary>
        ///  Length of Clearing Firm in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Read Clearing Firm from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Clearing Firm
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
        ///  Clearing Firm as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}