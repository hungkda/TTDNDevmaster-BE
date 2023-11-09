using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lession06.Theory.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Tên danh mục không được để trống")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        public Boolean Status { get; set; }

        public DateTime CreatedDate { get; set; }

        //ds sản phẩm theo danh mục
        public ICollection<Product> products { get; set;}
    }
}
