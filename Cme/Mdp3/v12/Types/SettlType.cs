using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Settl Type: For SPOTs will contain 0. For Fixed date NDFs will contain the value 'B'. For the standard NDFs tenors expressed using Dx, Mx, Wx, and Yx values, where 'x' does not denote business days, but calendar days
    /// </summary>
    public struct SettlType
    {
        /// <summary>
        ///  Fix Tag for Settl Type
        /// </summary>
        public const ushort FixTag = 63;

        /// <summary>
        ///  Length of Settl Type in bytes
        /// </summary>
        public const int Length = 3;

        /// <summary>
        ///  Read Settl Type from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Settl Type
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
        ///  Settl Type as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}