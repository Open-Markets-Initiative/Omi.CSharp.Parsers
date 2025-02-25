using System.Runtime.InteropServices;

namespace Siac.Recipient;

/// <summary>
///  Block Timestamp
/// </summary>

public partial class BlockTimestamp
{
    /// <summary>
    ///  Contains The Number Seconds From Epoch 111970000000 Utc
    /// </summary>
    public uint Seconds => Layout.Seconds.Value;

    /// <summary>
    ///  The Nanosecond Portion Of The Time Currently Rounded To The Nearest Microsecond
    /// </summary>
    public uint Nanoseconds => Layout.Nanoseconds.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Seconds Seconds;
        public Nanoseconds Nanoseconds;
    };
};
