using Eshop.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Nhom_06.Models
{
    public class Review
    {
        public int Id { get; set; }

        [DisplayName("Tên sản phẩm")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public int ProductID { get; set; }

        [DisplayName("Mã người dùng")]
        [Required(ErrorMessage = "{0} không được bỏ trống")]
        public int AccountID { get; set; } 


        [DisplayName("Nội dung review")]
        public string Content { get; set; }


        [DisplayName("Ngày tạo review")]
        [DataType(DataType.DateTime)]
        public DateTime PostedDate { get; set; } = DateTime.Now;

        // Collection reference property cho khóa ngoại từ Product
        public List<Product> Products { get; set; }

        // Collection reference property cho khóa ngoại từ InvoiceDetail
        public List<Account> Accounts { get; set; }

        public Review()
        {
            PostedDate = DateTime.Now;
        }
    }
}
