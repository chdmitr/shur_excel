using System.Globalization;

namespace shur_excel;

public class Row
{
    public Dictionary<string, Element> RowElements { get; private set; }
    public DateTime DateTime { get; }

    public Row(string line)
    {
        RowElements = [];
        var columns = line.Split('|').Select(c => c.Trim()).ToArray();
        DateTime = DateTime.ParseExact($"{columns[0]} {columns[1]}", "dd.MM.yyyy hh:mm:ss", CultureInfo.InvariantCulture);
        for (int i = 3; i < columns.Length; i++)
        {
            var itemPair = Program.configElements.FirstOrDefault(c => c.Value.NumFrom == i);
            if (itemPair.Key == null) { continue; }
            var element = new Element(itemPair.Value, double.Parse(columns[i]));
            RowElements.Add(itemPair.Key, element);
        }
    }
}
