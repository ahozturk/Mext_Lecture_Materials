using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerApp.Domain.Abstractions
{
    public interface ITextLogger : ILogger
    {
        void AddSpaceLine();
    }
}
