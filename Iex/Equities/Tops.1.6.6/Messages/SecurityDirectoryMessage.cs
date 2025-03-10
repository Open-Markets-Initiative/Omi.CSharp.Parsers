using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Security Directory Message: The System Event Message is used to indicate events that apply to the market or the data feed.
/// </summary>

public partial class SecurityDirectoryMessage
{

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
};
