using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
        class House
        {
            public string HouseNo { get; set; }
            public decimal Price { get; set; }
        }

        //tapk namespace con đại lý lồng bên trong namespace kinh doanh
        namespace Dealerhip
        {
            public class Car
            {
                public string CarNo { get; set; }
                public decimal Price { get; set; }
            }
        }
}
