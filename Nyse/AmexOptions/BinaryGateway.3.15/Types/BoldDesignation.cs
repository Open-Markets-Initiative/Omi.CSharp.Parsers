using System.Runtime.CompilerServices;;

namespace Nyse.AmexOptions.BinaryGateway
{
    /// <summary>
    ///  Bold Designation: Enum
    /// </summary>

    public struct BoldDesignation
    {
        /// <summary>
        ///  Not Applicable
        /// </summary>
        public const char NotApplicable = '0';

        /// <summary>
        ///  Expose Order Info Only
        /// </summary>
        public const char ExposeOrderInfoOnly = '4';

        /// <summary>
        ///  Expose Order Info And Capacity Only
        /// </summary>
        public const char ExposeOrderInfoAndCapacityOnly = '5';

        /// <summary>
        ///  Expose Order Info And Participant Id Only
        /// </summary>
        public const char ExposeOrderInfoAndParticipantIdOnly = '6';

        /// <summary>
        ///  Expose Order Info Capacity And Participant Id
        /// </summary>
        public const char ExposeOrderInfoCapacityAndParticipantId = '7';

        /// <summary>
        ///  No Bold Designation Defaulting
        /// </summary>
        public const char NoBoldDesignationDefaulting = '8';

        /// <summary>
        ///  Length of Bold Designation in bytes
        /// </summary>
        public const int Length = 1;
    }
}