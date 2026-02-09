namespace HttpServer;

public class Router
{
    private readonly Dictionary<string, Func<HttpRequest, HttpResponse>> _routes = new();

    public void AddRoute(string method, string path, Func<HttpRequest, HttpResponse> handler)
    {
        // Key is "GET /hello" — method + space + path
        string key = $"{method.ToUpper()} {path}";
        _routes[key] = handler;
    }

    public HttpResponse Handle(HttpRequest request)
    {
        string key = $"{request.Method} {request.Path}";

        if (_routes.TryGetValue(key, out var handler))
            return handler(request);

        // No matching route — 404
        return new HttpResponse
        {
            StatusCode = 404,
            ReasonPhrase = "Not Found",
            Body = $"404 Not Found: {request.Method} {request.Path}"
        };
    }
}
