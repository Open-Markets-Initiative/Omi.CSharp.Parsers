using System.Buffers.Binary;
using System.Runtime.CompilerServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Participant Reference Number: The Prn Is For Optional Use By The Participant
    /// </summary>

    public struct ParticipantReferenceNumber
    {
        /// <summary>
        ///  Size of Participant Reference Number in bytes
        /// </summary>
        public const int Size = 4;

        /// <summary>
        ///  Participant Reference Number value
        /// </summary>
        public readonly uint Value
            => Decode();

        /// <summary>
        ///  Read Participant Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly uint Decode()
            => BinaryPrimitives.ReverseEndianness(Underlying);

        /// <summary>
        ///  Write Participant Reference Number
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(uint value)
            => Underlying = BinaryPrimitives.ReverseEndianness(value);

        /// <summary>
        ///  Set Participant Reference Number to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Participant Reference Number as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal uint Underlying;
    }
}