using System.ComponentModel;

namespace RedisSessionState_Poc
{
    public enum ShippingConstraintsEnum
    {
        [Description("Ship Complete")]
        ShipComplete,
        [Description("Ship Partial")]
        ShipPartial
    }
}