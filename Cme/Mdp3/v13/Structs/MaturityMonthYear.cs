using System.Runtime.InteropServices;

namespace Cme.Mdp3
{
    /// <summary>
    ///  Maturity Month Year: MDInstrumentDefinitionFuture
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