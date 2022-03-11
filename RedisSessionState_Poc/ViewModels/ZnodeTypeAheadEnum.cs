namespace RedisSessionState_Poc
{
    public enum ZnodeTypeAheadEnum
    {
        StoreList,
        CatalogList,
        ProductList,
        PIMCatalogList,
        AccountList,
        EntityList,
        EligibleReturnOrderNumberList,
        PIMCategoryList,
        PIMProductList,
    }

    public enum ZnodeTypeAheadTypeNameEnum
    {
        Stores,
        Catalogs,
        Products,
        Accounts,
        Entities,
    }

    public enum ZnodeTypeAheadListGenericOptions
    {
        No = -1,
        All = 0
    }
}