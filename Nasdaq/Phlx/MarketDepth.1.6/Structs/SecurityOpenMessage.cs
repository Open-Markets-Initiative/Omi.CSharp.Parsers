using System.Runtime.InteropServices;

namespace Nasdaq.MarketDepth
{
    /// <summary>
    ///  Security Open Message: The options system plans to disseminate the Option Open Message for each option as soon as the opening is completed.  Upon receipt of the open state message, firms should be advised that the option denoted in the message is now available for auto execution within the PHLX ® Options Market System.  Upon receipt of the closed state message, firms should be advised that the option is no longer eligible for auto-execution within the Options Market System.
    /// </summary>

    public partial class SecurityOpenMessage
    {

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public unsafe struct Layout
        {
            Timestamp Timestamp;
            OptionId OptionId;
            OpenState OpenState;
        };
    };
}