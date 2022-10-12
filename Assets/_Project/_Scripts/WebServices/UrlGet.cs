namespace _Project._Scripts.WebServices
{
    public static class UrlGet
    {
        public static string Product() =>
            UrlBase.Url("Product");

        public static string Location() =>
            UrlBase.Url("Location");

        public static string Warehouse() =>
            UrlBase.Url("Warehouse");

        public static string WarehouseReception() =>
            UrlBase.Url("WarehouseReception");

        public static string ProductType() =>
            UrlBase.Url("ProductType");

        public static string MeasurementUnits() =>
            UrlBase.Url("MeasurementUnits");

        public static string ProductByTypeId(int id) =>
            UrlBase.Url("Product/byType/", id);

        public static string SpendByLocationId(int id) =>
            UrlBase.Url("Spend/location/", id);
    }
}