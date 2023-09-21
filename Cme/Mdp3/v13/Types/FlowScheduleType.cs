using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Flow Schedule Type: The schedule according to which the electricity is delivered in a physical contract, or priced in a financial contract. Specifies whether the contract is defined according to the Easter Peak, Eastern Off-Peak, Western Peak or Western Off-Peak.
    /// </summary>

    public struct FlowScheduleType
    {
        /// <summary>
        ///  Fix Tag for Flow Schedule Type
        /// </summary>
        public const ushort FixTag = 1439;

        /// <summary>
        ///  Size of Flow Schedule Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Flow Schedule Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public sbyte Decode()
            => (sbyte)Byte;

        /// <summary>
        ///  Write Flow Schedule Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(sbyte value)
            => Byte = (byte)value;

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