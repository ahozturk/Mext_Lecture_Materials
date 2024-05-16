using Template.Application;

namespace Template.Infrastructure;

public class NotepadService : INotepadService
{
    public void WriteToTextFile(string text)
    {
        var path = "/Users/hakan/Documents/GitHub/Mext_Lecture_Materials/Lecture-9 16.05.2024/OnionArchitectureTemplate/Template.Presentation/notepad.txt";

        File.AppendAllText(path, text);
    }
}
