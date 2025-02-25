using System.Runtime.InteropServices;

namespace Cme.Mdp3;

/// <summary>
///  Maturity Month Year: MDInstrumentDefinitionFuture
/// </summary>

public partial class MaturityMonthYear
{
    /// <summary>
    ///  YYYY
    /// </summary>
    public ushort Year => Layout.Year.Value;

    /// <summary>
    ///  MM
    /// </summary>
    public byte Month => Layout.Month.Value;

    /// <summary>
    ///  DD
    /// </summary>
    public byte Day => Layout.Day.Value;

    /// <summary>
    ///  WW
    /// </summary>
    public byte Week => Layout.Week.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Year Year;
        public Month Month;
        public Day Day;
        public Week Week;
    };
};
