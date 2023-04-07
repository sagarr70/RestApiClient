namespace RestApiClient;
class Program
{
    static async Task Main(string[] args)
    {
        // Sample Api endpoint https://api.sampleapis.com/beers/al
        Console.WriteLine("Enter EndPoint : ");
        
        var client = new RestApiClient();
        client.endPoint = Console.ReadLine();
        var response =await client.makeRequest();
        Console.WriteLine(response.ToString());
        Console.Read();

    }
}