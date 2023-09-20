using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Sub Fraction: Price Denominator of Sub Fraction
    /// </summary>

    public struct SubFraction
    {
        /// <summary>
        ///  Fix Tag for Sub Fraction
        /// </summary>
        public const ushort FixTag = 37703;

        /// <summary>
        ///  Length of Sub Fraction in bytes
        /// </summary>
        public const int Size = 1;

        /// <summary>
        ///  Read Sub Fraction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Decode()
            => Byte;

        /// <summary>
        ///  Write Sub Fraction
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(byte value)
            => Byte = value;

        /// <summary>
        ///  Sub Fraction as string
        /// </summary>
        public override string ToString()
            => $"{{Decode()}}";

        /// <summary>
        ///  Underlying byte
        /// </summary>
        internal byte Byte;
    }
}