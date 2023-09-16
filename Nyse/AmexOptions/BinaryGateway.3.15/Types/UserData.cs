using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  User Data: Customer defined up to 10 characters; only printable ASCII characters allowed, excluding comma, semicolon, pipe delimiter, “at” symbol, greater than/less than, ampersand (&) and single/double quotation mark.
    /// </summary>
    public struct UserData
    {
        /// <summary>
        ///  Length of User Data in bytes
        /// </summary>
        public const int Length = 10;

        /// <summary>
        ///  Read User Data from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode User Data
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
        ///  User Data as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}