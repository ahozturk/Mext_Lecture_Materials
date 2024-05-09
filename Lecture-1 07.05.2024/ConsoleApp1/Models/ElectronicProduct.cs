using ConsoleApp1.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class ElectronicProduct : ProductBase, ISaving
    {
        public TimeSpan DefaultWarrantyDurationInDays { get; set; }
        public string FileName { get => "ElectronicProducts"; }

        public string GiveDescription()
        {
            return $"Product Name: {Name} - Price: {Price} - Warranty: {DefaultWarrantyDurationInDays.TotalDays / 365}";
        }

        //public override string GiveDescription()
        //{
        //    return $"Product Name: {Name} - Price: {Price} - Warranty: {DefaultWarrantyDurationInDays.TotalDays / 365}";
        //}
    }
}
