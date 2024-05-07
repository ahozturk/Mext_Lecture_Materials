using ConsoleApp1.Enums;
using ConsoleApp1.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ClothingProduct : ProductBase, IDescription
    {
        public ClothingSize Size { get; set; }
        public Color Color { get; set; }

        public string GiveDescription()
        {
            return $"Product Name: {Name} - Price: {Price} - Color: {Color}";
        }

        //public override string ProductDescription()
        //{
        //    return $"Product Name: {Name} - Price: {Price} - Color: {Color}";
        //}
    }
}
