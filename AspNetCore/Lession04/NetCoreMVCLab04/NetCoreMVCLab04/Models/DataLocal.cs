namespace NetCoreMVCLab04.Models
{
    public class DataLocal
    {
        public static List<People> peoples = new List<People>()
        {
            new People()
            {
                Id = 1,
                Name = "Hùng",
                Email = "gacon@gmail.com",
                Phone = "0987654321",
                Address = "26 Hà Nội",
                Avatar = "images/Avatar/01.png",
                Birthday = Convert.ToDateTime("2001/02/09"),
                Bio = "Student for Vien cong nghe",
                Gender = 0
            },
            new People()
            {
                Id = 2,
                Name = "Gà Văn A",
                Email = "gacon12@gmail.com",
                Phone = "0943254321",
                Address = "26 Trung Hoa",
                Avatar = "images/Avatar/02.png",
                Birthday = Convert.ToDateTime("2001/02/09"),
                Bio = "Student for Vien cong nghe",
                Gender = 1
            },
            new People()
            {
                Id = 3,
                Name = "Gà Văn B",
                Email = "gacon1222@gmail.com",
                Phone = "0943254321",
                Address = "26 Trung Hoa",
                Avatar = "images/Avatar/03.png",
                Birthday = Convert.ToDateTime("2001/02/09"),
                Bio = "Student for Vien cong nghe",
                Gender = 1
            },
            new People()
            {
                Id = 4,
                Name = "Gà Văn C",
                Email = "gn12@gmail.com",
                Phone = "0943254321",
                Address = "26 Trung Hoa",
                Avatar = "images/Avatar/04.png",
                Birthday = Convert.ToDateTime("2001/02/09"),
                Bio = "Student for Vien cong nghe",
                Gender = 0
            }
        };

        //get people
        public static List<People> GetPeoples()
        {
            return peoples;
        }

        //get people by id
        public static People? GetPeopleById(int id)
        {
            var people = peoples.FirstOrDefault(x => x.Id == id);
            return people;
        }


        public static List<Category> categories = new List<Category>() { 
            new Category() { 
                Id = 1,
                Name = "Quần áo",

            },
            new Category() {
                Id = 2,
                Name = "Đồng hồ",
            },
            new Category() {
                Id = 3,
                Name = "Túi xách",
            }
        };

        public static List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Quần áo 01",
                Price = 199999,
                SalePrice = 0,
                Status = 0,
                CreatedDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/Product/quanao.jpg",
                CategoryId = 1,
                Description = "Quần áo chất lương cao"
            },
            new Product()
            {
                Id = 2,
                Name = "Quần áo 02",
                Price = 199999,
                SalePrice = 0,
                Status = 0,
                CreatedDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/Product/quanao1.jpg",
                CategoryId = 1,
                Description = "Quần áo chất lương cao"
            },
            new Product()
            {
                Id = 3,
                Name = "Đồng hồ 02",
                Price = 199999,
                SalePrice = 0,
                Status = 0,
                CreatedDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/Product/dongho1.jpg",
                CategoryId = 2,
                Description = "Đh chất lương cao"
            },
            new Product()
            {
                Id = 4,
                Name = "Đồng hồ 01",
                Price = 199999,
                SalePrice = 0,
                Status = 0,
                CreatedDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/Product/dongho2.jpg",
                CategoryId = 2,
                Description = "Đh chất lương cao"
            },
            new Product()
            {
                Id = 5,
                Name = "Túi xách 02",
                Price = 199999,
                SalePrice = 0,
                Status = 0,
                CreatedDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/Product/tuixach1.jpg",
                CategoryId = 3,
                Description = "Túi chất lương cao"
            },
            new Product()
            {
                Id = 6,
                Name = "Túi xách 01",
                Price = 199999,
                SalePrice = 0,
                Status = 0,
                CreatedDate = Convert.ToDateTime("2003/02/21"),
                Image = "images/Product/tuixach2.jpg",
                CategoryId = 3,
                Description = "Túi chất lương cao"
            },
        };

        //get product
        public static List<Product> GetProduct()
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
