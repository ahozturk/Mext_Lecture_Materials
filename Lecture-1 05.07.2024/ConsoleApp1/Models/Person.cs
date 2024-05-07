using ConsoleApp1.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Person : IDescription
    {
        public string Name { get; set; }

        public string GiveDescription()
        {
            return $"Name: {Name}";
        }
    }
}
