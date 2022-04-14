Dictionary<string, double> ProductPriceList = new Dictionary<string, double>();
ProductPriceList.Add("Shampoo", 1.58);
ProductPriceList.Add("Milk", 0.69);
ProductPriceList.Add("Tea", 1.76);
ProductPriceList.Add("Donut", 0.35);
ProductPriceList.Add("Cream", 1.30);
ProductPriceList.Add("Cheese", 3.58);
ProductPriceList.Add("Potatoes", 0.58);
ProductPriceList.Add("Banana", 0.99);

var comp = 1;
int count = 0;
//My simpel version
foreach (var value in ProductPriceList.Values)
{
    if(value < comp)
    {
        count++;
    }
}

Console.WriteLine("Before merging: ");
foreach (KeyValuePair<string, double> kvp in ProductPriceList)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}
var MinimumPrice = ProductPriceList.Where(x => x.Value == ProductPriceList.Min(x2 => x2.Value)).First();
var MaximumPrice = ProductPriceList.Where(x => x.Value == ProductPriceList.Max(x2 => x2.Value)).First();

Console.WriteLine($"There are: {count} products that cost less than 1 Euro\n");
Console.WriteLine($"{MinimumPrice}\n");
Console.WriteLine($"{MaximumPrice}\n");

Dictionary<string, double> PriceList = new Dictionary<string, double>();
PriceList.Add("Soap", 0.65);
PriceList.Add("Soup", 3.5);
PriceList.Add("Apples", 0.69);

PriceList.ToList().ForEach(x => ProductPriceList.Add(x.Key, x.Value));
var ordered = from entry in ProductPriceList orderby entry.Value ascending select entry;

Console.WriteLine("The full list of merged dictionary items: \n");
foreach (KeyValuePair<string, double> kvp in ProductPriceList)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}