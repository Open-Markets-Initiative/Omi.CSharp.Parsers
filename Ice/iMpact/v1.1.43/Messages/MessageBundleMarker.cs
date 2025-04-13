using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Message Bundle Marker: This message indicates where a bundle of messages starts or ends.
/// </summary>

public partial class MessageBundleMarker
{
    /// <summary>
    ///  Marker: ‘S’ – Start of a message bundle, ‘E’ – End of a message bundle
    /// </summary>
    public StartOrEnd StartOrEnd => Fields.StartOrEnd.Value;

    /// <summary>
    ///  The value used to associate bundles of the same transaction. This value will be 0 when the transaction has no trade. The value will be -1 if the channel does not support sub-bundling.
    /// </summary>
    public long TradeTransactionId => Fields.TradeTransactionId.Value;

    /// <summary>
    ///  This field will always be set to ‘ ‘ for Start of a message bundle.
    /// </summary>
    public IsTransactionEnd IsTransactionEnd => Fields.IsTransactionEnd.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public StartOrEnd StartOrEnd;
        public TradeTransactionId TradeTransactionId;
        public IsTransactionEnd IsTransactionEnd;
    };

    protected Layout Fields;
};
