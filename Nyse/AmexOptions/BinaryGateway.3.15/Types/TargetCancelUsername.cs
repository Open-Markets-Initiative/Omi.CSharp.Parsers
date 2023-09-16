using System;
using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Target Cancel Username: Optional - either TargetCancelUsername or TargetCancelMPID must be specified for cancel only
    /// </summary>
    public struct TargetCancelUsername
    {
        /// <summary>
        ///  Length of Target Cancel Username in bytes
        /// </summary>
        public const int Length = 16;

        /// <summary>
        ///  Read Target Cancel Username from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Target Cancel Username
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
        ///  Target Cancel Username as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}