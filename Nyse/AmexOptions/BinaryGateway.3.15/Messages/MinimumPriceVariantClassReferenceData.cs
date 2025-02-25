using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Minimum Price Variant Class Reference Data
    /// </summary>

    public partial class MinimumPriceVariantClassReferenceData
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            public SeqMsgHeader SeqMsgHeader;
            public TransactTime TransactTime;
            public MpvClassName MpvClassName;
            public MpvClassId MpvClassId;
            public Rpimpv Rpimpv;
            public Luldmpv Luldmpv;
        };
    };
}