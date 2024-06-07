namespace TrollifySound.Application.RequestParameters;

public record Pagination
{
    public int PageNumber { get; init; }
    public int PageSize { get; init; }
}
