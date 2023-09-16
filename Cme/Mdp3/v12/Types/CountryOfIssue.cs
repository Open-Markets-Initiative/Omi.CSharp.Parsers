using System;
using System.Runtime.CompilerServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Country Of Issue: Country of Origin, ISO alpha-2 country code
    /// </summary>
    public struct CountryOfIssue
    {
        /// <summary>
        ///  Fix Tag for Country Of Issue
        /// </summary>
        public const ushort FixTag = 470;

        /// <summary>
        ///  Length of Country Of Issue in bytes
        /// </summary>
        public const int Length = 2;

        /// <summary>
        ///  Read Country Of Issue from buffer
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Decode()
            => new string((sbyte *)Buffer, 0, Length);

        /// <summary>
        ///  Encode Country Of Issue
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
        ///  Country Of Issue as string
        /// </summary>
        public override string ToString()
            => Decode();

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Buffer[Length];
    }
}