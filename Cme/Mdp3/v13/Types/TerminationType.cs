using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Termination Type: For Repos the timing or method for terminating the agreement. Term code
    /// </summary>
    public struct TerminationType
    {
        /// <summary>
        ///  Fix Tag for Termination Type
        /// </summary>
        public const ushort FixTag = 788;

        /// <summary>
        ///  Length of Termination Type in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Read Termination Type from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Termination Type
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
        ///  Termination Type as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}