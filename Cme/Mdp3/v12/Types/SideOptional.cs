using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Side Optional: One Byte Fixed Width Integer
    /// </summary>

    public struct SideOptional
    {
        /// <summary>
        ///  Fix Tag for Side Optional
        /// </summary>
        public const ushort FixTag = 54;

        /// <summary>
        ///  Length of Side Optional in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Side Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Side Optional
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Side Optional as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}