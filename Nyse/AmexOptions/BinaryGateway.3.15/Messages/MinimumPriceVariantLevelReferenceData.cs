using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Minimum Price Variant Level Reference Data
    /// </summary>

    public partial class MinimumPriceVariantLevelReferenceData
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
        };
    };
}