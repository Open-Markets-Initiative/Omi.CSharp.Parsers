using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Instrument Definition Eris: MDInstrumentDefinitionEris
/// </summary>

public partial class MdInstrumentDefinitionEris
{
    /// <summary>
    ///  Product code.
    /// </summary>
    public string SecurityGroup12 => Fields.SecurityGroup12.Value;

    /// <summary>
    ///  Instrument Name or Symbol.
    /// </summary>
    public string Symbol => Fields.Symbol.Value;

    /// <summary>
    ///  Identifies the type of instrument.
    /// </summary>
    public string SecurityType4 => Fields.SecurityType4.Value;

    /// <summary>
    ///  Identifies the type of product.
    /// </summary>
    public byte ProductOptional => Fields.ProductOptional.Value;

    /// <summary>
    ///  Market used to help identify an instrument
    /// </summary>
    public string SecurityExchange => Fields.SecurityExchange.Value;

    /// <summary>
    ///  Maturity date of instrument
    /// </summary>
    public ushort MaturityDate => Fields.MaturityDate.Value;

    /// <summary>
    ///  Identifies the currency for the instrument traded.
    /// </summary>
    public string Currency => Fields.Currency.Value;

    /// <summary>
    ///  MDInstrumentDefinitionEris
    /// </summary>
    public string MinPriceIncrement => Fields.MinPriceIncrement.Value;

    /// <summary>
    ///  Included on the message when a modification or deletion occurs.
    /// </summary>
    public SecurityUpdateAction SecurityUpdateAction => Fields.SecurityUpdateAction.Value;

    /// <summary>
    ///  Rate type for the swap  and spread.
    /// </summary>
    public string RateType => Fields.RateType.Value;

    /// <summary>
    ///  Coupon Rate of the Swap.
    /// </summary>
    public int CouponRate => Fields.CouponRate.Value;

    /// <summary>
    ///  Identifies user-defined instruments. If the tag is not present, the instrument is not user-defined.
    /// </summary>
    public char UserDefinedInstrument => Fields.UserDefinedInstrument.Value;

    /// <summary>
    ///  This value indicates the channel ID as defined in the XML configuration file.
    /// </summary>
    public ushort ApplId => Fields.ApplId.Value;

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe struct Layout
    {
        public SecurityGroup12 SecurityGroup12;
        public Symbol Symbol;
        public SecurityType4 SecurityType4;
        public ProductOptional ProductOptional;
        public SecurityExchange SecurityExchange;
        public MaturityDate MaturityDate;
        public Currency Currency;
        public MinPriceIncrement MinPriceIncrement;
        public SecurityUpdateAction SecurityUpdateAction;
        public RateType RateType;
        public CouponRate CouponRate;
        public UserDefinedInstrument UserDefinedInstrument;
        public ApplId ApplId;
    };

    protected Layout Fields;
};
