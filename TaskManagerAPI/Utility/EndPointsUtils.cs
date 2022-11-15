namespace TaskManagerAPI.Utility
{
    public static class EndPointsUtils
    {
        public const string BASE_ROUTE = "/Task";
        public const string ROUTE_Assignment_POST = $"{BASE_ROUTE}/CreateTask";
        public const string ROUTE_Assignment_GETAll = $"{BASE_ROUTE}/GetTask";
        public const string ROUTE_Assignment_GETById = $"{BASE_ROUTE}/GetTask/{{id}}";
        public const string ROUTE_Assignment_PUT = $"{BASE_ROUTE}/UpdateTask/{{id}}";
        public const string ROUTE_Assignment_DELETE = $"{BASE_ROUTE}/DeleteTask/{{id}}";
    }
}
