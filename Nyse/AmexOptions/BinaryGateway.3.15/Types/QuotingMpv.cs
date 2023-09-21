using System.Runtime.CompilerServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Quoting Mpv: Numeric value of the Quoting Minimum Price Variation for the
    /// </summary>

    public unsafe struct QuotingMpv
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
        ///  Read Quoting Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ulong Decode()
        {
            fixed (byte* pointer = Bytes) { return ((ulong)pointer)/Factor; }
        }

        /// <summary>
        ///  Write Quoting Mpv
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Encode(ulong value)
        {
            fixed (byte* pointer = Bytes) { *(ulong *)pointer = value * Factor; }
        }

        /// <summary>
        ///  Quoting Mpv as string
        /// </summary>
        public override string ToString()
            => $"{Decode()}";

        /// <summary>
        ///  Underlying bytes
        /// </summary>
        internal unsafe fixed byte Bytes[Size];
    }
}