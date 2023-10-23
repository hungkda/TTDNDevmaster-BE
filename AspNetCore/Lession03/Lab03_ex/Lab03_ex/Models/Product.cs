namespace Lab03_ex.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

        public List<Product> GetProductList()
        {
            List<Product> list = new List<Product>()
            {
                new Product { Id = 1, Image = "/images/dongho1.jpg", Name = "Đồng hồ 01"},
            new Product { Id = 2, Image = "/images/dongho1.jpg", Name = "Đồng hồ 0"},
            new Product { Id = 3, Image = "/images/dongho1.jpg", Name = "Đồng hồ 0"},
            };

            return list;
        }
    }
}
