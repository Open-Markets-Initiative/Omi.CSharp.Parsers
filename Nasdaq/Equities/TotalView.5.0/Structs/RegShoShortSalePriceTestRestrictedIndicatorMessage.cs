using System.Runtime.InteropServices;

namespace Nasdaq.TotalView;

/// <summary>
///  Reg Sho Short Sale Price Test Restricted Indicator Message: NASDAQ processes orders based on the most Reg SHO Restriction status value.
/// </summary>

public partial class RegShoShortSalePriceTestRestrictedIndicatorMessage
{
    /// <summary>
    ///  Locate code identifying the security
    /// </summary>
    public ushort LocateCode => Layout.LocateCode.Value;

    /// <summary>
    ///  NASDAQ OMX internal tracking number
    /// </summary>
    public ushort TrackingNumber => Layout.TrackingNumber.Value;

    /// <summary>
    ///  Nanoseconds since midnight.
    /// </summary>
    public string Timestamp => Layout.Timestamp.Value;

    /// <summary>
    ///  Denotes the security symbol for the issue in the NASDAQ execution system.
    /// </summary>
    public string Stock => Layout.Stock.Value;

    /// <summary>
    ///  Denotes the Reg SHO Short Sale Price Test Restriction status for the issue at the time of the message dissemination
    /// </summary>
    public RegShoAction RegShoAction => Layout.RegShoAction.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public LocateCode LocateCode;
        public TrackingNumber TrackingNumber;
        public Timestamp Timestamp;
        public Stock Stock;
        public RegShoAction RegShoAction;
    };
};
