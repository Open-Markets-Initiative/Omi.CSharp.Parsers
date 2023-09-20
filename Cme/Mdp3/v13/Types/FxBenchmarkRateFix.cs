using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Fx Benchmark Rate Fix: Fixing Rate Description
    /// </summary>
    public unsafe struct FxBenchmarkRateFix
    {
        /// <summary>
        ///  Fix Tag for Fx Benchmark Rate Fix
        /// </summary>
        public const ushort FixTag = 2796;

        /// <summary>
        ///  Size of Fx Benchmark Rate Fix underlying field in bytes
        /// </summary>
        public const int Size = 20;

        /// <summary>
        ///  Read Fx Benchmark Rate Fix from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
        {
            fixed (byte* pointer = Bytes) { return new string((sbyte*)pointer, 0, Size); }
        }

        /// <summary>
        ///  Encode Fx Benchmark Rate Fix
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
        ///  Fx Benchmark Rate Fix as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}