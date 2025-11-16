public class SearchService
{
    // Przykładowe dane
    private List<string> _data = new List<string>
    {
        "Blazor", "C#", "ASP.NET", "Programming", "Search", "Component", "Service"
    };

    private List<string> TakeForPage(List<string> list, int page, bool limit){
        if (limit)
        {
            int amount = 9;
            int idx = page-1;
            int firstIdx = idx * amount;
            if (list.Count < firstIdx)
            {
                return list;
            }

            if (list.Count < firstIdx + amount)
            {
                return list.GetRange(firstIdx, list.Count-firstIdx);
            }

            return list.GetRange(firstIdx, amount);
        }
        return list;
    }

    public Task<List<string>> SearchAsync(SearchModel model)
    {
        var taken = new List<string>();
        if (model.Author != null)
        {
            // take only author's records
            taken = TakeForPage(_data, model.Page, model.Limit);
        }
        else {
            taken = TakeForPage(_data, model.Page, model.Limit);
        }

        if (model.Query != null)
        {
            taken = taken
            .Where(x => x.Contains(model.Query, StringComparison.OrdinalIgnoreCase))
            .ToList();
        }

        return Task.FromResult(taken);
    }
}
