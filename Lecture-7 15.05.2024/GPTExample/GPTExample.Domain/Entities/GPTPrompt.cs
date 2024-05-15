namespace GPTExample.Domain;

public class GPTPrompt : EntityBase<Guid>
{
    public string PromptText { get; set; }
    public string ResponseText { get; set; }
}
