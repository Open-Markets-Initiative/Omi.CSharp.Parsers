using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Special Field
/// </summary>

public partial class SpecialField
{
    /// <summary>
    ///  Special Field Identifier
    /// </summary>
    public byte SpecialFieldId => Fields.SpecialFieldId.Value;

    /// <summary>
    ///  Length of this field
    /// </summary>
    public ushort SpecialFieldLength => Fields.SpecialFieldLength.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SpecialFieldId SpecialFieldId;
        public SpecialFieldLength SpecialFieldLength;
    };

    protected Layout Fields;
};
