namespace RedisSessionState_Poc
{
    public enum ZnodeRoleEnum
    {
        Customer,
        Admin,
        B2B,
        User,
        Manager,
        Administrator
    }

    public enum ZnodeRoleAccessEnum
    {
        RO,
        WR,
        ED,
        DEL
    }

    public enum ZnodePermissionCodeEnum
    {
        DNRA,
        ARA,
        SRA
    }
}
