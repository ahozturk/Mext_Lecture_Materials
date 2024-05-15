using GPTExample.Application;
using GPTExample.Domain;

namespace GPTExample.Persistence;

public class PromptService : IPromptService
{
    private readonly GPTExampleDbContext _context;

    public PromptService(GPTExampleDbContext context)
    {
        _context = context;
    }

    public void Add(AddPromptDto addPromptDto)
    {
        _context.Prompts.Add(new GPTPrompt
        {
            PromptText = addPromptDto.PromptText,
            CreatedBy = addPromptDto.CreatedBy,
            // CreatedDate = DateTimeOffset.UtcNow
        });

        _context.SaveChanges();
    }

    public List<GetPromptDto> GetPrompts(string userId)
    {
        throw new NotImplementedException();
    }
}
