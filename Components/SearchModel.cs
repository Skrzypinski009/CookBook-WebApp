
public class SearchModel {
    public string? Query { get; set; } = null;
    public string? Author { get; set; } = null;
    public int Page { get; set; } = 1;
    public bool Limit { get; set; } = false;
}
