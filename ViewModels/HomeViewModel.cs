using BethenyPieShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pie> PiesOfTheweek { get; set; }
    }
}
