namespace GPTExample.Application;

public interface IPromptService
{
    void Add(AddPromptDto addPromptDto);
    List<GetPromptDto> GetPrompts(string userId);
}
