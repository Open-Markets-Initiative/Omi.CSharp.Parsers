using System;
using System.Runtime.CompilerServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Special Field Length: Length of this field
    /// </summary>

    public unsafe struct SpecialFieldLength
    {
        /// <summary>
        ///  Length of Special Field Length in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Special Field Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Special Field Length
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Value = value;

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Value;
    }
}