using System.Runtime.CompilerServices;

namespace Siac.Recipient
{

    /// <summary>
    ///  Retransmission Indicator: Contains Either A Space Not A Retransmitted Message Or V Indicating A Retransmission Of The Block
    /// </summary>

    public struct RetransmissionIndicator
    {
        /// <summary>
        ///  Size of Retransmission Indicator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Retransmission Indicator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Retransmission Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Retransmission Indicator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}