namespace HttpServer;

public class HttpRequest
{
    public string Method { get; set; } = "";
    public string Path { get; set; } = "";
    public string Version { get; set; } = "";
    public Dictionary<string, string> Headers { get; set; } = new();
    public string Body { get; set; } = "";

    public static HttpRequest Parse(string raw)
    {
        var request = new HttpRequest();

        // Split into lines using CRLF (HTTP spec requires \r\n)
        string[] lines = raw.Split("\r\n");

        if (lines.Length == 0)
            return request;

        // First line is the request line: "GET /hello HTTP/1.1"
        string[] requestLine = lines[0].Split(' ', 3);
        if (requestLine.Length >= 3)
        {
            request.Method = requestLine[0];
            request.Path = requestLine[1];
            request.Version = requestLine[2];
        }

        // Headers start at line 1, continue until we hit an empty line
        int i = 1;
        for (; i < lines.Length; i++)
        {
            if (lines[i] == "")
                break; // empty line = end of headers

            int colonIndex = lines[i].IndexOf(':');
            if (colonIndex > 0)
            {
                string key = lines[i][..colonIndex].Trim();
                string value = lines[i][(colonIndex + 1)..].Trim();
                request.Headers[key] = value;
            }
        }

        // Everything after the empty line is the body
        if (i + 1 < lines.Length)
        {
            request.Body = string.Join("\r\n", lines[(i + 1)..]);
        }

        return request;
    }
}
