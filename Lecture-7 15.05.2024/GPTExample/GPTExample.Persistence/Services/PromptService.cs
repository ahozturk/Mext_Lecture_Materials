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

    public List<GetPromptDto> GetAll(string userId)
    {
        return _context.Prompts
            .Where(x => x.CreatedBy == userId)
            .Select(x => new GetPromptDto
            {
                PromptText = x.PromptText,
                ResponseText = x.ResponseText,
                CreatedDate = x.CreatedDate
            }).ToList();
    }
}
