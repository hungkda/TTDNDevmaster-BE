namespace ASP.NET02.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Img { get; set; }
        public double Cost { get; set; }
        public double Sale { get; set; }
        public int IdCategory { get; set; }
        public string Description { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
    }
}
