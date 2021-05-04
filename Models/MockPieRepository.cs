using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethenyPieShop2.Models
{
    public class MockPieRepository: IPieRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPies =>
            new List<Pie>
            {
                new Pie {PieId = 1, Name="Strawberry Pie", Price=15.95M,ShortDescription="Lorem Ipsum", LongDescription="]"},
                new Pie {PieId=2, Name="Cheese cake",Price=18.95M,ShortDescription="Lorem Ipsum", LongDescription="]"},
                new Pie {PieId=3, Name="Rhubarb Pie",Price=15.95M,ShortDescription="Lorem Ipsum", LongDescription="]"},
                new Pie {PieId=4, Name="Pumpkin pie", Price=12.95M, ShortDescription="lorem Ipsum",LongDescription="]"}
            };
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        public ICategoryRepository CategoryRepository => _categoryRepository;

        public Pie GetPieById(int pieId)
        {
            return AllPies.FirstOrDefault(p => p.PieId == pieId);
        }
    }
}
