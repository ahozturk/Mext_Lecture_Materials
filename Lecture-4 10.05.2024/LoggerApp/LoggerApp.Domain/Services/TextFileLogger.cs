using LoggerApp.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Domain.Services
{
    public class TextFileLogger : ITextLogger
    {
        private readonly string _path;

        public TextFileLogger()
        {
            _path = "C:\\Users\\Hakan\\Documents\\GitHub\\Mext_Lecture_Materials\\Lecture-4 10.05.2024\\LoggerApp\\LoggerApp.API\\logs.txt";
        }

        public void AddSpaceLine()
        {
            File.AppendAllText(_path, "\n");
        }

        public void Log(string message)
        {

            File.AppendAllText(_path, $"{message}\n");
        }
    }
}
