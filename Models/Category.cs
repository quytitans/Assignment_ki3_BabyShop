using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentWCD_BabyFashionShop.Models
{
    public class Category
    {
        [Key]
        [DisplayName("ID")]
        public int Id { get; set; }
        [DisplayName("Category Name")]
        public string Name { get; set; }
        public virtual ICollection<Clothes>  Clothes { get; set; }
    }
}