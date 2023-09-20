using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Reference Id: Reference to corresponding Price and Security ID, sequence of MD entry in the message
    /// </summary>

    public struct ReferenceId
    {
        /// <summary>
        ///  Fix Tag for Reference Id
        /// </summary>
        public const ushort FixTag = 9633;

        /// <summary>
        ///  Length of Reference Id in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Reference Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Reference Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Reference Id as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}