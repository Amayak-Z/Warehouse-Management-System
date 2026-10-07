using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category {  get; set; }
        public int TotalStock {  get; set; }
        public int Reserved {  get; set; }
        public int FreeStock {  get; set; }
        public string DeliveryDate {  get; set; }
        public string ExpiryDate {  get; set; }


    }
}
