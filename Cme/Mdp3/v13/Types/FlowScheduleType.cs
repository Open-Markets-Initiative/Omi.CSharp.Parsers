using System.Runtime.CompilerServices;;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Flow Schedule Type: One Byte Fixed Width Integer
    /// </summary>

    public struct FlowScheduleType
    {
        /// <summary>
        ///  Fix Tag for Flow Schedule Type
        /// </summary>
        public const ushort FixTag = 1439;

        /// <summary>
        ///  Length of Flow Schedule Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Flow Schedule Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => Byte;

        /// <summary>
        ///  Write Flow Schedule Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = value;

        /// <summary>
        ///  Flow Schedule Type as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}