namespace College.Core.Common
{

    public static class Constants
    {

        public static class DataStore
        {
            public static string SqlConnectionString { get; } = "ConnectionStrings:CollegeDBConnectionString";

            public static string RedisConnectionString { get; } = "ConnectionStrings:CollegeRedisConnectionString";
        }

    }

}
