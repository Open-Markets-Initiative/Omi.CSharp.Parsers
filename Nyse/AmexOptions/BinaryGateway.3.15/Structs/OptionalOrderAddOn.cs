using System.Runtime.InteropServices;

namespace Nyse.AmexOptions.BinaryGateway;

/// <summary>
///  Optional Order Add On
/// </summary>

public partial class OptionalOrderAddOn
{
    /// <summary>
    ///  Sub Msg Header
    /// </summary>
    public string SubMsgHeader => Layout.SubMsgHeader.Value;

    /// <summary>
    ///  Trigger price for Stop and Stop Limit orders
    /// </summary>
    public long StopPx => Layout.StopPx.Value;

    /// <summary>
    ///  0 = No MaxFloor
    /// </summary>
    public uint MaxFloor => Layout.MaxFloor.Value;

    /// <summary>
    ///  Options MarketMaker MPID for Directed MM Order or Market Maker MPID for PFOF.
    /// </summary>
    public string DeliverToCompId => Layout.DeliverToCompId.Value;

    /// <summary>
    ///  Clearing number of CMTA.
    /// </summary>
    public string ClearingFirm => Layout.ClearingFirm.Value;

    /// <summary>
    ///  Clearing Optional Data
    /// </summary>
    public string OptionalData => Layout.OptionalData.Value;

    /// <summary>
    ///  OCC number if a non-default value is to be used
    /// </summary>
    public string ClearingAccount => Layout.ClearingAccount.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SubMsgHeader SubMsgHeader;
        public StopPx StopPx;
        public MaxFloor MaxFloor;
        public DeliverToCompId DeliverToCompId;
        public ClearingFirm ClearingFirm;
        public OptionalData OptionalData;
        public ClearingAccount ClearingAccount;
    };
};
