namespace Nyse.AmexOptions.Pillar
{
    using System.Runtime.CompilerServices;

    /// <summary>
    ///  Underlying Type
    /// </summary>

    public struct UnderlyingType
    {
        /// <summary>
        ///  Adr
        /// </summary>
        public const char Adr = 'A';

        /// <summary>
        ///  Common Stock
        /// </summary>
        public const char CommonStock = 'C';

        /// <summary>
        ///  Debentures
        /// </summary>
        public const char Debentures = 'D';

        /// <summary>
        ///  Etf
        /// </summary>
        public const char Etf = 'E';

        /// <summary>
        ///  Foreign
        /// </summary>
        public const char Foreign = 'F';

        /// <summary>
        ///  Ads
        /// </summary>
        public const char Ads = 'H';

        /// <summary>
        ///  Units
        /// </summary>
        public const char Units = 'I';

        /// <summary>
        ///  Misc Others
        /// </summary>
        public const char MiscOthers = 'M';

        /// <summary>
        ///  Index Linked Notes
        /// </summary>
        public const char IndexLinkedNotes = 'L';

        /// <summary>
        ///  Bonds
        /// </summary>
        public const char Bonds = 'N';

        /// <summary>
        ///  Ordinary Shares
        /// </summary>
        public const char OrdinaryShares = 'O';

        /// <summary>
        ///  Preferred Stock
        /// </summary>
        public const char PreferredStock = 'P';

        /// <summary>
        ///  Rights
        /// </summary>
        public const char Rights = 'R';

        /// <summary>
        ///  Beneficiary Interest
        /// </summary>
        public const char BeneficiaryInterest = 'S';

        /// <summary>
        ///  Structured Notes
        /// </summary>
        public const char StructuredNotes = 'T';

        /// <summary>
        ///  Closed End Fund
        /// </summary>
        public const char ClosedEndFund = 'U';

        /// <summary>
        ///  Warrant
        /// </summary>
        public const char Warrant = 'W';

        /// <summary>
        ///  Index
        /// </summary>
        public const char Index = 'X';

        /// <summary>
        ///  Options
        /// </summary>
        public const char Options = 'Z';

        /// <summary>
        ///  Length of Underlying Type in bytes
        /// </summary>
        public const int Length = 1;
    }
}