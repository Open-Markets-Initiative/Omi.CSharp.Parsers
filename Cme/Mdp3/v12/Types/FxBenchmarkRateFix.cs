using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Fx Benchmark Rate Fix: Fixing Rate Description
    /// </summary>
    public struct FxBenchmarkRateFix
    {
        /// <summary>
        ///  Fix Tag for Fx Benchmark Rate Fix
        /// </summary>
        public const ushort FixTag = 2796;

        /// <summary>
        ///  Length of Fx Benchmark Rate Fix in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Read Fx Benchmark Rate Fix from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Fx Benchmark Rate Fix
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Encode(string value)
        {
            var end = Math.Min(value.Length, Length);

            for (var i = 0; i < end; i++)
            {
                Buffer[i] = (byte)value[i];
            }

            for (var i = end; i < Length; i++)
            {
                Buffer[i] = 0;
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
        internal unsafe fixed byte Buffer[Length];
    }
}