using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Optional Order Add On
    /// </summary>

    public partial class OptionalOrderAddOn
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            SubMsgHeader SubMsgHeader;
            StopPx StopPx;
            MaxFloor MaxFloor;
            DeliverToCompId DeliverToCompId;
            ClearingFirm ClearingFirm;
            OptionalData OptionalData;
            ClearingAccount ClearingAccount;
        };
    };
}