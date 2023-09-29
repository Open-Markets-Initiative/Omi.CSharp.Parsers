using System.Runtime.CompilerServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Appl Id: This value indicates the channel ID as defined in the XML configuration file.
    /// </summary>

    public struct ApplId
    {
        /// <summary>
        ///  Fix Tag for Appl Id
        /// </summary>
        public const ushort FixTag = 1180;

        /// <summary>
        ///  Sentinel null value for Appl Id
        /// </summary>
        public const ushort NoValue = 65535;

        /// <summary>
        ///  Size of Appl Id in bytes
        /// </summary>
        public const int Size = 2;

        /// <summary>
        ///  Appl Id value
        /// </summary>
        public readonly ushort Value
            => Decode();

        /// <summary>
        ///  Read Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ushort Decode()
            => Underlying;

        /// <summary>
        ///  Try Read Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly bool TryRead(out ushort value)
        {
            value = Decode();
            return value != NoValue;
        }

        /// <summary>
        ///  Write Appl Id
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ushort value)
            => Underlying = value;

        /// <summary>
        ///  Set Appl Id to unused
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
            => Encode(NoValue);

        /// <summary>
        ///  Appl Id as string
        /// </summary>
        public readonly override string ToString()
            => TryRead(out var value) ? $"{value}" : "Not Applicable";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ushort Underlying;
    }
}