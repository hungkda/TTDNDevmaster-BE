using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lession06.Theory.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        //[Display(Name = "Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150, ErrorMessage = "Tên phải có độ dài giới hạn 150 kí tự")]
        [Column(TypeName = "nvarchar(150)")]
        public string Name { get; set; }

        //[Display(Name = "Hình ảnh")]
        //[Required(ErrorMessage = "Hình ảnh không được để trống")]
        [Column(TypeName = "nvarchar(150)")]
        public string Image { get; set; }

        //[Display(Name = "Giá")]
        [Required(ErrorMessage = "Giá không được để trống")]
        //[Range(100000, double.MaxValue, ErrorMessage = "Giá nhỏ nhất là 100000")]
        //[DataType(DataType.Text)]
        public float Price { get; set; }

        //[Display(Name = "Giá ưu đãi")]
        //[Required(ErrorMessage = "Giá ưu đãi không được để trống")]
        //[Range(0, 90000, ErrorMessage = "Giá ưu đãi phải không âm và nhỏ hơn giá gốc 10%")]
        //[DataType(DataType.Text)]
        public double SalePrice { get; set; }

        //[Display(Name = "Trạng thái")]
        //[Required(ErrorMessage = "Trạng thái không được để trống")]
        public bool Status { get; set; }

        //[Display(Name = "Mô tả")]
        //[Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(1000, ErrorMessage = "Không được nhập quá 1000 kí tự")]
        [Column(TypeName ="ntext")]
        public string Description { get; set; }

        //[Display(Name = "Danh mục")]
        [Required(ErrorMessage = "Danh mục không được để trống")]
        public int CategoryId { get; set; }

        //[Display(Name = "Ngày đăng")]
        //[Required(ErrorMessage = "Ngày đăng không được để trống")]
        public DateTime CreatedDate { get; set; }

        public Category Category { get; set; }
    }
}
