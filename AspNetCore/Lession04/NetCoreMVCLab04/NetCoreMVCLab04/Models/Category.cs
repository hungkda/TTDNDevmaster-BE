using System.ComponentModel.DataAnnotations;

namespace NetCoreMVCLab04.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Tên Danh Mục")]
        public string Name { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Người tạo")]
        public string CreateBy { get; set; }

        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }

        //thuộc tính quan hệ
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
