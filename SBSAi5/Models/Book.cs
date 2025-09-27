using System;
using System.ComponentModel.DataAnnotations;

namespace SBSAi5.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Ấn bản")]
        public string Edition { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Năm xuất bản")]
        public DateTime PublishYear { get; set; }
        [Required]
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Giá")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn hình ảnh")]
        [Display(Name = "Hình ảnh")]
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}