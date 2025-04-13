using System.Runtime.InteropServices;

namespace Ice.iMpact;

/// <summary>
///  Strip Info Message: This message will be sent out if there is strip date change during the trading session. If client does not care about strip date changes, client should ignore these messages.
/// </summary>

public partial class StripInfoMessage
{
    /// <summary>
    ///  Not used. Kept here for backward compatibility. Client should use the new 4-byte StripID field.
    /// </summary>
    public short OldStripId => Fields.OldStripId.Value;

    /// <summary>
    ///  Strip Type
    /// </summary>
    public string StripType => Fields.StripType.Value;

    /// <summary>
    ///  4 digit year
    /// </summary>
    public short BeginYear => Fields.BeginYear.Value;

    /// <summary>
    ///  Month range 1-12
    /// </summary>
    public short BeginMonth => Fields.BeginMonth.Value;

    /// <summary>
    ///  Begin Day
    /// </summary>
    public short BeginDay => Fields.BeginDay.Value;

    /// <summary>
    ///  4 digit year
    /// </summary>
    public short EndYear => Fields.EndYear.Value;

    /// <summary>
    ///  Month range 1-12
    /// </summary>
    public short EndMonth => Fields.EndMonth.Value;

    /// <summary>
    ///  End Day
    /// </summary>
    public short EndDay => Fields.EndDay.Value;

    /// <summary>
    ///  Strip Info
    /// </summary>
    public string StripInfo => Fields.StripInfo.Value;

    /// <summary>
    ///  StripID
    /// </summary>
    public int StripId => Fields.StripId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public OldStripId OldStripId;
        public StripType StripType;
        public BeginYear BeginYear;
        public BeginMonth BeginMonth;
        public BeginDay BeginDay;
        public EndYear EndYear;
        public EndMonth EndMonth;
        public EndDay EndDay;
        public StripInfo StripInfo;
        public StripId StripId;
    };

    protected Layout Fields;
};
