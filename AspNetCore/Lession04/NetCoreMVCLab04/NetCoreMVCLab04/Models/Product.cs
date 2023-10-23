using System.ComponentModel.DataAnnotations;

namespace NetCoreMVCLab04.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Tên Sản phẩm")]
        public string Name { get; set; }

        [Display(Name = "Giá gốc")]
        public float Price { get; set; }

        [Display(Name = "Giá Sale")]
        public float SalePrice { get; set; }

        [Display(Name = "Trạng thái")]
        public byte Status { get; set; }

        [Display(Name = "Ngày thêm")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Ảnh")]
        public string Image {  get; set; }

        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        [Display(Name = "Mô tả")]
        public string Description { get; set; }
    }
}
