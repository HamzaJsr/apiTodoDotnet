

namespace TodoApi
{
    public record Todo(int id, string title, DateTime startDate, DateTime? endDate = null)
    {
        
    }
}
