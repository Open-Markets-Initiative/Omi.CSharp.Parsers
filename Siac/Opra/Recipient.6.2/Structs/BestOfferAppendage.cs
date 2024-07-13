using System.Runtime.InteropServices;

namespace Siac.Recipient
{
    /// <summary>
    ///  Best Offer Appendage
    /// </summary>

    public partial class BestOfferAppendage
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