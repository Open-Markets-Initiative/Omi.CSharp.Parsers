using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Risk Set: Risk Set identifies the list of instruments sharing credit limits set up
    /// </summary>
    public struct RiskSet
    {
        /// <summary>
        ///  Fix Tag for Risk Set
        /// </summary>
        public const ushort FixTag = 37721;

        /// <summary>
        ///  Length of Risk Set in bytes
        /// </summary>
        public const int Length = 6;

        /// <summary>
        ///  Read Risk Set from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Risk Set
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
        ///  Risk Set as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}