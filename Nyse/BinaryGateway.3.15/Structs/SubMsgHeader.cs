using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.Pillar
{
    /// <summary>
    ///  Sub Msg Header
    /// </summary>

    public partial class SubMsgHeader
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SeqMsgType SeqMsgType;
            SeqMsgLength SeqMsgLength;
        };
    };
}