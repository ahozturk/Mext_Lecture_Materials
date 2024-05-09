using ConsoleApp1.Enums;
using ConsoleApp1.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ClothingProduct : ProductBase, ISaving
    {
        public string FileName { get => "ClothingProducts"; }

        public ClothingSize Size { get; set; }
        public Color Color { get; set; }
        
        public string GiveDescription()
        {
            return $"Product Name: {Name} - Price: {Price} - Color: {Color}";
        }

        //public void Save()
        //{
        //    string path = "Users\\Hakan\\Documents\\Projects\\ConsoleApp1\\ConsoleApp1\\ClothingProducts.txt";

        //    string content = $"Product Name: {Name} - Price: {Price} - Color: {Color}";

        //    File.AppendAllText(path, content);
        //}

        //public override string ProductDescription()
        //{
        //    return $"Product Name: {Name} - Price: {Price} - Color: {Color}";
        //}
    }
}
