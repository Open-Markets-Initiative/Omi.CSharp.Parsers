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
    public ushort Year => Fields.Year.Value;

    /// <summary>
    ///  MM
    /// </summary>
    public byte Month => Fields.Month.Value;

    /// <summary>
    ///  DD
    /// </summary>
    public byte Day => Fields.Day.Value;

    /// <summary>
    ///  WW
    /// </summary>
    public byte Week => Fields.Week.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Year Year;
        public Month Month;
        public Day Day;
        public Week Week;
    };

    protected Layout Fields;
};
