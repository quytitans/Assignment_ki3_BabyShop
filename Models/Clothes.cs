using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssignmentWCD_BabyFashionShop.Models
{
    public class Clothes
    {
        [Key]
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }
        [DisplayName("Tên sản phẩm")]
        public string Name { get; set; }
        [DisplayName("Hình ảnh")]
        public string Thumnail { get; set; }
        [DisplayName("Giá")]
        public double Price { get; set; }
        [DisplayName("Màu sắc")]
        public string Color { get; set; }
        [DisplayName("Trạng thái")] //-1 hết hàng 0 dừng kinh doanh 1 đang bán
        public int Status { get; set; }
        
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}