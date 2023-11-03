namespace Lab05_ex.Models
{
    public class DataLocal
    {
        public static List<Category> categories = new List<Category>() {
            new Category() {
                Id = 1,
                Name = "Quần áo",
                CreateDate = Convert.ToDateTime("2001/02/02"),
                CreateBy = "HuoHuo",
                Status = true,
            },
            new Category() {
                Id = 2,
                Name = "Đồng hồ",
                CreateDate = Convert.ToDateTime("2001/02/02"),
                CreateBy = "Jingliu",
                Status = true,
            },
            new Category() {
                Id = 3,
                Name = "Túi xách",
                CreateDate = Convert.ToDateTime("2001/02/02"),
                CreateBy = "Kafka",
                Status = false,
            }
        };

        public static List<Category> GetCategory()
        {
            return categories;
        }

        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Quần áo 01",
                Price = 199999,
                SalePrice = 0,
                Status = true,
                CreateDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/quanao.jpg",
                CategoryId = 1,
                Decription = "Quần áo chất lương cao"
            },
            new Product()
            {
                Id = 2,
                Name = "Quần áo 02",
                Price = 199999,
                SalePrice = 0,
                Status = true,
                CreateDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/quanao1.jpg",
                CategoryId = 1,
                Decription = "Quần áo chất lương cao"
            },
            new Product()
            {
                Id = 3,
                Name = "Đồng hồ 02",
                Price = 199999,
                SalePrice = 0,
                Status = true,
                CreateDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/dongho1.jpg",
                CategoryId = 2,
                Decription = "Đh chất lương cao"
            },
            new Product()
            {
                Id = 4,
                Name = "Đồng hồ 01",
                Price = 199999,
                SalePrice = 0,
                Status = true,
                CreateDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/dongho2.jpg",
                CategoryId = 2,
                Decription = "Đh chất lương cao"
            },
            new Product()
            {
                Id = 5,
                Name = "Túi xách 02",
                Price = 199999,
                SalePrice = 0,
                Status = true,
                CreateDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/tuixach1.jpg",
                CategoryId = 3,
                Decription = "Túi chất lương cao"
            },
            new Product()
            {
                Id = 6,
                Name = "Túi xách 01",
                Price = 199999,
                SalePrice = 0,
                Status = false,
                CreateDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/tuixach2.jpg",
                CategoryId = 3,
                Decription = "Túi chất lương cao"
            },
        };

        //get product
        public static List<Product> GetProducts()
        {
            return products;
        }

        //get people by id
        public static Product? GetProductById(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            return product;
        }
    }
}
