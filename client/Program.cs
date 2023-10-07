namespace com.ambientbytes.kestreldi.client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new HttpClient())
            {
                using var r = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5000/api/getdata");

                using (var response = await client.SendAsync(r))
                {
                    Console.WriteLine($"{response}");
                }
            }
        }
    }
}