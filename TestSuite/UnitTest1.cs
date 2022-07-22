using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using webshopApi.Models;

namespace TestSuite;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        
        
    }

    [Test]
    public async Task Test1()
    {
        var client = new HttpClient();
        var result = await client.GetAsync("https://localhost:7126/api/products");
        Assert.That(true);
    }
}