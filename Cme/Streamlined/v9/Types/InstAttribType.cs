using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Inst Attrib Type: Code to represent the type of instrument attribute.
    /// </summary>

    public struct InstAttribType
    {
        /// <summary>
        ///  Fix Tag for Inst Attrib Type
        /// </summary>
        public const ushort FixTag = 871;

        /// <summary>
        ///  Length of Inst Attrib Type in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Inst Attrib Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Inst Attrib Type
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Inst Attrib Type as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}