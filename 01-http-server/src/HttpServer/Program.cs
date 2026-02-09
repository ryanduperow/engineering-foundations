using System.Net;
using System.Net.Sockets;
using System.Text;
using HttpServer;

// --- Set up routes ---
var router = new Router();

router.AddRoute("GET", "/", _ => new HttpResponse
{
    Body = "Welcome to the HTTP server"
});

router.AddRoute("GET", "/hello", _ => new HttpResponse
{
    Body = "Hello, world!"
});

router.AddRoute("POST", "/echo", request => new HttpResponse
{
    Body = request.Body
});

// --- Start listening ---
var listener = new TcpListener(IPAddress.Loopback, 5000);
listener.Start();
Console.WriteLine("Listening on http://127.0.0.1:5000 ...");

Console.CancelKeyPress += (_, e) =>
{
    e.Cancel = true;
    listener.Stop();
};

try
{
    while (true)
    {
        using TcpClient client = listener.AcceptTcpClient();
        Console.WriteLine("--- Connection received ---");

        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[1024];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string raw = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        var request = HttpRequest.Parse(raw);
        Console.WriteLine($"  {request.Method} {request.Path}");

        var response = router.Handle(request);
        Console.WriteLine($"  → {response.StatusCode} {response.ReasonPhrase}");

        byte[] responseBytes = response.ToBytes();
        stream.Write(responseBytes, 0, responseBytes.Length);
    }
}
catch (SocketException)
{
    Console.WriteLine("Server stopped.");
}
