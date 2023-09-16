using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Maturity Month Year: Number of entries in Market Data message.
    /// </summary>

    public partial class MaturityMonthYear
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Year Year;
            Month Month;
            Day Day;
            Week Week;
        };
    };
}