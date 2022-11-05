using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nhom_06.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        [DisplayName("Tên sản phầm")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public string Name { get; set; }

   
    }
}
