namespace Nyse.AmexOptions.Pillar
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Quoting Mpv: 8 Byte Fixed Width Integer with 8 Decimal Place Precision
    /// </summary>

    public struct QuotingMpv
    {
        /// <summary>
        ///  Length of Quoting Mpv in bytes
        /// </summary>
        public const int Length = 8;

        /// <summary>
        ///  Decimal place factor for Quoting Mpv
        /// </summary>
        public const int Factor = 100000000;
    }
}