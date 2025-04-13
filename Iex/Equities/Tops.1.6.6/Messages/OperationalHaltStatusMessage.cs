using System.Runtime.InteropServices;

namespace Iex.Tops;

/// <summary>
///  Operational Halt Status Message: The Exchange may suspend trading of one or more securities on IEX for operational reasons and indicates such operational halt using the Operational Halt Status Message.
/// </summary>

public partial class OperationalHaltStatusMessage
{
    /// <summary>
    ///  Operational halt status identifier
    /// </summary>
    public OperationalHaltStatus OperationalHaltStatus => Fields.OperationalHaltStatus.Value;

    /// <summary>
    ///  Time stamp of the system event
    /// </summary>
    public DateTime Timestamp => Fields.Timestamp.Value;

    /// <summary>
    ///  Security identifier
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public OperationalHaltStatus OperationalHaltStatus;
        public Timestamp Timestamp;
        public Symbol Symbol;
    };

    protected Layout Fields;
};
