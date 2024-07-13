using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Block Timestamp
    /// </summary>

    public partial class BlockTimestamp
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Seconds Seconds;
            Nanoseconds Nanoseconds;
        };
    };
}