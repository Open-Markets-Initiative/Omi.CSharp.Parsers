namespace Nyse.AmexOptions.Pillar
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Risk User Type
    /// </summary>

    public struct RiskUserType
    {
        /// <summary>
        ///  Entering Firm
        /// </summary>
        public const char EnteringFirm = 'E';

        /// <summary>
        ///  Clearing Firm
        /// </summary>
        public const char ClearingFirm = 'C';

        /// <summary>
        ///  Nyse Floor Broker Firm
        /// </summary>
        public const char NyseFloorBrokerFirm = 'F';

        /// <summary>
        ///  Options Market Maker Firm
        /// </summary>
        public const char OptionsMarketMakerFirm = 'O';

        /// <summary>
        ///  Length of Risk User Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}