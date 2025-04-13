using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Option Open Interest Message: Option Open Interest Message
/// </summary>

public partial class OptionOpenInterestMessage
{
    /// <summary>
    ///  Market Id
    /// </summary>
    public int MarketId => Fields.MarketId.Value;

    /// <summary>
    ///  Open Interest
    /// </summary>
    public int OpenInterest => Fields.OpenInterest.Value;

    /// <summary>
    ///  Date time the trade was investigated. Milliseconds since Jan 1st, 1970, 00:00:00 GMT
    /// </summary>
    public DateTime MessageDateTime => Fields.MessageDateTime.Value;

    /// <summary>
    ///  The date Open Interest is effective for, in the format of YYYY-MM-DD.
    /// </summary>
    public string OpenInterestDate => Fields.OpenInterestDate.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public MarketId MarketId;
        public OpenInterest OpenInterest;
        public MessageDateTime MessageDateTime;
        public OpenInterestDate OpenInterestDate;
    };

    protected Layout Fields;
};
