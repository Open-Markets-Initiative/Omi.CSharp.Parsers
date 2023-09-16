using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Fix Rate Local Time Zone: Fixing Rate Local Time Zone corresponding to Fixing Local Time.
    /// </summary>
    public struct FixRateLocalTimeZone
    {
        /// <summary>
        ///  Fix Tag for Fix Rate Local Time Zone
        /// </summary>
        public const ushort FixTag = 37727;

        /// <summary>
        ///  Length of Fix Rate Local Time Zone in bytes
        /// </summary>
        public const int Length = 20;

        /// <summary>
        ///  Read Fix Rate Local Time Zone from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Fix Rate Local Time Zone
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
        ///  Fix Rate Local Time Zone as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}