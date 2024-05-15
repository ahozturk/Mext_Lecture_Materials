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

    public Guid Add(AddPromptDto addPromptDto)
    {
        var newPrompt = new GPTPrompt
        {
            Id = Guid.NewGuid(),
            PromptText = addPromptDto.PromptText,
            CreatedBy = addPromptDto.CreatedBy,
            // CreatedDate = DateTimeOffset.UtcNow
        };

        _context.Prompts.Add(newPrompt);

        _context.SaveChanges();

        return newPrompt.Id;
    }

    public List<GetPromptDto> GetAll(string userId)
    {
        return _context.Prompts
            .Where(x => x.CreatedBy == userId)
            .Select(x => new GetPromptDto
            {
                PromptText = x.PromptText,
                ResponseText = x.ResponseText?? "No response yet",
                CreatedDate = x.CreatedDate
            }).ToList();
    }
}
