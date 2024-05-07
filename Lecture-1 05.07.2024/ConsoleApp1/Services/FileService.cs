using ConsoleApp1.Models.Common;
using ConsoleApp1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class FileService
    {
        public void SaveTextModel(ISaving model)
        {
            string fullPath = $"{FileDirectories.TextSavingPath}{model.FileName}";

            string content = $"{model.GiveDescription()}\n";

            File.AppendAllText(fullPath, content);
        }
    }
}
