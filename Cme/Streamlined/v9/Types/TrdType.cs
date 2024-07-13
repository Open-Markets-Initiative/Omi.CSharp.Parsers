using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Trd Type: Valid trade types for intraday trade
    /// </summary>

    public struct TrdType
    {
        /// <summary>
        ///  Fix Tag for Trd Type
        /// </summary>
        public const ushort FixTag = 828;

        /// <summary>
        ///  Sentinel null value for Trd Type
        /// </summary>
        public const byte NoValue = 255;

        /// <summary>
        ///  Length of Trd Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Trd Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Trd Type as string
        /// </summary>
        public readonly override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}