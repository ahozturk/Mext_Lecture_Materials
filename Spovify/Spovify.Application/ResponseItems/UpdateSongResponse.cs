namespace Spovify.Application;

public class UpdateSongResponse
{
    public bool IsSuccess { get; set; }
    public string? Error { get; set; }

    public UpdateSongResponse(bool isSuccess, string? error = null)
    {
        IsSuccess = isSuccess;
        Error = error;
    }
}
