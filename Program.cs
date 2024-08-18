using Microsoft.Extensions.Configuration;

namespace shur_excel;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        var elements = config.GetRequiredSection("elements")
            .Get<Dictionary<string, Element>>();

        Console.WriteLine(elements["Fe"].NumFrom); // 10
    }
}
