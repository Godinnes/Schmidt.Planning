namespace Schmidt.Planning
{
    public static class ConfigurationExtention
    {
        public static IConfigurationBuilder AddConfiguration(this IConfigurationBuilder configuration)
        {
            using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("Schmidt.Planning.appsettings.json"))
                configuration.AddJsonStream(stream);

            return configuration;
        }
    }
}
