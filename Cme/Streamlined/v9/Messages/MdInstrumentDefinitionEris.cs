using System.Runtime.InteropServices;

namespace Cme.Streamlined;

/// <summary>
///  Md Instrument Definition Eris: MDInstrumentDefinitionEris
/// </summary>

public partial class MdInstrumentDefinitionEris
{

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
};
