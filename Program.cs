using Microsoft.Extensions.Configuration;

namespace shur_excel {
    class Program
    {
        public static Dictionary<string, BasicElement> configElements;

        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            configElements = config.GetRequiredSection("elements").Get<Dictionary<string, BasicElement>>();

            var line = "01.02.2024 | 09:22:30 | 1       |   99.983888 |  0.001272 |   0.001178 |  0.002204 |  0.001293 |  0.003327 |   0.000283 |  0.000643 |   0.000410 |   0.000473 |  0.000343 |  0.000547 |  0.002915 |  0.000296 |   0.000000 |   0.000000 |   0.000231 |  0.000137 |   0.000471 |  0.000090";

            var row = new Row(line);
        }
    }
}

