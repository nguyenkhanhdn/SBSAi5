using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SBSAi5.Models
{
    public class Category
    {
        [Key]
        [Display(Name = "Mã loại sách")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Tên loại sách")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Display(Name = "Hình ảnh")]
        public string ImageUrl { get; set; }
        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}