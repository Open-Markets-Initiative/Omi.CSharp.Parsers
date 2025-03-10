using System.Runtime.InteropServices;

namespace Iex.Deep;

/// <summary>
///  Operational Halt Status Message: The Exchange may suspend trading of one or more securities on IEX for operational reasons and indicates such operational halt using the Operational Halt Status Message.
/// </summary>

public partial class OperationalHaltStatusMessage
{

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public OperationalHaltStatus OperationalHaltStatus;
        public Timestamp Timestamp;
        public Symbol Symbol;
    };
};
