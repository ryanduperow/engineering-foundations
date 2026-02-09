using System.Text;

namespace HttpServer;

public class HttpResponse
{
    public int StatusCode { get; set; } = 200;
    public string ReasonPhrase { get; set; } = "OK";
    public Dictionary<string, string> Headers { get; set; } = new();
    public string Body { get; set; } = "";

    public byte[] ToBytes()
    {
        // Auto-set Content-Length so the client knows when the body ends
        Headers["Content-Length"] = Encoding.UTF8.GetByteCount(Body).ToString();

        var sb = new StringBuilder();

        // Status line: "HTTP/1.1 200 OK"
        sb.Append($"HTTP/1.1 {StatusCode} {ReasonPhrase}\r\n");

        // Headers
        foreach (var header in Headers)
            sb.Append($"{header.Key}: {header.Value}\r\n");

        // Blank line separates headers from body
        sb.Append("\r\n");

        // Body
        sb.Append(Body);

        return Encoding.UTF8.GetBytes(sb.ToString());
    }
}
