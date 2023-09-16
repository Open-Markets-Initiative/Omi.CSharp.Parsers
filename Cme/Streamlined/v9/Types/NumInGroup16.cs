using System.Runtime.CompilerServices;;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Num In Group 16:
    /// </summary>

    public unsafe struct NumInGroup16
    {
        /// <summary>
        ///  Length of Num In Group 16 in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Num In Group 16
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ushort Decode()
            => Value;

        /// <summary>
        ///  Encode Num In Group 16
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