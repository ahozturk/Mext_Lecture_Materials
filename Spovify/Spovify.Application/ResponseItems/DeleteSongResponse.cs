namespace Spovify.Application;

public class DeleteSongResponse
{
    public bool IsSuccess { get; set; }
    public string? Error { get; set; }

    public DeleteSongResponse(bool isSuccess, string? error = null)
    {
        IsSuccess = isSuccess;
        Error = error;
    }
}
