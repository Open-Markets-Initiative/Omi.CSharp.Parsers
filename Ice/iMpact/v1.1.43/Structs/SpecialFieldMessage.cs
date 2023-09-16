using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Special Field Message
    /// </summary>

    public partial class SpecialFieldMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            NumberOfSpecialFields NumberOfSpecialFields;
        };
    };
}