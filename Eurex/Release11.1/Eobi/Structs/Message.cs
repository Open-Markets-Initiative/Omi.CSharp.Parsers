using System.Runtime.InteropServices;

namespace Eurex.Eobi
{
    /// <summary>
    ///  Message
    /// </summary>

    public partial class Message
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            MessageHeaderComp MessageHeaderComp;
        };
    };
}