namespace _Project._Scripts.WebServices
{
    internal static class UrlBase
    {
        private const string Host = "https://localhost:7271/";

        public static string Url(string name)
        {
            return string.Concat(Host, name);
        }

        public static string Url(string name, int id)
        {
            return string.Concat(Host, name, id);
        }
    }
}