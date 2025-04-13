using System.Runtime.CompilerServices;

namespace Siac.Recipient
{

    /// <summary>
    ///  Data Feed Indicator: Value Is‘ O For Opra
    /// </summary>

    public struct DataFeedIndicator
    {
        /// <summary>
        ///  Size of Data Feed Indicator in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Data Feed Indicator value
        /// </summary>
        public readonly char Value
            => (char)Byte;

        /// <summary>
        ///  Write Data Feed Indicator
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(char value)
            => Byte = (byte)value;

        /// <summary>
        ///  Data Feed Indicator as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}