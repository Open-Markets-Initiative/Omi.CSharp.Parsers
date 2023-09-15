using System.Runtime.InteropServices;

namespace Ice.iMpact
{
    /// <summary>
    ///  Special Field
    /// </summary>

    public partial class SpecialField
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SpecialFieldId SpecialFieldId;
            SpecialFieldLength SpecialFieldLength;
        };
    };
}