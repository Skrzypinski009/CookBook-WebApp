public class SearchService
{
    // Przykładowe dane
    private List<string> _data = new List<string>
    {
        "Blazor", "C#", "ASP.NET", "Programming", "Search", "Component", "Service"
    };

    public Task<List<string>> SearchAsync(string query)
    {
        if (string.IsNullOrWhiteSpace(query))
            return Task.FromResult(_data);

        var results = _data
            .Where(x => x.Contains(query, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Task.FromResult(results);
    }
}
