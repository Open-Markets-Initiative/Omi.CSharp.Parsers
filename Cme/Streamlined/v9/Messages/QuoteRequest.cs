using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Quote Request: QuoteRequest
/// </summary>

public partial class QuoteRequest
{
    /// <summary>
    ///  Start of event processing time in number of nanoseconds since Unix epoch
    /// </summary>
    public ulong TransactTime => Fields.TransactTime.Value;

    /// <summary>
    ///  MatchEventIndicator bit set
    /// </summary>
    public string MatchEventIndicator => Fields.MatchEventIndicator.Value;

    /// <summary>
    ///  Quote request ID defined by the exchange.
    /// </summary>
    public string QuoteReqId => Fields.QuoteReqId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public TransactTime TransactTime;
        public MatchEventIndicator MatchEventIndicator;
        public QuoteReqId QuoteReqId;
    };

    protected Layout Fields;
};
