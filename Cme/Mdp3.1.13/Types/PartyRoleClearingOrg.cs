using System;
using System.Runtime.CompilerServices;

namespace Cme.Sbe
{
    /// <summary>
    ///  Party Role Clearing Org: Clearing organization
    /// </summary>
    public struct PartyRoleClearingOrg
    {
        /// <summary>
        ///  Fix Tag for Party Role Clearing Org
        /// </summary>
        public const ushort FixTag = 9736;

        /// <summary>
        ///  Length of Party Role Clearing Org in bytes
        /// </summary>
        public const int Length = 5;

        /// <summary>
        ///  Read Party Role Clearing Org from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Party Role Clearing Org
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
        ///  Party Role Clearing Org as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}