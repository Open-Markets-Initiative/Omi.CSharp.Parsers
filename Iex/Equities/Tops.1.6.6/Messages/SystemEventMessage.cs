using System.Runtime.InteropServices;

namespace Iex.Tops
{
    /// <summary>
    ///  System Event Message: The System Event Message is used to indicate events that apply to the market or the data feed.
    /// </summary>

    public partial class SystemEventMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SystemEvent SystemEvent;
            public Timestamp Timestamp;
        };
    };
}