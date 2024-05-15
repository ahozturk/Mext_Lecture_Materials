namespace GPTExample.Application;

public interface IPromptService
{
    Guid Add(AddPromptDto addPromptDto);
    List<GetPromptDto> GetAll(string userId);
}
