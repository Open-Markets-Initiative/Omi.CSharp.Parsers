using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Best Bid Appendage
    /// </summary>

    public partial class BestBidAppendage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            ParticipantId ParticipantId;
            DenominatorCode DenominatorCode;
            Price Price;
            Size Size;
        };
    };
}