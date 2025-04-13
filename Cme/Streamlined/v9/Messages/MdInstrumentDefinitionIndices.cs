using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Instrument Definition Indices: MDInstrumentDefinitionIndices
/// </summary>

public partial class MdInstrumentDefinitionIndices
{
    /// <summary>
    ///  Instrument Name or Symbol.
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    /// <summary>
    ///  Indicates the type of product the instrument is associated with in the message
    /// </summary>
    public sbyte Product => Fields.Product.Value;

    /// <summary>
    ///  Market used to help identify an instrument
    /// </summary>
    public string SecurityExchange => Fields.SecurityExchange.Value;

    /// <summary>
    ///  Identifies the currency for the instrument traded.
    /// </summary>
    public string Currency => Fields.Currency.Value;

    /// <summary>
    ///  Included on the message when a modification or deletion occurs.
    /// </summary>
    public SecurityUpdateAction SecurityUpdateAction => Fields.SecurityUpdateAction.Value;

    /// <summary>
    ///  Describes a class of service for a given data feed.
    /// </summary>
    public string MdFeedType => Fields.MdFeedType.Value;

    /// <summary>
    ///  This value indicates the channel ID as defined in the XML configuration file.
    /// </summary>
    public ushort ApplId => Fields.ApplId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public Symbol Symbol;
        public Product Product;
        public SecurityExchange SecurityExchange;
        public Currency Currency;
        public SecurityUpdateAction SecurityUpdateAction;
        public MdFeedType MdFeedType;
        public ApplId ApplId;
    };

    protected Layout Fields;
};
