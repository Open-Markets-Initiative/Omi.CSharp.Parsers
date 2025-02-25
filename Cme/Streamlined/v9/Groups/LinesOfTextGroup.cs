using System.Runtime.InteropServices;

namespace Cme.Streamlined
{
    /// <summary>
    ///  Lines Of Text Group: Identifies number of lines of text body.
    /// </summary>

    public partial class LinesOfTextGroup
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public Text500 Text500;
        };
    };
}