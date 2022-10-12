namespace _Project._Scripts.WebServices
{
    public static class UrlAddresses
    {
        public const string Host = "https://localhost:7271/";

        public static string Product() =>
            Url("Product");

        public static string ProductType() =>
            Url("ProductType");

        public static string MeasurementUnits() =>
            Url("MeasurementUnits");

        public static string ProductByTypeId(int id) =>
            Url("Product/byType/", id);

        private static string Url(string name)
        {
            return string.Concat(Host, name);
        }

        private static string Url(string name, int id)
        {
            return string.Concat(Host, name, id);
        }
    }
}