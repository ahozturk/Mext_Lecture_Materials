
using System.Globalization;
using DataMining;

string allText = File.ReadAllText("/Users/hakan/Documents/Projects2/DataMining/Customers.csv");

string[] lines = allText.Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

// string lineExample = "CustomerKey,Gender,Name,City,State Code,State,Zip Code,Country,Continent,Birthday";

// string[] data = lineExample.Split(",");

List<Customer> customers = new();

foreach (string line in lines.Skip(1))
{
    string[] data = line.Split(",");

    Customer customer = new()
    {
        CustomerKey = Convert.ToInt32(data[0]),
        Gender = data[1],
        Name = data[2],
        City = data[3],
        StateCode = data[4],
        State = data[5],
        ZipCode = data[6],
        Country = data[7],
        Continent = data[8],
        Birthday = DateTime.Parse(data[9], new CultureInfo("en-US")),
    };

    customers.Add(customer);
}

var customerDataFromSA = customers.Where(x => x.State == "South Australia" && x.City == "PIMBA");

var cityGrouping = customers
    .Where(x => x.State == "South Australia")
    .GroupBy(x => x.City)
    .Select(g => new { City = g.Key, Count = g.Count() })
    .OrderBy(x => x.Count);

// foreach (var city in cityGrouping)
// {
//     Console.WriteLine($"City: {city.City}, Count: {city.Count}");
// }

foreach(var customer in customerDataFromSA)
{
    Console.WriteLine(customer.Name);
}

Console.WriteLine();
