using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarDealer.ViewModels
{
    public class InventoryViewModel
    {
        public string Brand { get; set; }
        public List<string> model { get; set; }
    }
}