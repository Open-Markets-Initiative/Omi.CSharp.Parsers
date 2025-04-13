using System.Runtime.InteropServices;

namespace Eurex.Eobi;

/// <summary>
///  Related Instrument Grp Comp
/// </summary>

public partial class RelatedInstrumentGrpComp
{
    /// <summary>
    ///  Related Security Id
    /// </summary>
    public long RelatedSecurityId => Fields.RelatedSecurityId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public RelatedSecurityId RelatedSecurityId;
    };

    protected Layout Fields;
};
