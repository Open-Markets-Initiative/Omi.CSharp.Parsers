using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Security Directory Message: The System Event Message is used to indicate events that apply to the market or the data feed.
/// </summary>

public partial class SecurityDirectoryMessage
{
    /// <summary>
    ///  Security Directory Flags
    /// </summary>
    public string SecurityDirectoryFlags => Fields.SecurityDirectoryFlags.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    /// <summary>
    ///  Number of shares that represent a round lot
    /// </summary>
    public uint RoundLotSize => Fields.RoundLotSize.Value;

    /// <summary>
    ///  Corporate action adjusted previous official closing price
    /// </summary>
    public long AdjustedPocPrice => Fields.AdjustedPocPrice.Value;

    /// <summary>
    ///  Indicates which Limit Up-Limit Down price band calculation parameter is to be used
    /// </summary>
    public LuldTier LuldTier => Fields.LuldTier.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityDirectoryFlags SecurityDirectoryFlags;
        public Timestamp Timestamp;
        public Symbol Symbol;
        public RoundLotSize RoundLotSize;
        public AdjustedPocPrice AdjustedPocPrice;
        public LuldTier LuldTier;
    };

    protected Layout Fields;
};
