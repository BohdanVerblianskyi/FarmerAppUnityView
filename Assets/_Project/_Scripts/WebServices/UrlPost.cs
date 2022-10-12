namespace _Project._Scripts.WebServices
{
    public static class UrlPost
    {
        public static string Location() =>
            UrlBase.Url("Location");

        public static string WarehouseReceptionTheSameProduct() =>
            UrlBase.Url("WarehouseReception/theSameProduct");

        public static string MeasurementUnitsNewProduct() =>
            UrlBase.Url("MeasurementUnits/newProduct");

        public static string SpendOwn() =>
            UrlBase.Url("Spend/own");

        public static string SpendFromWarehouse() =>
            UrlBase.Url("Spend/fromWarehouse");

        public static string SpendSalary() =>
            UrlBase.Url("Spend/sakary");
    }
}