using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Clearing Account Covered: OCC number of the Covered side of the Cross order if a non-default value is to be used.  For CUBEs, this is the CUBE Contra order.
    /// </summary>
    public struct ClearingAccountCovered
    {
        /// <summary>
        ///  Length of Clearing Account Covered in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Read Clearing Account Covered from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Clearing Account Covered
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
        ///  Clearing Account Covered as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}