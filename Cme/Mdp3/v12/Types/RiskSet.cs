using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Risk Set: Risk Set identifies the list of instruments sharing credit limits set up
    /// </summary>
    public unsafe struct RiskSet
    {
        /// <summary>
        ///  Fix Tag for Risk Set
        /// </summary>
        public const ushort FixTag = 37721;

        /// <summary>
        ///  Size of Risk Set underlying field in bytes
        /// </summary>
        public const int Size = 6;

        /// <summary>
        ///  Read Risk Set from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Risk Set
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Size);

            for (var i = 0; i < end; i++)
            {
                Bytes[i] = (byte)value[i];
            }

            for (var i = end; i < Size; i++)
            {
                Bytes[i] = 0;
            }
        }

        /// <summary>
        ///  Risk Set as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}