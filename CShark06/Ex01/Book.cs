using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return "\nID: " + Id + "\nTitle: " + Title + "\nAuthor: " + Author + "\nPublisher: "
                + Publisher + "\nYear: " + Year + "\nPrice: " + Price;
        }
    }
}
