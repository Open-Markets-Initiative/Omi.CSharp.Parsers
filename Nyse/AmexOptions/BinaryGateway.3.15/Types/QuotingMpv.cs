using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Quoting Mpv: Numeric value of the Quoting Minimum Price Variation for the
    /// </summary>

    public struct QuotingMpv
    {
        /// <summary>
        ///  Decimal place factor for Quoting Mpv
        /// </summary>
        public const ulong Factor = 100000000;

        /// <summary>
        ///  Size of Quoting Mpv in bytes
        /// </summary>
        public const int Size = 8;

        /// <summary>
        ///  Quoting Mpv value
        /// </summary>
        public readonly ulong Value
            => Decode();

        /// <summary>
        ///  Read Quoting Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly ulong Decode()
            => Underlying / Factor;

        /// <summary>
        ///  Write Quoting Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
            => Underlying = value * Factor;

        /// <summary>
        ///  Quoting Mpv as string
        /// </summary>
        public readonly override string ToString()
            => $"{Value}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal ulong Underlying;
    }
}