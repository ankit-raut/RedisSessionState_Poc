namespace RedisSessionState_Poc
{
    #region Reset Password Status Type
    public enum ResetPasswordStatusTypes
    {
        Continue = 2001,
        LinkExpired = 2002,
        TokenMismatch = 2003,
        NoRecord = 2004,
    }
    #endregion
}
