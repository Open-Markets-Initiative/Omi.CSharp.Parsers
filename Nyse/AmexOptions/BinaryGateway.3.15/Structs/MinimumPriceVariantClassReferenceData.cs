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
            SeqMsgHeader SeqMsgHeader;
            TransactTime TransactTime;
            MpvClassName MpvClassName;
            MpvClassId MpvClassId;
            Rpimpv Rpimpv;
            Luldmpv Luldmpv;
        };
    };
}