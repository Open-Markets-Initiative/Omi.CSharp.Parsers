using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Special Field Message: The Special Field Message is used to send extra information on existing messages.
/// </summary>

public partial class SpecialFieldMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public NumberOfSpecialFields NumberOfSpecialFields;
    };
};
